using Simbako.Repository;
using Simbako.Model;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPanen : Form
    {
        private int selectedIdPanen = -1;
        private readonly PanenRepository repo;

        public FormPanen()
        {
            InitializeComponent();
            repo = new PanenRepository();
        }

        private void FormPanen_Load(object sender, EventArgs e)
        {
            cmbKualitas.Items.Clear();
            // ✅ Nilai persis sama dengan enum di DB
            cmbKualitas.Items.AddRange(new string[] { "Sangat Baik", "Bagus", "Kurang Baik", "Busuk" });
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = repo.GetAllPanen();

                dgvPanen.AutoGenerateColumns = false;
                dgvPanen.Columns.Clear();

                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IdPanen", HeaderText = "ID" });
                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NamaPetani", HeaderText = "Nama Petani" });
                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TanggalPanen", HeaderText = "Tanggal Panen" });
                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "JumlahPanen", HeaderText = "Jumlah (kg)" });
                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Kualitas", HeaderText = "Kualitas" });
                dgvPanen.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusVerifikasi", HeaderText = "Status" });

                dgvPanen.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message);
            }
        }

        private void dgvPanen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPanen.Rows[e.RowIndex];
                selectedIdPanen = Convert.ToInt32(row.Cells[0].Value ?? -1);

                txtNamaPetani.Text = row.Cells[1].Value?.ToString() ?? string.Empty;
                if (DateTime.TryParse(row.Cells[2].Value?.ToString(), out DateTime tgl))
                    dtpTanggal.Value = tgl;
                else
                    dtpTanggal.Value = DateTime.Now;

                txtJumlah.Text = row.Cells[3].Value?.ToString() ?? string.Empty;
                cmbKualitas.Text = row.Cells[4].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaPetani.Text) || string.IsNullOrEmpty(txtJumlah.Text))
            {
                MessageBox.Show("Nama petani dan jumlah tidak boleh kosong!");
                return;
            }
            try
            {
                int idPetani = repo.GetOrCreatePetani(txtNamaPetani.Text);
                repo.InsertPanen(idPetani, dtpTanggal.Value, decimal.Parse(txtJumlah.Text), cmbKualitas.Text);

                MessageBox.Show("Data panen berhasil disimpan!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error simpan panen: " + ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedIdPanen < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            try
            {
                repo.UpdatePanen(selectedIdPanen, dtpTanggal.Value, decimal.Parse(txtJumlah.Text), cmbKualitas.Text);
                MessageBox.Show("Data panen berhasil diupdate!");
                LoadData();
                ClearForm();
            }
            catch (Exception ex) { MessageBox.Show("Error update panen: " + ex.Message); }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedIdPanen < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repo.DeletePanen(selectedIdPanen);
                MessageBox.Show("Data berhasil dihapus!");
                LoadData();
                ClearForm();
            }
        }

        private void btnVerifikasi_Click(object sender, EventArgs e)
        {
            if (selectedIdPanen < 0) { MessageBox.Show("Pilih data dulu!"); return; }
            repo.VerifyPanen(selectedIdPanen);
            MessageBox.Show("Panen berhasil diverifikasi!");
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        private void ClearForm()
        {
            txtNamaPetani.Clear();
            txtJumlah.Clear();
            cmbKualitas.SelectedIndex = -1;
            selectedIdPanen = -1;
        }

        // Event kosong biar Designer aman
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void dgvPanen_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvPanen_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
    }
}
