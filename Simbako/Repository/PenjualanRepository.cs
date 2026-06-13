using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class PenjualanRepository
    {
        // ✅ Ambil daftar produk (nama saja untuk ComboBox)
        public List<string> GetProdukList()
        {
            var list = new List<string>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT DISTINCT nama_produk FROM produksi", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        // ✅ Ambil daftar kualitas (untuk ComboBox)
        public List<string> GetKualitasList()
        {
            var list = new List<string>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT DISTINCT kualitas::text FROM produksi", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        // ✅ Ambil harga produk sesuai nama + kualitas
        public decimal? GetHarga(string namaProduk, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
    "SELECT harga FROM produksi WHERE nama_produk=@n AND kualitas=@k::kualitas_enum", conn);

            cmd.Parameters.AddWithValue("n", namaProduk);
            cmd.Parameters.Add("k", NpgsqlTypes.NpgsqlDbType.Text).Value = kualitas; // kirim sebagai text
            var result = cmd.ExecuteScalar();
            return result == null ? null : Convert.ToDecimal(result);
        }

        // ✅ Ambil atau buat customer
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
                var cmdInsert = new NpgsqlCommand(
                    "INSERT INTO customer (nama_customer, no_hp) VALUES (@n,@hp) RETURNING id_customer", conn);
                cmdInsert.Parameters.AddWithValue("n", nama);
                cmdInsert.Parameters.AddWithValue("hp", noHp);
                idCust = cmdInsert.ExecuteScalar();
            }

            return Convert.ToInt32(idCust);
        }

        // ✅ Ambil id_produk
        public int? GetIdProduk(string namaProduk)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_produk FROM produk WHERE nama_produk=@p", conn);
            cmd.Parameters.AddWithValue("p", namaProduk);
            var result = cmd.ExecuteScalar();
            return result == null ? null : Convert.ToInt32(result);
        }

        // ✅ Insert penjualan baru
        public void InsertPenjualan(int idCustomer, int idProduk, string kualitas,
                                    decimal jumlah, decimal total, DateTime tanggal)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                INSERT INTO penjualan (id_customer, id_produk, kualitas, jumlah, total_harga, tanggal_penjualan)
                VALUES (@cust,@prod,@k,@j,@t,@tgl)", conn);

            cmd.Parameters.AddWithValue("cust", idCustomer);
            cmd.Parameters.AddWithValue("prod", idProduk);
            cmd.Parameters.Add("k", NpgsqlTypes.NpgsqlDbType.Text).Value = kualitas;
            cmd.Parameters.AddWithValue("j", jumlah);
            cmd.Parameters.AddWithValue("t", total);
            cmd.Parameters.AddWithValue("tgl", tanggal);
            cmd.ExecuteNonQuery();
        }

        // ✅ Update penjualan lama
        public void UpdatePenjualan(int idPenjualan, int idCustomer, int idProduk, string kualitas,
                                    decimal jumlah, decimal total, DateTime tanggal)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                UPDATE penjualan
                SET id_customer=@cust,
                    id_produk=@prod,
                    kualitas=@k,
                    jumlah=@j,
                    total_harga=@t,
                    tanggal_penjualan=@tgl
                WHERE id_penjualan=@id", conn);

            cmd.Parameters.AddWithValue("cust", idCustomer);
            cmd.Parameters.AddWithValue("prod", idProduk);
            cmd.Parameters.Add("k", NpgsqlTypes.NpgsqlDbType.Text).Value = kualitas;
            cmd.Parameters.AddWithValue("j", jumlah);
            cmd.Parameters.AddWithValue("t", total);
            cmd.Parameters.AddWithValue("tgl", tanggal);
            cmd.Parameters.AddWithValue("id", idPenjualan);
            cmd.ExecuteNonQuery();
        }

        // ✅ Hapus penjualan
        public void DeletePenjualan(int idPenjualan)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM penjualan WHERE id_penjualan=@id", conn);
            cmd.Parameters.AddWithValue("id", idPenjualan);
            cmd.ExecuteNonQuery();
        }

        // ✅ Ambil semua data penjualan
        public List<Penjualan> GetAllPenjualan()
        {
            var list = new List<Penjualan>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT p.id_penjualan, c.nama_customer, c.no_hp, pr.nama_produk,
                       p.kualitas::text, p.jumlah, p.total_harga, p.tanggal_penjualan
                FROM penjualan p
                JOIN customer c ON p.id_customer = c.id_customer
                JOIN produk pr ON p.id_produk = pr.id_produk
                ORDER BY p.id_penjualan DESC", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Penjualan
                {
                    IdPenjualan = reader.GetInt32(0),
                    NamaCustomer = reader.GetString(1),
                    NoHP = reader.GetString(2),
                    NamaProduk = reader.GetString(3),
                    Kualitas = reader.GetString(4),
                    Jumlah = reader.GetDecimal(5),
                    TotalHarga = reader.GetDecimal(6),
                    TanggalPenjualan = reader.GetDateTime(7)
                });
            }
            return list;
        }
    }
}
