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
            cmbStatus.Items.AddRange(new string[] { "Menunggu", "Proses", "Selesai", "Siap Jual" });

            // Isi pilihan jenis proses (harus sesuai constraint di DB)
            cmbJenisProses.Items.Clear();
            cmbJenisProses.Items.AddRange(new string[] {
                "Fermentasi", "Pengeringan", "Penggulungan", "Pembungkusan", "Penyimpanan"
            });

            // Isi pilihan jenis tembakau (produk akhir)
            cmbJenisTembakau.Items.Clear();
            cmbJenisTembakau.Items.AddRange(new string[] {
                "Tembakau Rajangan", "Tembakau Kretek", "Tembakau Cerutu"
            });

            // Isi pilihan kualitas
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Bosok"
            });

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
                    "SELECT id_panen FROM panen WHERE status_verifikasi='Terverifikasi'", conn);
                var reader = cmd.ExecuteReader();
                cmbldPanen.Items.Clear();
                while (reader.Read())
                    cmbldPanen.Items.Add(reader.GetInt32(0).ToString());
            }
            catch (Exception ex) { MessageBox.Show("Error load panen: " + ex.Message); }
        }

        // Load data produksi ke DataGridView
        // Load data produksi ke DataGridView
        private void LoadDataProduksi()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
    "SELECT id_produksi, id_panen, nama_produk, jenis_proses, jumlah_diolah, hasil_produksi, status_produksi, kualitas, harga " +
    "FROM produksi ORDER BY id_produksi DESC", conn);

                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvProduksi.DataSource = dt;

                dgvProduksi.Columns[0].HeaderText = "ID Produksi";
                dgvProduksi.Columns[1].HeaderText = "ID Panen";
                dgvProduksi.Columns[2].HeaderText = "Nama Produk";
                dgvProduksi.Columns[3].HeaderText = "Jenis Proses";
                dgvProduksi.Columns[4].HeaderText = "Jumlah Diolah (kg)";
                dgvProduksi.Columns[5].HeaderText = "Hasil Produksi (kg)";
                dgvProduksi.Columns[6].HeaderText = "Status Produksi";
                dgvProduksi.Columns[7].HeaderText = "Kualitas";
                dgvProduksi.Columns[8].HeaderText = "Harga (Rp)";
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }


        // Klik baris di DataGridView
        // Klik baris di DataGridView
        private void dgvProduksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProduksi.Rows[e.RowIndex];

                if (int.TryParse(Convert.ToString(row.Cells[0].Value), out int id))
                    selectedId = id;
                else
                    selectedId = -1;

                cmbldPanen.Text = Convert.ToString(row.Cells[1].Value);
                cmbJenisTembakau.Text = Convert.ToString(row.Cells[2].Value);
                cmbJenisProses.Text = Convert.ToString(row.Cells[3].Value);
                txtJumlahDiolah.Text = Convert.ToString(row.Cells[4].Value); // ✅ jumlah diolah
                txtHasil.Text = Convert.ToString(row.Cells[5].Value); // ✅ hasil produksi
                cmbStatus.Text = Convert.ToString(row.Cells[6].Value);
                cmbKualitas.Text = Convert.ToString(row.Cells[7].Value);
                txtHarga.Text = Convert.ToString(row.Cells[8].Value);

                Console.WriteLine("Selected ID: " + selectedId);
            }
        }


        // Simpan hasil produksi (update record yang sudah ada)
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Update hasil produksi + status + kualitas + proses + produk
                var cmd = new NpgsqlCommand(
    "UPDATE produksi SET nama_produk=@nama, jenis_proses=@proses, hasil_produksi=@hasil, status_produksi=@status, kualitas=@kualitas, harga=@harga " +
    "WHERE id_produksi=@id", conn);

                cmd.Parameters.AddWithValue("harga",
                    string.IsNullOrEmpty(txtHarga.Text) ? (object)DBNull.Value : decimal.Parse(txtHarga.Text));
                cmd.Parameters.AddWithValue("nama", cmbJenisTembakau.Text);   // produk akhir
                cmd.Parameters.AddWithValue("proses", cmbJenisProses.Text);   // proses produksi
                cmd.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                cmd.Parameters.AddWithValue("kualitas", cmbKualitas.Text);
                cmd.Parameters.AddWithValue("id", selectedId);

                cmd.ExecuteNonQuery();

                // Update stok produk sesuai hasil produksi
                if (!string.IsNullOrEmpty(txtHasil.Text))
                {
                    var cmdUpdateProduk = new NpgsqlCommand(
                        "UPDATE produk SET stok = stok + @hasil WHERE nama_produk = @nama", conn);

                    cmdUpdateProduk.Parameters.AddWithValue("hasil", decimal.Parse(txtHasil.Text));
                    cmdUpdateProduk.Parameters.AddWithValue("nama", cmbJenisTembakau.Text);

                    cmdUpdateProduk.ExecuteNonQuery();
                }

                MessageBox.Show("Hasil produksi berhasil disimpan dan stok produk diperbarui!");
                LoadDataProduksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        // Edit data produksi
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // 1. Ambil hasil_produksi lama dari DB
                decimal hasilLama = 0;
                var cmdGet = new NpgsqlCommand(
                    "SELECT hasil_produksi FROM produksi WHERE id_produksi=@id", conn);
                cmdGet.Parameters.AddWithValue("id", selectedId);
                var result = cmdGet.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                    hasilLama = Convert.ToDecimal(result);

                // 2. Update record produksi dengan nilai baru
                var cmdUpdate = new NpgsqlCommand(
    "UPDATE produksi SET nama_produk=@nama, jenis_proses=@proses, jumlah_diolah=@jumlah, " +
    "hasil_produksi=@hasil, status_produksi=@status, kualitas=@kualitas, harga=@harga " +
    "WHERE id_produksi=@id", conn);

                cmdUpdate.Parameters.AddWithValue("harga",
                    string.IsNullOrEmpty(txtHarga.Text) ? (object)DBNull.Value : decimal.Parse(txtHarga.Text));
                cmdUpdate.Parameters.AddWithValue("nama", cmbJenisTembakau.Text);
                cmdUpdate.Parameters.AddWithValue("proses", cmbJenisProses.Text);
                cmdUpdate.Parameters.AddWithValue("jumlah", int.Parse(txtJumlahDiolah.Text));
                cmdUpdate.Parameters.AddWithValue("hasil",
                    string.IsNullOrEmpty(txtHasil.Text) ? (object)DBNull.Value : decimal.Parse(txtHasil.Text));
                cmdUpdate.Parameters.AddWithValue("status", cmbStatus.Text);
                cmdUpdate.Parameters.AddWithValue("kualitas", cmbKualitas.Text);
                cmdUpdate.Parameters.AddWithValue("id", selectedId);

                cmdUpdate.ExecuteNonQuery();

                // 3. Sesuaikan stok produk (kurangi hasil lama, tambah hasil baru)
                if (!string.IsNullOrEmpty(txtHasil.Text))
                {
                    decimal hasilBaru = decimal.Parse(txtHasil.Text);

                    var cmdUpdateProduk = new NpgsqlCommand(
                        "UPDATE produk SET stok = stok - @lama + @baru WHERE nama_produk = @nama", conn);

                    cmdUpdateProduk.Parameters.AddWithValue("lama", hasilLama);
                    cmdUpdateProduk.Parameters.AddWithValue("baru", hasilBaru);
                    cmdUpdateProduk.Parameters.AddWithValue("nama", cmbJenisTembakau.Text);

                    cmdUpdateProduk.ExecuteNonQuery();
                }

                MessageBox.Show("Data produksi berhasil diupdate dan stok produk disesuaikan!");
                LoadDataProduksi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error edit: " + ex.Message);
            }
        }


        // Hapus data produksi
        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId < 0)
            {
                MessageBox.Show("Pilih data dulu!");
                return;
            }

            if (MessageBox.Show("Hapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    using var conn = DBConnection.GetConnection();
                    conn.Open();
                    var cmd = new NpgsqlCommand("DELETE FROM produksi WHERE id_produksi=@id", conn);
                    cmd.Parameters.AddWithValue("id", selectedId);
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Data produksi berhasil dihapus!");
                        LoadDataProduksi();
                        selectedId = -1;
                    }
                    else
                    {
                        MessageBox.Show("Data tidak ditemukan atau sudah terhapus.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error hapus: " + ex.Message);
                }
            }
        }

        // Refresh data
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDataProduksi();
            LoadPanenCombo();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler kosong sesuai Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbJenisProses_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Bisa dibiarkan kosong kalau tidak ada logika khusus
            // Atau isi dengan logika validasi sesuai kebutuhan
        }

        private void cmbJenisTembakau_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Event handler untuk combobox nama produk (Rajangan, Kretek, Cerutu)
            // Bisa ditambahkan logika validasi atau auto-fill sesuai kebutuhan
        }

        private void dgvProduksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtHasil_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
