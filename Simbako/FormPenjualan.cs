using Npgsql;
using Simbako;
using System;
using System.Data;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormPenjualan : Form
    {
        private int? selectedId = null; // ID penjualan yang dipilih
        private decimal hargaSatuan = 0;

        public FormPenjualan()
        {
            InitializeComponent();
        }

        private void FormPenjualan_Load(object sender, EventArgs e)
        {
            LoadProdukCombo();
            LoadKualitasCombo();
            LoadData();
        }

        private void LoadProdukCombo()
        {
            cmbProduk.Items.Clear();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT DISTINCT nama_produk FROM produksi", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbProduk.Items.Add(reader.GetString(0));
            }
        }

        private void LoadKualitasCombo()
        {
            cmbKualitas.Items.Clear();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT DISTINCT kualitas FROM produksi", conn);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cmbKualitas.Items.Add(reader.GetString(0));
            }
        }
        private void dgvPenjualan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPenjualan.Rows[e.RowIndex].Cells[0].Value != null)
            {
                var row = dgvPenjualan.Rows[e.RowIndex];

                // ID Penjualan
                selectedId = Convert.ToInt32(row.Cells["id_penjualan"].Value);

                // Customer
                txtNamaCustomer.Text = row.Cells["nama_customer"].Value?.ToString() ?? "";
                txtNoHP.Text = row.Cells["no_hp"].Value?.ToString() ?? "";

                // Produk & Kualitas
                cmbProduk.Text = row.Cells["nama_produk"].Value?.ToString() ?? "";
                cmbKualitas.Text = row.Cells["kualitas"].Value?.ToString() ?? "";

                // Jumlah & Total
                txtJumlah.Text = row.Cells["jumlah"].Value?.ToString() ?? "";
                txtTotal.Text = row.Cells["total_harga"].Value?.ToString() ?? "";

                // Tanggal (handle DateOnly atau DateTime)
                var valTanggal = row.Cells["tanggal_penjualan"].Value;
                if (valTanggal is DateOnly d)
                {
                    dateTimePicker1.Value = d.ToDateTime(TimeOnly.MinValue);
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Parse(valTanggal.ToString());
                }

                // Hitung ulang harga & total
                UpdateHarga();
            }
        }

        private void cmbProduk_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();

        private void UpdateHarga()
        {
            if (string.IsNullOrEmpty(cmbProduk.Text) || string.IsNullOrEmpty(cmbKualitas.Text))
                return;

            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT harga FROM produksi WHERE nama_produk=@n AND kualitas=@k", conn);
            cmd.Parameters.AddWithValue("n", cmbProduk.Text);
            cmd.Parameters.AddWithValue("k", cmbKualitas.Text);

            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                hargaSatuan = Convert.ToDecimal(result);

                if (decimal.TryParse(txtJumlah.Text, out decimal jml))
                {
                    decimal total = hargaSatuan * jml;
                    txtTotal.Text = $"Total: Rp {total:N0}";
                }
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Validasi input dulu
                if (string.IsNullOrWhiteSpace(txtNamaCustomer.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
                {
                    MessageBox.Show("Nama dan No HP wajib diisi!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbProduk.Text))
                {
                    MessageBox.Show("Produk wajib dipilih!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(cmbKualitas.Text))
                {
                    MessageBox.Show("Kualitas wajib dipilih!");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtJumlah.Text))
                {
                    MessageBox.Show("Jumlah wajib diisi!");
                    return;
                }

                using var conn = DBConnection.GetConnection();
                conn.Open();

                // ✅ Cek apakah customer sudah ada
                var cmdCust = new NpgsqlCommand(
                    "SELECT id_customer FROM customer WHERE nama_customer=@n AND no_hp=@hp", conn);
                cmdCust.Parameters.AddWithValue("n", txtNamaCustomer.Text);
                cmdCust.Parameters.AddWithValue("hp", txtNoHP.Text);
                var idCust = cmdCust.ExecuteScalar();

                if (idCust == null)
                {
                    // kalau belum ada, insert otomatis
                    var cmdInsertCust = new NpgsqlCommand(
                        "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                    cmdInsertCust.Parameters.AddWithValue("n", txtNamaCustomer.Text);
                    cmdInsertCust.Parameters.AddWithValue("hp", txtNoHP.Text);
                    idCust = cmdInsertCust.ExecuteScalar();
                }

                if (idCust == null)
                {
                    MessageBox.Show("Gagal mendapatkan ID Customer!");
                    return;
                }

                // ✅ Ambil id_produk sesuai pilihan produk
                var cmdProduk = new NpgsqlCommand(
                    "SELECT id_produk FROM produk WHERE nama_produk=@p", conn);
                cmdProduk.Parameters.AddWithValue("p", cmbProduk.Text);
                var idProduk = cmdProduk.ExecuteScalar();

                if (idProduk == null)
                {
                    MessageBox.Show("Produk tidak ditemukan!");
                    return;
                }

                // ✅ Hitung total harga
                if (!decimal.TryParse(txtJumlah.Text, out decimal jml))
                {
                    MessageBox.Show("Jumlah harus berupa angka!");
                    return;
                }
                decimal total = hargaSatuan * jml;

                if (selectedId == null)
                {
                    // ➕ INSERT transaksi baru
                    var cmdInsertPenjualan = new NpgsqlCommand(
                        "INSERT INTO penjualan (id_customer, id_produk, kualitas, jumlah, total_harga, tanggal_penjualan) " +
                        "VALUES (@cust, @prod, @k, @j, @t, @tgl)", conn);
                    cmdInsertPenjualan.Parameters.AddWithValue("cust", idCust);
                    cmdInsertPenjualan.Parameters.AddWithValue("prod", idProduk);
                    cmdInsertPenjualan.Parameters.AddWithValue("k", cmbKualitas.Text);
                    cmdInsertPenjualan.Parameters.AddWithValue("j", jml);
                    cmdInsertPenjualan.Parameters.AddWithValue("t", total);
                    cmdInsertPenjualan.Parameters.AddWithValue("tgl", dateTimePicker1.Value);
                    cmdInsertPenjualan.ExecuteNonQuery();

                    MessageBox.Show("Transaksi baru berhasil disimpan!");
                }
                else
                {
                    // ✏️ UPDATE transaksi lama
                    var cmdUpdate = new NpgsqlCommand(
                        "UPDATE penjualan SET id_customer=@cust, id_produk=@prod, kualitas=@k, jumlah=@j, total_harga=@t, tanggal_penjualan=@tgl " +
                        "WHERE id_penjualan=@id", conn);
                    cmdUpdate.Parameters.AddWithValue("cust", idCust);
                    cmdUpdate.Parameters.AddWithValue("prod", idProduk);
                    cmdUpdate.Parameters.AddWithValue("k", cmbKualitas.Text);
                    cmdUpdate.Parameters.AddWithValue("j", jml);
                    cmdUpdate.Parameters.AddWithValue("t", total);
                    cmdUpdate.Parameters.AddWithValue("tgl", dateTimePicker1.Value);
                    cmdUpdate.Parameters.AddWithValue("id", selectedId);
                    cmdUpdate.ExecuteNonQuery();

                    MessageBox.Show("Transaksi berhasil diperbarui!");
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error simpan transaksi: " + ex.Message);
            }
        }



        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (selectedId == null)
            {
                MessageBox.Show("Pilih transaksi dulu dari tabel!");
                return;
            }

            var confirm = MessageBox.Show(
                "Apakah kamu yakin ingin menghapus transaksi ini?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using var conn = DBConnection.GetConnection();
                    conn.Open();

                    var cmd = new NpgsqlCommand(
                        "DELETE FROM penjualan WHERE id_penjualan=@id", conn);
                    cmd.Parameters.AddWithValue("id", selectedId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Transaksi berhasil dihapus!");
                    LoadData();
                    selectedId = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error hapus transaksi: " + ex.Message);
                }
            }
        }

        private void LoadData()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT p.id_penjualan, c.nama_customer, c.no_hp, pr.nama_produk, p.kualitas, p.jumlah, p.total_harga, p.tanggal_penjualan " +
                    "FROM penjualan p " +
                    "JOIN customer c ON p.id_customer = c.id_customer " +
                    "JOIN produk pr ON p.id_produk = pr.id_produk " +
                    "ORDER BY p.id_penjualan DESC", conn);

                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);
                dgvPenjualan.DataSource = dt;

                dgvPenjualan.Columns[0].HeaderText = "ID Penjualan";
                dgvPenjualan.Columns[1].HeaderText = "Nama Customer";
                dgvPenjualan.Columns[2].HeaderText = "No HP";
                dgvPenjualan.Columns[3].HeaderText = "Produk";
                dgvPenjualan.Columns[4].HeaderText = "Kualitas";
                dgvPenjualan.Columns[5].HeaderText = "Jumlah (kg)";
                dgvPenjualan.Columns[6].HeaderText = "Total Harga";
                dgvPenjualan.Columns[7].HeaderText = "Tanggal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data penjualan: " + ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
        private void btnKeluar_Click(object sender, EventArgs e) => this.Close();

        // 🔧 Event handler kosong biar Designer tidak error
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void lblTotal_Click(object sender, EventArgs e) { }
        private void txtJumlah_TextChanged(object sender, EventArgs e) { }
        private void txtNamaCustomer_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }
        private void dgvPenjualan_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void txtTotal_TextChanged(object sender, EventArgs e) { }

        private void dgvPenjualan_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPenjualan.Rows[e.RowIndex];

                selectedId = Convert.ToInt32(row.Cells["id_penjualan"].Value);
                txtNamaCustomer.Text = row.Cells["nama_customer"].Value?.ToString() ?? "";
                txtNoHP.Text = row.Cells["no_hp"].Value?.ToString() ?? "";
                cmbProduk.Text = row.Cells["nama_produk"].Value?.ToString() ?? "";
                cmbKualitas.Text = row.Cells["kualitas"].Value?.ToString() ?? "";
                txtJumlah.Text = row.Cells["jumlah"].Value?.ToString() ?? "";
                txtTotal.Text = row.Cells["total_harga"].Value?.ToString() ?? "";
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["tanggal_penjualan"].Value);

                UpdateHarga();
            }
        }

    }
}
