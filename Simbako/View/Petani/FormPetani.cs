using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPetani : Form
    {
        private readonly PetaniRepository repo;

        public FormPetani()
        {
            InitializeComponent();
            repo = new PetaniRepository();
        }

        private void FormPetani_Load(object sender, EventArgs e)
        {
            LoadRiwayatPanen();
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Busuk"
            });
        }

        private void LoadRiwayatPanen()
        {
            try
            {
                dgvRiwayatPanen.DataSource = repo.GetRiwayatPanen();
                dgvRiwayatPanen.Columns[0].HeaderText = "ID Panen";
                dgvRiwayatPanen.Columns[1].HeaderText = "Nama Petani";
                dgvRiwayatPanen.Columns[2].HeaderText = "Tanggal Panen";
                dgvRiwayatPanen.Columns[3].HeaderText = "Jumlah Panen";
                dgvRiwayatPanen.Columns[4].HeaderText = "Kualitas";
                dgvRiwayatPanen.Columns[5].HeaderText = "Status Verifikasi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load riwayat panen: " + ex.Message);
            }
        }

        private void btnSimpanPanen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaPetani.Text) ||
                string.IsNullOrWhiteSpace(txtJumlah.Text) ||
                string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Nama, jumlah, dan kualitas wajib diisi!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah panen tidak valid!");
                return;
            }

            try
            {
                int idPetani = repo.GetOrCreatePetani(txtNamaPetani.Text);
                repo.InsertPanen(idPetani, dtpTanggal.Value, jumlah, cmbKualitas.Text);

                MessageBox.Show("Data panen berhasil dikirim! Menunggu verifikasi Admin.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtJumlah.Clear();
                LoadRiwayatPanen();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error simpan panen: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadRiwayatPanen();
        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        // Event kosong biar Designer aman
        private void dgvRiwayatPanen_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvRiwayatPanen_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNamaPetani_TextChanged(object sender, EventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dtpTanggal_ValueChanged(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btnLihatStatus_Click_1(object sender, EventArgs e) { LoadRiwayatPanen(); }
        private void btnKeluar_Click_1(object sender, EventArgs e) { this.Close(); }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
