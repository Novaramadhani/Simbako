using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class CustomerRepository
    {
        // Ambil produk siap jual
        public List<Produk> GetProdukSiapJual()
        {
            var list = new List<Produk>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT id_produk, nama_produk, stok, harga, kualitas, status_verifikasi
                FROM produk
                WHERE status_verifikasi = 'Siap Jual'", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Produk
                {
                    IdProduk = reader.GetInt32(0),
                    NamaProduk = reader.GetString(1),
                    Stok = reader.GetDecimal(2),
                    Harga = reader.GetDecimal(3),
                    Kualitas = reader.GetString(4),
                    StatusVerifikasi = reader.GetString(5)
                });
            }
            return list;
        }

        //  Ambil harga & stok produk berdasarkan nama_produk + kualitas (baru, untuk opsi B)
        public (decimal harga, int stok)? GetHargaStokByNama(string namaProduk, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
        SELECT harga, stok
        FROM produk
        WHERE nama_produk ILIKE @n AND kualitas ILIKE @k", conn);

            cmd.Parameters.AddWithValue("n", namaProduk);
            cmd.Parameters.AddWithValue("k", kualitas);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (reader.GetDecimal(0), reader.GetInt32(1));
            }
            return null;
        }

        // Buat customer baru kalau belum ada
        public int GetOrCreateCustomer(string nama, string noHP)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdCheck = new NpgsqlCommand(@"
                SELECT id_customer FROM customer WHERE nama_customer=@n AND no_hp=@hp", conn);
            cmdCheck.Parameters.AddWithValue("n", nama);
            cmdCheck.Parameters.AddWithValue("hp", noHP);

            var result = cmdCheck.ExecuteScalar();
            if (result != null)
                return (int)result;

            var cmdInsert = new NpgsqlCommand(@"
                INSERT INTO customer (nama_customer, no_hp)
                VALUES (@n, @hp) RETURNING id_customer", conn);
            cmdInsert.Parameters.AddWithValue("n", nama);
            cmdInsert.Parameters.AddWithValue("hp", noHP);

            return Convert.ToInt32(cmdInsert.ExecuteScalar());
        }

        // Insert penjualan + update stok
        public void InsertPenjualan(int idCustomer, int idProduk, decimal jumlah, decimal total, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            // Insert transaksi penjualan
            var cmd = new NpgsqlCommand(@"
                INSERT INTO penjualan (id_customer, id_produk, jumlah, total_harga, kualitas, tanggal)
                VALUES (@c, @p, @j, @t, @k, CURRENT_TIMESTAMP)", conn);

            cmd.Parameters.AddWithValue("c", idCustomer);
            cmd.Parameters.AddWithValue("p", idProduk);
            cmd.Parameters.AddWithValue("j", jumlah);
            cmd.Parameters.AddWithValue("t", total);
            cmd.Parameters.AddWithValue("k", kualitas);
            cmd.ExecuteNonQuery();

            // Update stok produk sesuai kualitas
            var cmdUpdate = new NpgsqlCommand(@"
                UPDATE produk
                SET stok = stok - @j
                WHERE id_produk=@p AND kualitas=@k", conn);

            cmdUpdate.Parameters.AddWithValue("j", jumlah);
            cmdUpdate.Parameters.AddWithValue("p", idProduk);
            cmdUpdate.Parameters.AddWithValue("k", kualitas);
            cmdUpdate.ExecuteNonQuery();
        }
    }
}
