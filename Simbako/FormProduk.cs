using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduk : Form
    {
        public FormProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            LoadData();
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
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO produk (nama_produk, harga, stok, kualitas) VALUES (@n,@h,@s,@k)", conn);
                cmd.Parameters.AddWithValue("n", txtNamaProduk.Text);
                cmd.Parameters.AddWithValue("h", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("s", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("k", txtKualitas.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil disimpan!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduk.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvProduk.CurrentRow.Cells[0].Value);
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "UPDATE produk SET nama_produk=@n, harga=@h, stok=@s, kualitas=@k WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("n", txtNamaProduk.Text);
                cmd.Parameters.AddWithValue("h", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("s", int.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("k", txtKualitas.Text);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil diupdate!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
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

        // 🔧 Tambahan event handler kosong agar Designer tidak error
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNamaProduk_TextChanged(object sender, EventArgs e) { }
        private void txtHarga_TextChanged(object sender, EventArgs e) { }
        private void txtStok_TextChanged(object sender, EventArgs e) { }
        private void txtKualitas_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
