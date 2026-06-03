using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simbako
{
    public partial class FormDashboardAdmin : Form
    {
        public FormDashboardAdmin()
        {
            InitializeComponent();
        }

        // Menu Panen
        private void panenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPanen formPanen = new FormPanen();
            formPanen.ShowDialog();
        }

        // Menu Produksi
        private void produksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduksi formProduksi = new FormProduksi();
            formProduksi.ShowDialog();
        }

        // Menu Produk
        private void produkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProduk formProduk = new FormProduk();
            formProduk.ShowDialog();
        }

        // Menu Penjualan
        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPenjualan formPenjualan = new FormPenjualan();
            formPenjualan.ShowDialog();
        }

        // Menu Laporan
        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLaporan formLaporan = new FormLaporan();
            formLaporan.ShowDialog();
        }

        // Menu Keluar
        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin keluar?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}

