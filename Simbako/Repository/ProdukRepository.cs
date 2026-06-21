using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class ProdukRepository
    {
        //  Ambil stok panen terverifikasi (group by kualitas + tanggal representatif)
        public List<Panen> GetPanenTerverifikasi()
        {
            var list = new List<Panen>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT kualitas,
                       SUM(jumlah_panen) AS total_panen,
                       MIN(tanggal_panen) AS tanggal_awal
                FROM panen
                WHERE status_verifikasi = 'Terverifikasi'
                GROUP BY kualitas
                ORDER BY kualitas", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Panen
                {
                    Kualitas = reader.GetString(0),
                    JumlahPanen = reader.GetDecimal(1),
                    TanggalPanen = reader.GetDateTime(2),
                    StatusVerifikasi = "Terverifikasi"
                });
            }
            return list;
        }

        //  Cari id_panen yang stoknya cukup
        public int? GetIdPanen(string kualitas, int jumlahOlah)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmdGetId = new NpgsqlCommand(@"
                SELECT id_panen
                FROM panen
                WHERE kualitas = @kualitas::kualitas_enum
                AND status_verifikasi = 'Terverifikasi'
                AND jumlah_panen >= @jumlah
                ORDER BY id_panen
                LIMIT 1", conn);

            cmdGetId.Parameters.AddWithValue("kualitas", kualitas);
            cmdGetId.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);

            var result = cmdGetId.ExecuteScalar();
            return result == null ? null : Convert.ToInt32(result);
        }

        //  Insert ke tabel produksi
        public void InsertProduksi(int idPanen, string namaProduk, int jumlahOlah,
                                   string statusProduksi, string kualitas, decimal hargaPerKg)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdInsert = new NpgsqlCommand(@"
                INSERT INTO produksi (id_panen, nama_produk, jumlah_diolah, status_produksi, kualitas, harga)
                VALUES (@id, @nama, @jumlah, @status, @kualitas::kualitas_enum, @harga)", conn);

            cmdInsert.Parameters.AddWithValue("id", idPanen);
            cmdInsert.Parameters.AddWithValue("nama", namaProduk);
            cmdInsert.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);
            cmdInsert.Parameters.AddWithValue("status", statusProduksi);
            cmdInsert.Parameters.AddWithValue("kualitas", kualitas); // harus persis sama enum (Busuk, Bagus, dll)
            cmdInsert.Parameters.AddWithValue("harga", hargaPerKg);
            cmdInsert.ExecuteNonQuery();

            // Update stok panen mentah
            var cmdUpdate = new NpgsqlCommand(@"
                UPDATE panen
                SET jumlah_panen = jumlah_panen - @jumlah
                WHERE id_panen = @id", conn);

            cmdUpdate.Parameters.AddWithValue("jumlah", (decimal)jumlahOlah);
            cmdUpdate.Parameters.AddWithValue("id", idPanen);
            cmdUpdate.ExecuteNonQuery();

            // Jika status Siap Jual → masuk ke tabel produk
            if (statusProduksi == "Siap Jual")
            {
                var cmdProduk = new NpgsqlCommand(@"
                    INSERT INTO produk (nama_produk, stok, harga, kualitas, status_verifikasi)
                    VALUES (@nama, @stok, @harga, @kual::kualitas_enum, 'Siap Jual')
                    ON CONFLICT (nama_produk, kualitas)
                    DO UPDATE SET stok = produk.stok + @stok, harga = @harga", conn);

                cmdProduk.Parameters.AddWithValue("nama", namaProduk);
                cmdProduk.Parameters.AddWithValue("stok", (decimal)jumlahOlah);
                cmdProduk.Parameters.AddWithValue("harga", hargaPerKg);
                cmdProduk.Parameters.AddWithValue("kual", kualitas);
                cmdProduk.ExecuteNonQuery();
            }
        }
    }
}

