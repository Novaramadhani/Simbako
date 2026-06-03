using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPenjualan : Form
    {
        private int selectedId = -1;
        private decimal hargaSatuan = 0;
        private int idProdukSelected = -1;

        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            LoadProdukCombo();
            LoadData();
        }

        private void LoadProdukCombo()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_produk, nama_produk, harga FROM produk WHERE stok > 0", conn);
            var reader = cmd.ExecuteReader();
            cmbProduk.Items.Clear();
            while (reader.Read())
            {
                cmbProduk.Items.Add(new
                {
                    Id = reader.GetInt32(0),
                    Nama = reader.GetString(1),
                    Harga = reader.GetDecimal(2),
                    Display = reader.GetString(1)
                });
            }
            cmbProduk.DisplayMember = "Display";
        }

        private void cmbProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProduk.SelectedItem != null)
            {
                dynamic item = cmbProduk.SelectedItem;
                idProdukSelected = item.Id;
                hargaSatuan = item.Harga;
                lblHarga.Text = $"Harga: Rp {hargaSatuan:N0}/kg";
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtJumlah.Text, out decimal jml))
            {
                Penjualan p = new Penjualan();
                decimal total = p.BuatTransaksi(hargaSatuan, jml);
                lblTotal.Text = $"Total: Rp {total:N0}";
            }
            else
            {
                MessageBox.Show("Jumlah tidak valid!");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (idProdukSelected < 0 || string.IsNullOrEmpty(txtNamaCustomer.Text))
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!"); return;
            }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Simpan atau ambil customer
                var cmdCust = new NpgsqlCommand(
                    "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                cmdCust.Parameters.AddWithValue("n", txtNamaCustomer.Text);
                cmdCust.Parameters.AddWithValue("hp", txtNoHP.Text ?? "");
                int idCust = Convert.ToInt32(cmdCust.ExecuteScalar());

                decimal jml = decimal.Parse(txtJumlah.Text);
                decimal total = hargaSatuan * jml;

                // Simpan penjualan
                var cmdJual = new NpgsqlCommand(
                    "INSERT INTO penjualan (id_customer, id_produk, jumlah, total_harga) " +
                    "VALUES (@ic, @ip, @j, @t)", conn);
                cmdJual.Parameters.AddWithValue("ic", idCust);
                cmdJual.Parameters.AddWithValue("ip", idProdukSelected);
                cmdJual.Parameters.AddWithValue("j", jml);
                cmdJual.Parameters.AddWithValue("t", total);
                cmdJual.ExecuteNonQuery();

                // Kurangi stok
                var cmdStok = new NpgsqlCommand(
                    "UPDATE produk SET stok = stok - @j WHERE id_produk = @ip", conn);
                cmdStok.Parameters.AddWithValue("j", jml);
                cmdStok.Parameters.AddWithValue("ip", idProdukSelected);
                cmdStok.ExecuteNonQuery();

                MessageBox.Show("Transaksi berhasil disimpan!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            if (cmbProduk.SelectedItem == null || string.IsNullOrEmpty(txtNamaCustomer.Text))
            {
                MessageBox.Show("Isi data dulu!"); return;
            }
            dynamic item = cmbProduk.SelectedItem;
            decimal jml = decimal.TryParse(txtJumlah.Text, out decimal j) ? j : 0;

            Penjualan p = new Penjualan { Jumlah = jml };
            string nota = p.CetakNota(item.Nama, txtNamaCustomer.Text);
            MessageBox.Show(nota, "Nota Transaksi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadData()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pj.id_penjualan, c.nama_customer, pr.nama_produk, " +
                "pj.tanggal_penjualan, pj.jumlah, pj.total_harga " +
                "FROM penjualan pj " +
                "JOIN customer c ON pj.id_customer=c.id_customer " +
                "JOIN produk pr ON pj.id_produk=pr.id_produk " +
                "ORDER BY pj.id_penjualan DESC", conn);
            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvPenjualan.DataSource = dt;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}

