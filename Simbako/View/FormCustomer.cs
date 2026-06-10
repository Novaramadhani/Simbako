using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormCustomer : Form
    {
        private readonly ProdukRepository produkRepo = new ProdukRepository();
        private readonly PenjualanRepository penjualanRepo = new PenjualanRepository();

        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadProdukTersedia();
            cmbKualitas.Items.Clear();
            cmbKualitas.Items.AddRange(new string[] { "Sangat Baik", "Bagus", "Kurang Baik", "Bosok" });
        }

        private void LoadProdukTersedia()
        {
            var dt = produkRepo.GetProdukSiapJual();
            dgvProduk.DataSource = dt;
            dgvProduk.Columns[0].HeaderText = "ID Produk";
            dgvProduk.Columns[1].HeaderText = "Nama Produk";
            dgvProduk.Columns[2].HeaderText = "Harga";
            dgvProduk.Columns[3].HeaderText = "Stok";
            dgvProduk.Columns[4].HeaderText = "Status";
            dgvProduk.Columns[5].HeaderText = "Kualitas";

            cmbNamaProduk.DataSource = dt;
            cmbNamaProduk.DisplayMember = "nama_produk";
            cmbNamaProduk.ValueMember = "id_produk";
            cmbNamaProduk.SelectedIndex = -1;
        }

        // Tombol Beli Produk
        private void btnBeli_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || string.IsNullOrWhiteSpace(txtNoHP.Text))
            {
                MessageBox.Show("Nama dan No HP wajib diisi!");
                return;
            }

            if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah belum diisi dengan benar!");
                return;
            }

            int idProduk = Convert.ToInt32(cmbNamaProduk.SelectedValue);
            var harga = produkRepo.GetHarga(idProduk, cmbKualitas.Text);
            if (harga == null)
            {
                MessageBox.Show("Harga produk tidak ditemukan!");
                return;
            }

            decimal total = harga.Value * jumlah;
            int idCust = penjualanRepo.GetOrCreateCustomer(txtNama.Text, txtNoHP.Text);

            penjualanRepo.InsertPenjualan(idCust, idProduk, jumlah, total, cmbKualitas.Text);
            produkRepo.KurangiStok(idProduk, cmbKualitas.Text, jumlah);

            lblHarga.Text = $"Harga : {harga.Value:N0}";
            lblTotal.Text = $"Total : {total:N0}";

            MessageBox.Show("Pembelian berhasil!");
            LoadProdukTersedia();
        }

        // Tombol Nota
        private void btnNota_Click_1(object sender, EventArgs e)
        {
            if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text))
            {
                MessageBox.Show("Pilih produk dan kualitas terlebih dahulu!");
                return;
            }

            var harga = produkRepo.GetHarga(Convert.ToInt32(cmbNamaProduk.SelectedValue), cmbKualitas.Text);
            if (harga == null)
            {
                MessageBox.Show("Harga tidak ditemukan!");
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Jumlah belum diisi dengan benar!");
                return;
            }

            decimal total = harga.Value * jumlah;

            MessageBox.Show(
                $"Nota:\n" +
                $"Nama: {txtNama.Text}\n" +
                $"No HP: {txtNoHP.Text}\n" +
                $"Produk: {cmbNamaProduk.Text}\n" +
                $"Kualitas: {cmbKualitas.Text}\n" +
                $"Jumlah: {jumlah} kg\n" +
                $"Harga: Rp {harga.Value:N0}\n" +
                $"Total: Rp {total:N0}",
                "Nota Pembelian",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // Tombol Refresh
        private void btnRefresh_Click(object sender, EventArgs e) => LoadProdukTersedia();

        // Tombol Keluar
        private void btnKeluar_Click_1(object sender, EventArgs e) => this.Close();

        // Event tambahan sinkron dengan Designer
        private void dgvProduk_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvProduk_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtNama_TextChanged(object sender, EventArgs e) { }
        private void txtNoHP_TextChanged(object sender, EventArgs e) { }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtJumlah.Text, out decimal jumlah) &&
                decimal.TryParse(lblHarga.Text.Replace("Harga : ", ""), out decimal harga))
            {
                lblTotal.Text = $"Total : {jumlah * harga:N0}";
            }
            else
            {
                lblTotal.Text = "Total : 0";
            }
        }

        private void cmbNamaProduk_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();
        private void cmbKualitas_SelectedIndexChanged(object sender, EventArgs e) => UpdateHarga();

        private void UpdateHarga()
        {
            if (cmbNamaProduk.SelectedValue == null || string.IsNullOrEmpty(cmbKualitas.Text)) return;

            var harga = produkRepo.GetHarga(Convert.ToInt32(cmbNamaProduk.SelectedValue), cmbKualitas.Text);
            if (harga != null)
            {
                lblHarga.Text = $"Harga : {harga.Value:N0}";
                lblTotal.Text = "Total : 0";
            }
            else
            {
                lblHarga.Text = "Harga : -";
                lblTotal.Text = "Total : 0";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void lblHarga_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
