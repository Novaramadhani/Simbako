using System;
using System.Collections.Generic;
using System.Text;

namespace SIMBAKO
{
    public class Produk
    {
        public int IdProduk { get; set; }
        public string NamaProduk { get; set; }
        public decimal Stok { get; set; }
        public decimal Harga { get; set; }
        public string Kualitas { get; set; }

        public void UpdateStok(decimal jumlah)
        {
            Stok -= jumlah;
        }

        public decimal HitungHargaTotal(decimal jumlah)
        {
            return Harga * jumlah;
        }
    }
}
