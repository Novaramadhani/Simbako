using System;
using System.Collections.Generic;
using System.Text;

namespace Simbako
{
    public class Penjualan
    {
        public int IdPenjualan { get; set; }
        public int IdCustomer { get; set; }
        public int IdProduk { get; set; }
        public DateTime TanggalPenjualan { get; set; } = DateTime.Now;
        public decimal Jumlah { get; set; }
        public decimal TotalHarga { get; set; }

        public decimal BuatTransaksi(decimal hargaSatuan, decimal jumlah)
        {
            TotalHarga = hargaSatuan * jumlah;
            return TotalHarga;
        }

        public string CetakNota(string namaProduk, string namaCustomer)
        {
            return $"=== NOTA SIMBAKO ===\n" +
                   $"Tanggal  : {TanggalPenjualan:dd/MM/yyyy}\n" +
                   $"Pembeli  : {namaCustomer}\n" +
                   $"Produk   : {namaProduk}\n" +
                   $"Jumlah   : {Jumlah} kg\n" +
                   $"Total    : Rp {TotalHarga:N0}\n" +
                   $"====================";
        }
    }
}