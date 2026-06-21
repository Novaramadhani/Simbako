using System;
using System.Collections.Generic;
using System.Text;

// File: Produksi.cs
namespace Simbako.Model
{
    public class Produksi
    {
        public int IdProduksi { get; set; } = 0;
        public int IdPanen { get; set; } = 0;
        public string NamaProduk { get; set; } = string.Empty;
        public string JenisProses { get; set; } = string.Empty;
        public decimal JumlahDiolah { get; set; } = 0;
        public decimal HasilProduksi { get; set; } = 0;
        public string StatusProduksi { get; set; } = string.Empty;
        public string Kualitas { get; set; } = string.Empty;
        public decimal Harga { get; set; } = 0;
        public void OlahTembakau(string proses)
        {
            JenisProses = proses;
            StatusProduksi = "Proses";
        }
    }
}
