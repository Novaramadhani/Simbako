using System;
using System.Collections.Generic;
using System.Text;

// File: Panen.cs
namespace Simbako
{
    public class Panen
    {
        public int IdPanen { get; set; }
        public int IdPetani { get; set; }
        public DateTime TanggalPanen { get; set; }
        public decimal JumlahPanen { get; set; }
        public string Kualitas { get; set; } = string.Empty;
        public string FileBukti { get; set; } = string.Empty;
        public string StatusVerifikasi { get; set; } = "Menunggu";

        public decimal HitungTotalPanen(List<Panen> daftarPanen)
        {
            decimal total = 0;
            foreach (var p in daftarPanen)
                total += p.JumlahPanen;
            return total;
        }
    }
}