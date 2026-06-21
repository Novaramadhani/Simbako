using System;
using System.Collections.Generic;
using System.Text;

// File: Produk.cs
namespace Simbako.Model
{
    public class Produk
    {
        public int IdProduk { get; set; } = 0;
        public string NamaProduk { get; set; } = string.Empty;
        public decimal Harga { get; set; } = 0;
        public decimal Stok { get; set; } = 0;
        public string StatusVerifikasi { get; set; } = string.Empty;
        public string Kualitas { get; set; } = string.Empty;

        public void UpdateStok(decimal jumlah) => Stok -= jumlah;

        public decimal HitungHargaTotal(decimal jumlah) => Harga * jumlah;
    }
}
