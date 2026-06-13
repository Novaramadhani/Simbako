using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Data;

namespace Simbako.Repository
{
    public class PetaniRepository
    {
        // ✅ Load semua riwayat panen
        public DataTable GetRiwayatPanen()
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            string query = @"
                SELECT p.id_panen, pt.nama_petani, p.tanggal_panen,
                       p.jumlah_panen, p.kualitas, p.status_verifikasi
                FROM panen p
                JOIN petani pt ON p.id_petani = pt.id_petani
                ORDER BY p.tanggal_panen DESC
                LIMIT 50";
            var cmd = new NpgsqlCommand(query, conn);
            var adapter = new NpgsqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // ✅ Simpan petani baru atau ambil id kalau sudah ada
        public int GetOrCreatePetani(string namaPetani)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdPetani = new NpgsqlCommand(
                "INSERT INTO petani (nama_petani) VALUES (@n) ON CONFLICT DO NOTHING RETURNING id_petani",
                conn);
            cmdPetani.Parameters.AddWithValue("n", namaPetani);
            var idObj = cmdPetani.ExecuteScalar();

            if (idObj == null)
            {
                var cmdGet = new NpgsqlCommand(
                    "SELECT id_petani FROM petani WHERE nama_petani=@n LIMIT 1", conn);
                cmdGet.Parameters.AddWithValue("n", namaPetani);
                idObj = cmdGet.ExecuteScalar();
            }

            return Convert.ToInt32(idObj);
        }

        // ✅ Simpan data panen (kualitas cast ke enum)
        public void InsertPanen(int idPetani, DateTime tanggal, decimal jumlah, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdPanen = new NpgsqlCommand(@"
                INSERT INTO panen (id_petani, tanggal_panen, jumlah_panen, kualitas)
                VALUES (@idp, @tgl, @jml, @kual::kualitas_enum)", conn);

            cmdPanen.Parameters.AddWithValue("idp", idPetani);
            cmdPanen.Parameters.AddWithValue("tgl", tanggal.Date);
            cmdPanen.Parameters.AddWithValue("jml", jumlah);
            cmdPanen.Parameters.AddWithValue("kual", kualitas); // harus persis sama dengan enum (Busuk, Bagus, dll)
            cmdPanen.ExecuteNonQuery();
        }
    }
}
