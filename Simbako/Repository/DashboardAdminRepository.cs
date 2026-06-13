using System;
using System.Windows.Forms;

namespace Simbako.Repository
{
    public class DashboardAdminRepository
    {
        // ✅ Buka form panen
        public void OpenPanen()
        {
            var form = new FormPanen();
            form.ShowDialog();
        }

        // ✅ Buka form produksi
        public void OpenProduksi()
        {
            var form = new FormProduksi();
            form.ShowDialog();
        }

        // ✅ Buka form produk
        public void OpenProduk()
        {
            var form = new FormProduk();
            form.ShowDialog();
        }

        // ✅ Buka form penjualan
        public void OpenPenjualan()
        {
            var form = new FormPenjualan();
            form.ShowDialog();
        }

        // ✅ Buka form laporan
        public void OpenLaporan()
        {
            var form = new FormLaporan();
            form.ShowDialog();
        }

        // ✅ Logout → tutup dashboard
        public void Logout(FormDashboardAdmin dashboard)
        {
            var confirm = MessageBox.Show("Apakah kamu yakin ingin keluar?",
                                          "Konfirmasi Logout",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                dashboard.Close();
            }
        }
    }
}
