using Npgsql;
using System.Data;

namespace Simbako.Repository
{
    public class ProdukRepository
    {
        public DataTable GetProdukSiapJual()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pr.id_produk, pr.nama_produk, pd.harga, pr.stok, pr.status_verifikasi, pr.kualitas " +
                "FROM produk pr " +
                "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                "WHERE pr.status_verifikasi = 'Siap Jual'", conn);

            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public decimal? GetHarga(int idProduk, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT pd.harga FROM produk pr " +
                "JOIN produksi pd ON pr.nama_produk = pd.nama_produk AND pr.kualitas = pd.kualitas " +
                "WHERE pr.id_produk=@id AND pr.kualitas=@kual", conn);

            cmd.Parameters.AddWithValue("id", idProduk);
            cmd.Parameters.AddWithValue("kual", kualitas);

            var result = cmd.ExecuteScalar();
            return result == null ? null : (decimal?)Convert.ToDecimal(result);
        }

        public void KurangiStok(int idProduk, string kualitas, decimal jumlah)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "UPDATE produk SET stok = stok - @j WHERE id_produk = @id AND kualitas=@kual", conn);
            cmd.Parameters.AddWithValue("j", jumlah);
            cmd.Parameters.AddWithValue("id", idProduk);
            cmd.Parameters.AddWithValue("kual", kualitas);
            cmd.ExecuteNonQuery();
        }
    }
}
