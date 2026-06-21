using Simbako.Repository;
using System;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormDashboardAdmin : Form
    {
        private readonly DashboardAdminRepository repo;

        public FormDashboardAdmin()
        {
            InitializeComponent();
            repo = new DashboardAdminRepository();
        }

        //  Event handler Load yang benar
        private void FormDashboardAdmin_Load(object sender, EventArgs e)
        {
            // Bisa dikosongkan atau isi sesuai kebutuhan
            // Contoh: MessageBox.Show("Dashboard Admin siap digunakan!");
        }

        //  Event kosong biar Designer aman
        private void label1_Click(object sender, EventArgs e) { }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e) { }

        //  Menu navigasi panggil repository
        private void panenToolStripMenuItem_Click(object sender, EventArgs e) => repo.OpenPanen();
        private void produksiToolStripMenuItem_Click(object sender, EventArgs e) => repo.OpenProduksi();
        private void produkToolStripMenuItem_Click(object sender, EventArgs e) => repo.OpenProduk();
        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e) => repo.OpenPenjualan();
        private void laporanToolStripMenuItem_Click(object sender, EventArgs e) => repo.OpenLaporan();
        private void keluarToolStripMenuItem_Click(object sender, EventArgs e) => repo.Logout(this);

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
