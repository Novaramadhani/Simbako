using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduk : Form
    {
        private int selectedId = -1;

        public FormProduk()
        {
            InitializeComponent();
        }

        private void FormProduk_Load(object sender, EventArgs e) => LoadData();

        private void LoadData()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_produk, nama_produk, stok, harga, kualitas FROM produk ORDER BY id_produk", conn);
            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvProduk.DataSource = dt;
        }

        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduk.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);
                txtNamaProduk.Text = row.Cells[1].Value.ToString();
                txtStok.Text = row.Cells[2].Value.ToString();
                txtHarga.Text = row.Cells[3].Value.ToString();
                txtKualitas.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO produk (nama_produk, stok, harga, kualitas) VALUES (@n,@s,@h,@k)", conn);
                cmd.Parameters.AddWithValue("n", txtNamaProduk.Text);
                cmd.Parameters.AddWithValue("s", decimal.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("h", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("k", txtKualitas.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil ditambahkan!");
                LoadData(); ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "UPDATE produk SET nama_produk=@n, stok=@s, harga=@h, kualitas=@k WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("n", txtNamaProduk.Text);
                cmd.Parameters.AddWithValue("s", decimal.Parse(txtStok.Text));
                cmd.Parameters.AddWithValue("h", decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("k", txtKualitas.Text);
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil diupdate!");
                LoadData(); ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            if (MessageBox.Show("Hapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM produk WHERE id_produk=@id", conn);
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produk berhasil dihapus!");
                LoadData(); ClearForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void ClearForm()
        {
            txtNamaProduk.Clear(); txtStok.Clear(); txtHarga.Clear(); txtKualitas.Clear();
            selectedId = -1;
        }
    }
}
