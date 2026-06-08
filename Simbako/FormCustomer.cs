using Npgsql;
using Simbako;
using System;
using System.Data;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadProdukTersedia();  // isi DataGridView + ComboBox
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] {
                "Sangat Baik", "Bagus", "Kurang Baik", "Bosok"
            });
        }

        // Load daftar produk siap jual ke DataGridView + ComboBox
        private void LoadProdukTersedia()
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Urutan kolom: ID Produk, Nama Produk, Harga, Stok, Status, Kualitas
                var cmd = new NpgsqlCommand(
                    "SELECT pr.id_produk, pr.nama_produk, pd.harga, pr.stok, pr.status_verifikasi, pr.kualitas " +
                    "FROM produk pr " +
                    "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                    "WHERE pr.status_verifikasi = 'Siap Jual'", conn);

                var adapter = new NpgsqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                // isi DataGridView
                dgvProduk.DataSource = dt;
                dgvProduk.Columns[0].HeaderText = "ID Produk";
                dgvProduk.Columns[1].HeaderText = "Nama Produk";
                dgvProduk.Columns[2].HeaderText = "Harga";
                dgvProduk.Columns[3].HeaderText = "Stok";
                dgvProduk.Columns[4].HeaderText = "Status";
                dgvProduk.Columns[5].HeaderText = "Kualitas";

                // isi ComboBox dengan DataTable yang sama
                cmbNamaProduk.DataSource = dt;
                cmbNamaProduk.DisplayMember = "nama_produk";
                cmbNamaProduk.ValueMember = "id_produk";
                cmbNamaProduk.SelectedIndex = -1; // biar kosong dulu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load produk: " + ex.Message);
            }
        }

        // Tombol Beli Produk
        private void btnBeli_Click_1(object sender, EventArgs e)
        {
            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // ✅ Validasi input customer
                if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
                {
                    MessageBox.Show("Nama dan No HP wajib diisi!");
                    return;
                }

                // ✅ Validasi produk & kualitas
                if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text))
                {
                    MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                    return;
                }

                int idProduk = Convert.ToInt32(cmbNamaProduk.SelectedValue);

                // ✅ Ambil harga & stok dari join produk + produksi
                var cmdInfo = new NpgsqlCommand(
                    "SELECT pd.harga, pr.stok " +
                    "FROM produk pr " +
                    "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                    "WHERE pr.id_produk=@id AND pr.kualitas=@kual", conn);

                cmdInfo.Parameters.AddWithValue("id", idProduk);
                cmdInfo.Parameters.AddWithValue("kual", cmbKualitas.Text);

                using var reader = cmdInfo.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("Produk dengan kualitas ini tidak ditemukan!");
                    return;
                }

                decimal harga = reader.GetDecimal(0);
                int stok = reader.GetInt32(1);
                reader.Close();

                // ✅ Hitung total
                if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
                {
                    MessageBox.Show("Jumlah belum diisi dengan benar!");
                    return;
                }

                if (jumlah > stok)
                {
                    MessageBox.Show("Stok tidak mencukupi!");
                    return;
                }

                decimal total = harga * jumlah;

                // ✅ Cari customer berdasarkan input
                var cmdCust = new NpgsqlCommand(
                    "SELECT id_customer FROM customer WHERE nama_customer=@n AND no_hp=@hp", conn);
                cmdCust.Parameters.AddWithValue("n", txtNama.Text);
                cmdCust.Parameters.AddWithValue("hp", txtNoHP.Text);
                var idCust = cmdCust.ExecuteScalar();

                if (idCust == null)
                {
                    // kalau belum ada, insert otomatis
                    var cmdInsertCust = new NpgsqlCommand(
                        "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                    cmdInsertCust.Parameters.AddWithValue("n", txtNama.Text);
                    cmdInsertCust.Parameters.AddWithValue("hp", txtNoHP.Text);
                    idCust = cmdInsertCust.ExecuteScalar();
                }

                if (idCust == null)
                {
                    MessageBox.Show("Gagal mendapatkan ID Customer!");
                    return;
                }

                // ✅ Insert penjualan pakai idCust hasil query/insert
                var cmd = new NpgsqlCommand(
                    "INSERT INTO penjualan (id_customer, id_produk, tanggal_penjualan, jumlah, total_harga, kualitas) " +
                    "VALUES (@c,@p,@t,@j,@th,@k)", conn);

                cmd.Parameters.AddWithValue("c", (int)idCust); // pakai idCust, bukan 1
                cmd.Parameters.AddWithValue("p", idProduk);
                cmd.Parameters.AddWithValue("t", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("j", jumlah);
                cmd.Parameters.AddWithValue("th", total);
                cmd.Parameters.AddWithValue("k", cmbKualitas.Text);
                cmd.ExecuteNonQuery();

                // ✅ Kurangi stok produk
                var cmdUpdateStok = new NpgsqlCommand(
                    "UPDATE produk SET stok = stok - @j WHERE id_produk = @id AND kualitas=@kual", conn);
                cmdUpdateStok.Parameters.AddWithValue("j", jumlah);
                cmdUpdateStok.Parameters.AddWithValue("id", idProduk);
                cmdUpdateStok.Parameters.AddWithValue("kual", cmbKualitas.Text);
                cmdUpdateStok.ExecuteNonQuery();

                // ✅ Update label
                lblHarga.Text = "Harga : " + harga.ToString("N0");
                lblTotal.Text = "Total : " + total.ToString("N0");

                MessageBox.Show("Pembelian berhasil!");
                LoadProdukTersedia(); // refresh daftar produk + ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error beli produk: " + ex.Message);
            }
        }


        // Tombol Nota
        private void btnNota_Click_1(object sender, EventArgs e)
        {
            if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                return;
            }

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Ambil harga dari join produksi
                var cmd = new NpgsqlCommand(
                    "SELECT pd.harga " +
                    "FROM produk pr " +
                    "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                    "WHERE pr.id_produk=@id AND pr.kualitas=@kual", conn);

                cmd.Parameters.AddWithValue("id", Convert.ToInt32(cmbNamaProduk.SelectedValue));
                cmd.Parameters.AddWithValue("kual", cmbKualitas.Text);

                var result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Harga tidak ditemukan untuk produk ini!");
                    return;
                }

                decimal harga = Convert.ToDecimal(result);

                if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
                {
                    MessageBox.Show("Jumlah belum diisi dengan benar!");
                    return;
                }

                decimal total = harga * jumlah;

                // Tampilkan nota
                MessageBox.Show(
                    $"Nota:\n" +
                    $"Nama: {txtNama.Text}\n" +
                    $"No HP: {txtNoHP.Text}\n" +
                    $"Produk: {cmbNamaProduk.Text}\n" +
                    $"Kualitas: {cmbKualitas.Text}\n" +
                    $"Jumlah: {jumlah} kg\n" +
                    $"Harga: Rp {harga:N0}\n" +
                    $"Total: Rp {total:N0}",
                    "Nota Pembelian",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error buat nota: " + ex.Message);
            }
        }

        // Tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e) => LoadProdukTersedia();

        // Tombol Keluar
        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler kosong agar Designer tidak error
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }

        // Hitung total otomatis saat jumlah berubah
        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtJumlah.Text, out decimal jumlah) &&
                decimal.TryParse(lblHarga.Text.Replace("Harga : ", ""), out decimal harga))
            {
                decimal total = jumlah * harga;
                lblTotal.Text = $"Total : {total:N0}";
            }
            else
            {
                lblTotal.Text = "Total : 0";
            }
        }

        // Event ComboBox: update harga saat produk + kualitas dipilih
        private void cmbNamaProduk_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHarga();
        }

        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHarga();
        }

        private void UpdateHarga()
        {
            if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text))
                return;

            try
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();

                // Ambil harga dari join produksi sesuai produk + kualitas
                var cmd = new NpgsqlCommand(
                    "SELECT pd.harga " +
                    "FROM produk pr " +
                    "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                    "WHERE pr.id_produk=@id AND pr.kualitas=@kual", conn);

                cmd.Parameters.AddWithValue("id", Convert.ToInt32(cmbNamaProduk.SelectedValue));
                cmd.Parameters.AddWithValue("kual", cmbKualitas.Text);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    decimal harga = Convert.ToDecimal(result);
                    lblHarga.Text = $"Harga : {harga:N0}";
                    lblTotal.Text = "Total : 0";
                }
                else
                {
                    lblHarga.Text = "Harga : -";
                    lblTotal.Text = "Total : 0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ambil harga: " + ex.Message);
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblHarga_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
