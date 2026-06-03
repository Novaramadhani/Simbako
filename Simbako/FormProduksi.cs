using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormProduksi : Form
    {
        private int selectedId = -1;

        public FormProduksi()
        {
            InitializeComponent();
        }

        private void FormProduksi_Load(object sender, EventArgs e)
        {
            LoadPanenCombo();
            LoadData();
        }

        private void LoadPanenCombo()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_panen, id_panen::text FROM panen WHERE status_verifikasi='Terverifikasi'", conn);
            var reader = cmd.ExecuteReader();
            cmbIdPanen.Items.Clear();
            while (reader.Read())
                cmbIdPanen.Items.Add(reader.GetInt32(0).ToString());
        }

        private void LoadData()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT id_produksi, id_panen, jenis_proses, status_produksi, hasil_produksi " +
                "FROM produksi ORDER BY id_produksi DESC", conn);
            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvProduksi.DataSource = dt;
        }

        private void dgvProduksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduksi.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);
                cmbIdPanen.Text = row.Cells[1].Value.ToString();
                txtJenisProses.Text = row.Cells[2].Value.ToString();
                cmbStatus.Text = row.Cells[3].Value.ToString();
                txtHasil.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO produksi (id_panen, jenis_proses, status_produksi, hasil_produksi) " +
                    "VALUES (@idp, @proses, @status, @hasil)", conn);
                cmd.Parameters.AddWithValue("idp", int.Parse(cmbIdPanen.Text));
                cmd.Parameters.AddWithValue("proses", txtJenisProses.Text);
                cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produksi berhasil disimpan!");
                LoadData();
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
                    "UPDATE produksi SET status_produksi=@status, hasil_produksi=@hasil WHERE id_produksi=@id", conn);
                cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Status berhasil diupdate!");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            if (MessageBox.Show("Hapus?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM produksi WHERE id_produksi=@id", conn);
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                LoadData();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
    }
}
