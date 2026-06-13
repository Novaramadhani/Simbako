using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class ProduksiRepository
    {
        // ✅ Ambil panen terverifikasi untuk combo
        public List<Panen> GetPanenTerverifikasi()
        {
            var list = new List<Panen>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT id_panen, kualitas, jumlah_panen
                FROM panen
                WHERE status_verifikasi = 'Terverifikasi'", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Panen
                {
                    IdPanen = reader.GetInt32(0),
                    Kualitas = reader.GetString(1),
                    JumlahPanen = reader.GetDecimal(2),
                    StatusVerifikasi = "Terverifikasi"
                });
            }
            return list;
        }

        // ✅ Ambil semua data produksi
        public List<Produksi> GetAllProduksi()
        {
            var list = new List<Produksi>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT id_produksi, id_panen, nama_produk, jenis_proses,
                       jumlah_diolah, hasil_produksi, status_produksi,
                       kualitas, harga
                FROM produksi
                ORDER BY id_produksi DESC", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Produksi
                {
                    IdProduksi = reader.GetInt32(0),
                    IdPanen = reader.GetInt32(1),
                    NamaProduk = reader.GetString(2),
                    JenisProses = reader.GetString(3),
                    JumlahDiolah = reader.GetDecimal(4),
                    HasilProduksi = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5),
                    StatusProduksi = reader.GetString(6),
                    Kualitas = reader.GetString(7),
                    Harga = reader.IsDBNull(8) ? 0 : reader.GetDecimal(8)
                });
            }
            return list;
        }

        // ✅ Insert produksi baru
        public void InsertProduksi(int idPanen, string namaProduk, string jenisProses,
                                   int jumlahDiolah, decimal? hasilProduksi,
                                   string statusProduksi, string kualitas, decimal? hargaPerKg)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdInsert = new NpgsqlCommand(@"
                INSERT INTO produksi (id_panen, nama_produk, jenis_proses, jumlah_diolah,
                                      hasil_produksi, status_produksi, kualitas, harga)
                VALUES (@idp, @nama, @proses, @jumlah, @hasil, @status, @kualitas::kualitas_enum, @harga)", conn);

            cmdInsert.Parameters.AddWithValue("idp", idPanen);
            cmdInsert.Parameters.AddWithValue("nama", namaProduk);
            cmdInsert.Parameters.AddWithValue("proses", jenisProses);
            cmdInsert.Parameters.AddWithValue("jumlah", (decimal)jumlahDiolah);
            cmdInsert.Parameters.AddWithValue("hasil", (object?)hasilProduksi ?? DBNull.Value);
            cmdInsert.Parameters.AddWithValue("status", statusProduksi);
            cmdInsert.Parameters.AddWithValue("kualitas", kualitas); // harus persis sama enum (Busuk, Bagus, dll)
            cmdInsert.Parameters.AddWithValue("harga", (object?)hargaPerKg ?? DBNull.Value);

            cmdInsert.ExecuteNonQuery();
        }

        // ✅ Update produksi
        public void UpdateProduksi(int idProduksi, string namaProduk, string jenisProses,
                                   decimal? hasilProduksi, string statusProduksi,
                                   string kualitas, decimal? hargaPerKg)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdUpdate = new NpgsqlCommand(@"
                UPDATE produksi
                SET nama_produk=@nama,
                    jenis_proses=@proses,
                    hasil_produksi=@hasil,
                    status_produksi=@status,
                    kualitas=@kualitas::kualitas_enum,
                    harga=@harga
                WHERE id_produksi=@id", conn);

            cmdUpdate.Parameters.AddWithValue("id", idProduksi);
            cmdUpdate.Parameters.AddWithValue("nama", namaProduk);
            cmdUpdate.Parameters.AddWithValue("proses", jenisProses);
            cmdUpdate.Parameters.AddWithValue("hasil", (object?)hasilProduksi ?? DBNull.Value);
            cmdUpdate.Parameters.AddWithValue("status", statusProduksi);
            cmdUpdate.Parameters.AddWithValue("kualitas", kualitas);
            cmdUpdate.Parameters.AddWithValue("harga", (object?)hargaPerKg ?? DBNull.Value);

            cmdUpdate.ExecuteNonQuery();
        }

        // ✅ Update stok produk setelah hasil produksi masuk
        public void UpdateStokProduk(string namaProduk, string kualitas, decimal hasilProduksi, decimal? hargaPerKg = null)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                INSERT INTO produk (nama_produk, stok, harga, kualitas, status_verifikasi)
                VALUES (@nama, @stok, @harga, @kual::kualitas_enum, 'Siap Jual')
                ON CONFLICT (nama_produk, kualitas)
                DO UPDATE SET stok = produk.stok + @stok, harga = @harga", conn);

            cmd.Parameters.AddWithValue("nama", namaProduk);
            cmd.Parameters.AddWithValue("stok", hasilProduksi);
            cmd.Parameters.AddWithValue("harga", (object?)hargaPerKg ?? 0);
            cmd.Parameters.AddWithValue("kual", kualitas);
            cmd.ExecuteNonQuery();
        }

        // ✅ Ambil hasil produksi lama
        public decimal GetHasilProduksiLama(int idProduksi)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT hasil_produksi
                FROM produksi
                WHERE id_produksi=@id", conn);

            cmd.Parameters.AddWithValue("id", idProduksi);
            var result = cmd.ExecuteScalar();
            return result == null ? 0 : Convert.ToDecimal(result);
        }

        // ✅ Edit produksi (update + sesuaikan stok)
        public void EditProduksi(int idProduksi, string namaProduk, string jenisProses,
                                 int jumlahDiolah, decimal? hasilBaru,
                                 string status, string kualitas, decimal? harga,
                                 decimal hasilLama)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand(@"
                UPDATE produksi
                SET nama_produk=@nama, jenis_proses=@proses, jumlah_diolah=@jumlah,
                    hasil_produksi=@hasil, status_produksi=@status,
                    kualitas=@kualitas::kualitas_enum, harga=@harga
                WHERE id_produksi=@id", conn);

            cmd.Parameters.AddWithValue("id", idProduksi);
            cmd.Parameters.AddWithValue("nama", namaProduk);
            cmd.Parameters.AddWithValue("proses", jenisProses);
            cmd.Parameters.AddWithValue("jumlah", jumlahDiolah);
            cmd.Parameters.AddWithValue("hasil", (object?)hasilBaru ?? DBNull.Value);
            cmd.Parameters.AddWithValue("status", status);
            cmd.Parameters.AddWithValue("kualitas", kualitas);
            cmd.Parameters.AddWithValue("harga", (object?)harga ?? DBNull.Value);

            cmd.ExecuteNonQuery();

            // Sesuaikan stok produk
            if (hasilBaru.HasValue)
            {
                decimal selisih = hasilBaru.Value - hasilLama;
                var cmdStok = new NpgsqlCommand(@"
                    INSERT INTO produk (nama_produk, stok, harga, kualitas, status_verifikasi)
                    VALUES (@nama, @stok, @harga, @kual::kualitas_enum, 'Siap Jual')
                    ON CONFLICT (nama_produk, kualitas)
                    DO UPDATE SET stok = produk.stok + @stok, harga = @harga", conn);

                cmdStok.Parameters.AddWithValue("nama", namaProduk);
                cmdStok.Parameters.AddWithValue("stok", selisih);
                cmdStok.Parameters.AddWithValue("harga", (object?)harga ?? 0);
                cmdStok.Parameters.AddWithValue("kual", kualitas);
                cmdStok.ExecuteNonQuery();
            }
        }

        // ✅ Hapus produksi
        public bool DeleteProduksi(int idProduksi)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                DELETE FROM produksi WHERE id_produksi=@id", conn);

            cmd.Parameters.AddWithValue("id", idProduksi);
            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
