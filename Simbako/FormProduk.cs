using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduk : Form
    {
        private int? selectedId = null;

        public FormProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            // Isi pilihan nama produk
            cmbNamaProduk.Items.Clear();
            cmbNamaProduk.Items.Add("Tembakau Rajangan");
            cmbNamaProduk.Items.Add("Tembakau Cerutu");
            cmbNamaProduk.Items.Add("Tembakau Kretek");

            // Isi pilihan kualitas
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.Add("Sangat Baik");
            cmbKualitas.Items.Add("Bagus");
            cmbKualitas.Items.Add("Kurang Baik");
            cmbKualitas.Items.Add("Bosok");

            // Isi pilihan status produksi/verifikasi
            cmbStatusProduksi.Items.Clear();
            cmbStatusProduksi.Items.Add("Pending");
            cmbStatusProduksi.Items.Add("Siap Jual");
            cmbStatusProduksi.Items.Add("Ditolak");

            LoadData();

            // Hubungkan event CellClick
            dgvProduk.CellClick += dgvProduk_CellClick;
        }

        private void LoadData()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT * FROM produk ORDER BY id_produk DESC", conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProduk.DataSource = dt;

                dgvProduk.Columns[0].HeaderText = "ID Produk";
                dgvProduk.Columns[1].HeaderText = "Nama Produk";
                dgvProduk.Columns[2].HeaderText = "Harga per kg";
                dgvProduk.Columns[3].HeaderText = "Stok (kg)";
                dgvProduk.Columns[4].HeaderText = "Kualitas";
                dgvProduk.Columns[5].HeaderText = "Status Produksi";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduk.Rows[e.RowIndex];

                // Isi field sesuai data yang dipilih
                cmbNamaProduk.Text = row.Cells[1].Value.ToString();
                txtHarga.Text = row.Cells[2].Value.ToString();
                txtStok.Text = row.Cells[3].Value.ToString();
                cmbKualitas.Text = row.Cells[4].Value.ToString();
                cmbStatusProduksi.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO produk (nama_produk, harga, stok, kualitas, status_verifikasi) VALUES (@n,@h,@s,@k,@sv)", conn);
                cmd.Parameters.AddWithValue("n", cmbNamaProduk.Text);
                cmd.Parameters.AddWithValue("h", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("s", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("k", cmbKualitas.Text);
                cmd.Parameters.AddWithValue("sv", cmbStatusProduksi.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil disimpan!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Edit Data Produk (nama, harga, stok, kualitas)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            int id = Convert.ToInt32(dgvProduk.CurrentRow.Cells[0].Value);

            if (!decimal.TryParse(txtHarga.Text, out decimal harga))
            {
                MessageBox.Show("Harga harus berupa angka!");
                return;
            }
            if (!int.TryParse(txtStok.Text, out int stok))
            {
                MessageBox.Show("Stok harus berupa angka!");
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "UPDATE produk SET nama_produk=@n, harga=@h, stok=@s, kualitas=@k WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("n", cmbNamaProduk.Text);
                cmd.Parameters.AddWithValue("h", harga);
                cmd.Parameters.AddWithValue("s", stok);
                cmd.Parameters.AddWithValue("k", cmbKualitas.Text);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data produk berhasil diupdate!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Update Status Produksi/Verifikasi saja
        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            int id = Convert.ToInt32(dgvProduk.CurrentRow.Cells[0].Value);

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "UPDATE produk SET status_verifikasi=@sv WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("sv", cmbStatusProduksi.Text);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Status produk berhasil diupdate!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProduk.CurrentRow.Cells[0].Value);
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM produk WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil dihapus!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler kosong agar Designer tidak error
        private void txtNamaProduk_TextChanged(object sender, EventArgs e) { }
        private void txtHarga_TextChanged(object sender, EventArgs e) { }
        private void txtStok_TextChanged(object sender, EventArgs e) { }
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatusProduksi_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
    }
}
