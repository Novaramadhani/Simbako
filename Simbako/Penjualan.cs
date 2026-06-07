using System;

namespace Simbako
{
    public class Penjualan
    {
        public decimal Jumlah { get; set; }

        public decimal BuatTransaksi(decimal hargaSatuan, decimal jumlah)
        {
            Jumlah = jumlah;
            return hargaSatuan * jumlah;
        }

        public string CetakNota(string namaProduk, string namaCustomer, decimal total)
        {
            return
$@"=== NOTA SIMBAKO ===
Tanggal : {DateTime.Now:dd/MM/yyyy}
Pembeli : {namaCustomer}
Produk  : {namaProduk}
Jumlah  : {Jumlah} kg
Total   : Rp {total:N0}
====================";
        }
    }
}
