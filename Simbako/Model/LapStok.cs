namespace Simbako.Model
{
    public class LapStok
    {
        public int IdProduk { get; set; } = 0;
        public string NamaProduk { get; set; } = string.Empty;
        public decimal Stok { get; set; } = 0;
        public decimal Harga { get; set; } = 0;
        public string Kualitas { get; set; } = string.Empty;
        public string StatusVerifikasi { get; set; } = string.Empty;
    }
}
