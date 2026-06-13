namespace Simbako.Model
{
    public class LapPenjualan
    {
        public DateTime TanggalPenjualan { get; set; } = DateTime.MinValue;
        public string NamaCustomer { get; set; } = string.Empty;
        public string NamaProduk { get; set; } = string.Empty;
        public string Kualitas { get; set; } = string.Empty;
        public decimal Jumlah { get; set; } = 0;
        public decimal TotalHarga { get; set; } = 0;
    }
}
