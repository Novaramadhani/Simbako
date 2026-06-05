using System;
using System.Windows.Forms;
using Npgsql;

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
            // Isi pilihan status produksi
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Menunggu");
            cmbStatus.Items.Add("Proses");
            cmbStatus.Items.Add("Selesai");
            cmbStatus.Items.Add("Siap Jual");

            // Isi pilihan jenis proses
            cmbJenisProses.Items.Clear();
            cmbJenisProses.Items.Add("Pengeringan");
            cmbJenisProses.Items.Add("Pembungkusan");

            // Load combo ID Panen terverifikasi dan data produksi
            LoadPanenCombo();
            LoadDataProduksi();
        }

        // Ambil daftar panen yang sudah terverifikasi
        private void LoadPanenCombo()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT id_panen FROM public.panen WHERE status_verifikasi='Terverifikasi'", conn);
                var reader = cmd.ExecuteReader();
                cmbldPanen.Items.Clear();
                while (reader.Read())
                    cmbldPanen.Items.Add(reader.GetInt32(0).ToString());
            }
            catch (Exception ex) { MessageBox.Show("Error load panen: " + ex.Message); }
        }

        // Load data produksi ke DataGridView
        private void LoadDataProduksi()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT id_produksi, id_panen, jenis_proses, status_produksi, hasil_produksi " +
                    "FROM public.produksi ORDER BY id_produksi DESC", conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProduksi.DataSource = dt;

                dgvProduksi.Columns[0].HeaderText = "ID Produksi";
                dgvProduksi.Columns[1].HeaderText = "ID Panen";
                dgvProduksi.Columns[2].HeaderText = "Jenis Proses";
                dgvProduksi.Columns[3].HeaderText = "Status Produksi";
                dgvProduksi.Columns[4].HeaderText = "Hasil Produksi (kg)";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Klik baris di DataGridView
        private void dgvProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduksi.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells[0].Value);
                cmbldPanen.Text = row.Cells[1].Value.ToString();
                cmbJenisProses.Text = row.Cells[2].Value.ToString();
                cmbStatus.Text = row.Cells[3].Value.ToString();
                txtHasil.Text = row.Cells[4].Value?.ToString() ?? "";
            }
        }

        // Simpan data produksi baru
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "INSERT INTO public.produksi (id_panen, jenis_proses, status_produksi, hasil_produksi) " +
                    "VALUES (@idp, @proses, @status, @hasil)", conn);
                cmd.Parameters.AddWithValue("idp", int.Parse(cmbldPanen.Text));
                cmd.Parameters.AddWithValue("proses", cmbJenisProses.Text);
                cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produksi berhasil disimpan!");
                LoadDataProduksi();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Edit status/hasil produksi (Update Status)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "UPDATE public.produksi SET jenis_proses=@proses, status_produksi=@status, hasil_produksi=@hasil WHERE id_produksi=@id", conn);
                cmd.Parameters.AddWithValue("proses", cmbJenisProses.Text);
                cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produksi berhasil diupdate!");
                LoadDataProduksi();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        // Hapus data produksi
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand("DELETE FROM public.produksi WHERE id_produksi=@id", conn);
                cmd.Parameters.AddWithValue("id", selectedId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produksi berhasil dihapus!");
                LoadDataProduksi();
            }
        }

        // Refresh data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataProduksi();
            LoadPanenCombo();
        }

        // Event handler kosong sesuai Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void cmbJenisProses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bisa ditambahkan logika kalau perlu
        }
    }
}
