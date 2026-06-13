using System;

namespace Simbako.Model
{
    public class Penjualan
    {
        public int IdPenjualan { get; set; } = 0;
        public string NamaCustomer { get; set; } = string.Empty;
        public string NoHP { get; set; } = string.Empty;
        public string NamaProduk { get; set; } = string.Empty;
        public string Kualitas { get; set; } = string.Empty;
        public decimal Jumlah { get; set; } = 0;
        public decimal TotalHarga { get; set; } = 0;
        public DateTime TanggalPenjualan { get; set; } = DateTime.MinValue;

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
