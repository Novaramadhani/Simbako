using System;
using System.Collections.Generic;
using System.Text;

// File: Produksi.cs
namespace SIMBAKO
{
    public class Produksi
    {
        public int IdProduksi { get; set; }
        public int IdPanen { get; set; }
        public string JenisProses { get; set; } = string.Empty;
        public string StatusProduksi { get; set; } = "Proses";
        public decimal HasilProduksi { get; set; }

        public void OlahTembakau(string proses)
        {
            JenisProses = proses;
            StatusProduksi = "Proses";
        }
    }
}