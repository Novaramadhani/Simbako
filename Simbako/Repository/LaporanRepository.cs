using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class LaporanRepository
    {
        // ✅ Laporan Panen
        public List<LapPanen> GetLapPanen(DateTime dari, DateTime sampai)
        {
            var list = new List<LapPanen>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT p.nama_petani, COUNT(pa.id_panen) AS jumlah_kali,
                       SUM(pa.jumlah_panen) AS total_kg, pa.kualitas, pa.status_verifikasi
                FROM panen pa
                JOIN petani p ON pa.id_petani = p.id_petani
                WHERE pa.tanggal_panen BETWEEN @dari AND @sampai
                GROUP BY p.nama_petani, pa.kualitas, pa.status_verifikasi", conn);

            cmd.Parameters.AddWithValue("dari", dari);
            cmd.Parameters.AddWithValue("sampai", sampai);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LapPanen
                {
                    NamaPetani = reader.IsDBNull(0) ? string.Empty : reader.GetString(0),
                    JumlahKali = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    TotalKg = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Kualitas = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    StatusVerifikasi = reader.IsDBNull(4) ? string.Empty : reader.GetString(4)
                });
            }
            return list;
        }

        // ✅ Laporan Produksi
        public List<LapProduksi> GetLapProduksi(DateTime dari, DateTime sampai)
        {
            var list = new List<LapProduksi>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT id_produksi, jenis_proses, jumlah_diolah, hasil_produksi,
                       kualitas, status_produksi, tanggal_produksi
                FROM produksi
                WHERE tanggal_produksi BETWEEN @dari AND @sampai", conn);

            cmd.Parameters.AddWithValue("dari", dari);
            cmd.Parameters.AddWithValue("sampai", sampai);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LapProduksi
                {
                    IdProduksi = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    JenisProses = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    JumlahDiolah = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    HasilProduksi = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Kualitas = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    StatusProduksi = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                    TanggalProduksi = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6)
                });
            }
            return list;
        }

        // ✅ Laporan Penjualan
        public List<LapPenjualan> GetLapPenjualan(DateTime dari, DateTime sampai)
        {
            var list = new List<LapPenjualan>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT pe.tanggal, c.nama_customer, pr.nama_produk,
                       pe.kualitas, pe.jumlah, pe.total_harga
                FROM penjualan pe
                JOIN customer c ON pe.id_customer = c.id_customer
                JOIN produk pr ON pe.id_produk = pr.id_produk
                WHERE pe.tanggal BETWEEN @dari AND @sampai", conn);

            cmd.Parameters.AddWithValue("dari", dari);
            cmd.Parameters.AddWithValue("sampai", sampai);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LapPenjualan
                {
                    TanggalPenjualan = reader.IsDBNull(0) ? DateTime.MinValue : reader.GetDateTime(0),
                    NamaCustomer = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    NamaProduk = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                    Kualitas = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                    Jumlah = reader.IsDBNull(4) ? 0 : reader.GetDecimal(4),
                    TotalHarga = reader.IsDBNull(5) ? 0 : reader.GetDecimal(5)
                });
            }
            return list;
        }

        // ✅ Laporan Stok
        public List<LapStok> GetLapStok()
        {
            var list = new List<LapStok>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(@"
                SELECT id_produk, nama_produk, stok, harga, kualitas, status_verifikasi
                FROM produk", conn);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new LapStok
                {
                    IdProduk = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                    NamaProduk = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                    Stok = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2),
                    Harga = reader.IsDBNull(3) ? 0 : reader.GetDecimal(3),
                    Kualitas = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                    StatusVerifikasi = reader.IsDBNull(5) ? string.Empty : reader.GetString(5)
                });
            }
            return list;
        }
    }
}
