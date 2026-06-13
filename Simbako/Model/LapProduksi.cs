namespace Simbako.Model
{
    public class LapProduksi
    {
        public int IdProduksi { get; set; } = 0;
        public string JenisProses { get; set; } = string.Empty;
        public decimal JumlahDiolah { get; set; } = 0;
        public decimal HasilProduksi { get; set; } = 0;
        public string Kualitas { get; set; } = string.Empty;
        public string StatusProduksi { get; set; } = string.Empty;
        public DateTime TanggalProduksi { get; set; } = DateTime.MinValue;
    }
}
