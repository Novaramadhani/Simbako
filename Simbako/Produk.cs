using System;
using System.Collections.Generic;
using System.Text;

// File: Produk.cs
namespace SIMBAKO
{
    public class Produk
    {
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; } = string.Empty;
        public decimal Stok { get; set; }
        public decimal Harga { get; set; }
        public string Kualitas { get; set; } = string.Empty;

        public void UpdateStok(decimal jumlah) => Stok -= jumlah;

        public decimal HitungHargaTotal(decimal jumlah) => Harga * jumlah;
    }
}