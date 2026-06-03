using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Npgsql;

namespace Simbako
{
    public partial class FormPanen : Form
    {
        private int selectedIdPanen = -1;
        private int selectedIdPetani = -1;

        public FormPanen()
        {
            InitializeComponent();
        }

        // Load data saat form dibuka
        private void FormPanen_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT p.id_panen, pt.nama_petani, p.tanggal_panen,
                                        p.jumlah_panen, p.kualitas, p.status_verifikasi
                                 FROM panen p
                                 JOIN petani pt ON p.id_petani = pt.id_petani
                                 ORDER BY p.tanggal_panen DESC";
                var cmd = new NpgsqlCommand(query, conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvPanen.DataSource = dt;
                dgvPanen.Columns[0].HeaderText = "ID";
                dgvPanen.Columns[1].HeaderText = "Nama Petani";
                dgvPanen.Columns[2].HeaderText = "Tanggal Panen";
                dgvPanen.Columns[3].HeaderText = "Jumlah (kg)";
                dgvPanen.Columns[4].HeaderText = "Kualitas";
                dgvPanen.Columns[5].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Klik baris di tabel
        private void dgvPanen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPanen.Rows[e.RowIndex];
                selectedIdPanen = Convert.ToInt32(row.Cells[0].Value);
                txtNamaPetani.Text = row.Cells[1].Value.ToString();
                dtpTanggal.Value = Convert.ToDateTime(row.Cells[2].Value);
                txtJumlah.Text = row.Cells[3].Value.ToString();
                cmbKualitas.Text = row.Cells[4].Value.ToString();
            }
        }

        // Tombol Simpan (Add/Update Petani lalu Panen)
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaPetani.Text) || string.IsNullOrEmpty(txtJumlah.Text))
            {
                MessageBox.Show("Nama petani dan jumlah tidak boleh kosong!");
                return;
            }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Cek atau buat petani baru
                var cmdPetani = new NpgsqlCommand(
                    "INSERT INTO petani (nama_petani) VALUES (@nama) ON CONFLICT DO NOTHING RETURNING id_petani", conn);
                cmdPetani.Parameters.AddWithValue("nama", txtNamaPetani.Text);
                var idPetaniObj = cmdPetani.ExecuteScalar();

                if (idPetaniObj == null)
                {
                    // Petani sudah ada, ambil id-nya
                    var cmdGet = new NpgsqlCommand(
                        "SELECT id_petani FROM petani WHERE nama_petani=@nama LIMIT 1", conn);
                    cmdGet.Parameters.AddWithValue("nama", txtNamaPetani.Text);
                    idPetaniObj = cmdGet.ExecuteScalar();
                }
                int idPetani = Convert.ToInt32(idPetaniObj);

                // Insert panen
                var cmdPanen = new NpgsqlCommand(
                    "INSERT INTO panen (id_petani, tanggal_panen, jumlah_panen, kualitas) " +
                    "VALUES (@idp, @tgl, @jml, @kual)", conn);
                cmdPanen.Parameters.AddWithValue("idp", idPetani);
                cmdPanen.Parameters.AddWithValue("tgl", dtpTanggal.Value.Date);
                cmdPanen.Parameters.AddWithValue("jml", decimal.Parse(txtJumlah.Text));
                cmdPanen.Parameters.AddWithValue("kual", cmbKualitas.Text);
                cmdPanen.ExecuteNonQuery();

                MessageBox.Show("Data panen berhasil disimpan!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Tombol Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdPanen < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            if (MessageBox.Show("Hapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM panen WHERE id_panen=@id", conn);
                cmd.Parameters.AddWithValue("id", selectedIdPanen);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus!");
                LoadData();
                ClearForm();
            }
        }

        // Tombol Verifikasi (khusus Admin)
        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            if (selectedIdPanen < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "UPDATE panen SET status_verifikasi='Terverifikasi' WHERE id_panen=@id", conn);
            cmd.Parameters.AddWithValue("id", selectedIdPanen);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Panen berhasil diverifikasi!");
            LoadData();
        }

        // Tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ClearForm()
        {
            txtNamaPetani.Clear();
            txtJumlah.Clear();
            cmbKualitas.SelectedIndex = -1;
            selectedIdPanen = -1;
        }
    }
}