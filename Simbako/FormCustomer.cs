using Npgsql;
using Simbako;
using System;
using System.Data;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadProduk();
            LoadDataPenjualan();
        }

        private void LoadProduk()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_produk, nama_produk, harga FROM produk", conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                cmbNamaProduk.DataSource = dt;
                cmbNamaProduk.DisplayMember = "nama_produk"; // tampilkan nama
                cmbNamaProduk.ValueMember = "id_produk";     // simpan id
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load produk: " + ex.Message);
            }
        }

        private void LoadDataPenjualan()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT p.id_penjualan, p.tanggal_penjualan, p.jumlah, p.total_harga, pr.nama_produk " +
                    "FROM penjualan p " +
                    "JOIN produk pr ON p.id_produk = pr.id_produk " +
                    "ORDER BY p.id_penjualan DESC", conn);

                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvProduk.DataSource = dt;

                dgvProduk.Columns[0].HeaderText = "ID Penjualan";
                dgvProduk.Columns[1].HeaderText = "Tanggal";
                dgvProduk.Columns[2].HeaderText = "Jumlah (kg)";
                dgvProduk.Columns[3].HeaderText = "Total Harga";
                dgvProduk.Columns[4].HeaderText = "Nama Produk";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load penjualan: " + ex.Message);
            }
        }

        private void btnBeli_Click_1(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Ambil harga produk dari ComboBox DataSource
                DataRowView drv = cmbNamaProduk.SelectedItem as DataRowView;
                decimal harga = Convert.ToDecimal(drv["harga"]);
                decimal jumlah = decimal.Parse(txtJumlah.Text);
                decimal total = harga * jumlah;

                var cmd = new NpgsqlCommand(
                    "INSERT INTO penjualan (id_customer, id_produk, tanggal_penjualan, jumlah, total_harga) " +
                    "VALUES (@c,@p,@t,@j,@th)", conn);

                // sementara id_customer isi dummy (misal 1) kalau belum ada tabel customer
                cmd.Parameters.AddWithValue("c", 1);
                cmd.Parameters.AddWithValue("p", Convert.ToInt32(cmbNamaProduk.SelectedValue));
                cmd.Parameters.AddWithValue("t", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("j", jumlah);
                cmd.Parameters.AddWithValue("th", total);
                cmd.ExecuteNonQuery();

                lblHarga.Text = "Harga : " + harga.ToString("N0");
                lblTotal.Text = "Total : " + total.ToString("N0");

                MessageBox.Show("Pembelian berhasil!");
                LoadDataPenjualan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error beli produk: " + ex.Message);
            }
        }

        private void btnNota_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show($"Nota:\nNama: {txtNama.Text}\nNo HP: {txtNoHP.Text}\nJumlah: {txtJumlah.Text} kg\nProduk: {cmbNamaProduk.Text}\n{lblHarga.Text}\n{lblTotal.Text}");
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadDataPenjualan();

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler kosong agar Designer tidak error
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
        private void cmbNamaProduk_SelectedIndexChanged(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblHarga_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
