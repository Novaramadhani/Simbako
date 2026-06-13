using System;
using System.Collections.Generic;

namespace Simbako.Model
{
    public class Panen
    {
        public int IdPanen { get; set; } = 0;
        public int IdPetani { get; set; }
        public string NamaPetani { get; set; } = string.Empty; // ✅ Tambah properti nama petani
        public DateTime TanggalPanen { get; set; }
        public decimal JumlahPanen { get; set; } = 0;
        public string Kualitas { get; set; } = string.Empty;
        public string StatusVerifikasi { get; set; } = string.Empty; // ✅ Pakai status verifikasi saja

        public decimal HitungTotalPanen(List<Panen> daftarPanen)
        {
            decimal total = 0;
            foreach (var p in daftarPanen)
                total += p.JumlahPanen;
            return total;
        }
    }
}
