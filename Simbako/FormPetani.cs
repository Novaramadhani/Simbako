using Npgsql;
using Simbako;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPetani : Form
    {
        public FormPetani()
        {
            InitializeComponent();
        }

        private void FormPetani_Load(object sender, EventArgs e)
        {
            // Load semua riwayat panen
            LoadRiwayat();
        }

        private void LoadRiwayat()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                string query = "SELECT p.id_panen, pt.nama_petani, p.tanggal_panen, " +
                               "p.jumlah_panen, p.kualitas, p.status_verifikasi " +
                               "FROM panen p JOIN petani pt ON p.id_petani=pt.id_petani " +
                               "ORDER BY p.tanggal_panen DESC LIMIT 50";
                var cmd = new NpgsqlCommand(query, conn);
                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvRiwayatPanen.DataSource = dt;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnSimpanPanen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNamaPetani.Text))
            {
                MessageBox.Show("Masukkan nama petani!"); return;
            }
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Simpan petani jika belum ada
                var cmdPetani = new NpgsqlCommand(
                    "INSERT INTO petani (nama_petani) VALUES (@n) ON CONFLICT DO NOTHING RETURNING id_petani",
                    conn);
                cmdPetani.Parameters.AddWithValue("n", txtNamaPetani.Text);
                var idObj = cmdPetani.ExecuteScalar();

                if (idObj == null)
                {
                    var cmdGet = new NpgsqlCommand(
                        "SELECT id_petani FROM petani WHERE nama_petani=@n LIMIT 1", conn);
                    cmdGet.Parameters.AddWithValue("n", txtNamaPetani.Text);
                    idObj = cmdGet.ExecuteScalar();
                }
                int idPetani = Convert.ToInt32(idObj);

                // Simpan panen
                var cmdPanen = new NpgsqlCommand(
                    "INSERT INTO panen (id_petani, tanggal_panen, jumlah_panen, kualitas) " +
                    "VALUES (@idp, @tgl, @jml, @kual)", conn);
                cmdPanen.Parameters.AddWithValue("idp", idPetani);
                cmdPanen.Parameters.AddWithValue("tgl", dtpTanggal.Value.Date);
                cmdPanen.Parameters.AddWithValue("jml", decimal.Parse(txtJumlah.Text));
                cmdPanen.Parameters.AddWithValue("kual", cmbKualitas.Text);
                cmdPanen.ExecuteNonQuery();

                MessageBox.Show("Data panen berhasil dikirim! Menunggu verifikasi Admin.",
                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtJumlah.Clear();
                LoadRiwayat();
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnLihatStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitur monitoring produksi: lihat tab riwayat panen untuk status verifikasi.");
            LoadRiwayat();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Form1"]?.Show();
        }

        // 🔧 Tambahan event handler kosong agar Designer tidak error
        private void label6_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
