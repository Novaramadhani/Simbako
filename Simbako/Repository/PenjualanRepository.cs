using Npgsql;

namespace Simbako.Repository
{
    public class PenjualanRepository
    {
        public int GetOrCreateCustomer(string nama, string noHp)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdCust = new NpgsqlCommand(
                "SELECT id_customer FROM customer WHERE nama_customer=@n AND no_hp=@hp", conn);
            cmdCust.Parameters.AddWithValue("n", nama);
            cmdCust.Parameters.AddWithValue("hp", noHp);
            var idCust = cmdCust.ExecuteScalar();

            if (idCust == null)
            {
                var cmdInsertCust = new NpgsqlCommand(
                    "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                cmdInsertCust.Parameters.AddWithValue("n", nama);
                cmdInsertCust.Parameters.AddWithValue("hp", noHp);
                idCust = cmdInsertCust.ExecuteScalar();
            }

            return Convert.ToInt32(idCust);
        }

        public void InsertPenjualan(int idCustomer, int idProduk, decimal jumlah, decimal total, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "INSERT INTO penjualan (id_customer, id_produk, tanggal_penjualan, jumlah, total_harga, kualitas) " +
                "VALUES (@c,@p,@t,@j,@th,@k)", conn);

            cmd.Parameters.AddWithValue("c", idCustomer);
            cmd.Parameters.AddWithValue("p", idProduk);
            cmd.Parameters.AddWithValue("t", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("j", jumlah);
            cmd.Parameters.AddWithValue("th", total);
            cmd.Parameters.AddWithValue("k", kualitas);
            cmd.ExecuteNonQuery();
        }
    }
}
