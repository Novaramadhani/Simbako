using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormCustomer : Form
    {
        private int selectedProdukId = -1;
        private decimal hargaSatuan = 0;
        private string lastNota = "";
        private string selectedProdukName = "";

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e) => LoadProduk();

        private void LoadProduk()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_produk, nama_produk, stok, harga, kualitas FROM produk WHERE stok > 0", conn);
            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvProduk.DataSource = dt;
            dgvProduk.Columns[0].HeaderText = "ID";
            dgvProduk.Columns[1].HeaderText = "Nama Produk";
            dgvProduk.Columns[2].HeaderText = "Stok (kg)";
            dgvProduk.Columns[3].HeaderText = "Harga/kg";
            dgvProduk.Columns[4].HeaderText = "Kualitas";
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduk.Rows[e.RowIndex];
                selectedProdukId = Convert.ToInt32(row.Cells[0].Value);
                selectedProdukName = row.Cells[1].Value?.ToString() ?? "";
                hargaSatuan = Convert.ToDecimal(row.Cells[3].Value);
                lblHarga.Text = $"Harga: Rp {hargaSatuan:N0}/kg";
            }
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            if (selectedProdukId < 0 || string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Pilih produk dan isi nama!"); return;
            }
            if (!decimal.TryParse(txtJumlah.Text, out decimal jml) || jml <= 0)
            {
                MessageBox.Show("Jumlah tidak valid!"); return;
            }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Insert customer
                var cmdC = new NpgsqlCommand(
                    "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                cmdC.Parameters.AddWithValue("n", txtNama.Text);
                cmdC.Parameters.AddWithValue("hp", txtNoHP.Text ?? "");
                int idC = Convert.ToInt32(cmdC.ExecuteScalar());

                decimal total = hargaSatuan * jml;

                var cmdJ = new NpgsqlCommand(
                    "INSERT INTO penjualan (id_customer, id_produk, jumlah, total_harga) " +
                    "VALUES (@ic, @ip, @j, @t)", conn);
                cmdJ.Parameters.AddWithValue("ic", idC);
                cmdJ.Parameters.AddWithValue("ip", selectedProdukId);
                cmdJ.Parameters.AddWithValue("j", jml);
                cmdJ.Parameters.AddWithValue("t", total);
                cmdJ.ExecuteNonQuery();

                var cmdS = new NpgsqlCommand(
                    "UPDATE produk SET stok=stok-@j WHERE id_produk=@ip", conn);
                cmdS.Parameters.AddWithValue("j", jml);
                cmdS.Parameters.AddWithValue("ip", selectedProdukId);
                cmdS.ExecuteNonQuery();

                Penjualan p = new Penjualan { Jumlah = jml };
                lastNota = p.CetakNota(selectedProdukName, txtNama.Text);
                lblTotal.Text = $"Total: Rp {total:N0}";

                MessageBox.Show("Pembelian berhasil!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadProduk();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnNota_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastNota))
                MessageBox.Show("Belum ada transaksi.");
            else
                MessageBox.Show(lastNota, "Nota Pembelian",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"]?.Show();
        }

        // 🔧 Tambahan untuk menghindari error Designer
        private void label6_Click(object sender, EventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
