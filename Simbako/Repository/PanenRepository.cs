using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class PanenRepository
    {
        //  Ambil semua data panen
        public List<Panen> GetAllPanen()
        {
            var list = new List<Panen>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            string query = @"SELECT p.id_panen, pt.nama_petani, p.tanggal_panen,
                                    p.jumlah_panen, p.kualitas, p.status_verifikasi
                             FROM public.panen p
                             JOIN public.petani pt ON p.id_petani = pt.id_petani
                             ORDER BY p.tanggal_panen DESC";
            var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Panen
                {
                    IdPanen = reader.GetInt32(0),
                    NamaPetani = reader.GetString(1), // ✅ ambil nama petani dari query
                    TanggalPanen = reader.GetDateTime(2),
                    JumlahPanen = reader.GetDecimal(3),
                    Kualitas = reader.GetString(4),
                    StatusVerifikasi = reader.GetString(5) // ✅ hanya status verifikasi
                });
            }
            return list;
        }

        //  Ambil atau buat petani
        public int GetOrCreatePetani(string namaPetani)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmdPetani = new NpgsqlCommand(
                "INSERT INTO public.petani (nama_petani) VALUES (@nama) ON CONFLICT DO NOTHING RETURNING id_petani", conn);
            cmdPetani.Parameters.AddWithValue("nama", namaPetani);
            var idPetaniObj = cmdPetani.ExecuteScalar();

            if (idPetaniObj == null)
            {
                var cmdGet = new NpgsqlCommand(
                    "SELECT id_petani FROM public.petani WHERE nama_petani=@nama LIMIT 1", conn);
                cmdGet.Parameters.AddWithValue("nama", namaPetani);
                idPetaniObj = cmdGet.ExecuteScalar();
            }
            return Convert.ToInt32(idPetaniObj);
        }

        //  Insert panen baru + otomatis masuk ke produk
        public void InsertPanen(int idPetani, DateTime tanggal, decimal jumlah, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmdPanen = new NpgsqlCommand(
                "INSERT INTO public.panen (id_petani, tanggal_panen, jumlah_panen, kualitas, status_verifikasi) " +
                "VALUES (@idp, @tgl, @jml, @kual::kualitas_enum, 'Menunggu') RETURNING id_panen", conn);
            cmdPanen.Parameters.AddWithValue("idp", idPetani);
            cmdPanen.Parameters.AddWithValue("tgl", tanggal.Date);
            cmdPanen.Parameters.AddWithValue("jml", jumlah);
            cmdPanen.Parameters.AddWithValue("kual", kualitas);
            int idPanen = Convert.ToInt32(cmdPanen.ExecuteScalar());

            var cmdProduk = new NpgsqlCommand(
                "INSERT INTO produk (nama_produk, stok, harga, kualitas, status_verifikasi) " +
                "VALUES ('Tembakau Mentah', @stok, 0, @kual::kualitas_enum, 'Menunggu') " +
                "ON CONFLICT (nama_produk, kualitas) DO UPDATE SET stok = produk.stok + @stok", conn);
            cmdProduk.Parameters.AddWithValue("stok", jumlah);
            cmdProduk.Parameters.AddWithValue("kual", kualitas);
            cmdProduk.ExecuteNonQuery();
        }

        //  Update panen
        public void UpdatePanen(int idPanen, DateTime tanggal, decimal jumlah, string kualitas)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "UPDATE public.panen SET tanggal_panen=@tgl, jumlah_panen=@jml, kualitas=@kual::kualitas_enum WHERE id_panen=@id", conn);
            cmd.Parameters.AddWithValue("tgl", tanggal.Date);
            cmd.Parameters.AddWithValue("jml", jumlah);
            cmd.Parameters.AddWithValue("kual", kualitas);
            cmd.Parameters.AddWithValue("id", idPanen);
            cmd.ExecuteNonQuery();
        }

        //  Hapus panen
        public void DeletePanen(int idPanen)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("DELETE FROM public.panen WHERE id_panen=@id", conn);
            cmd.Parameters.AddWithValue("id", idPanen);
            cmd.ExecuteNonQuery();
        }

        //  Verifikasi panen → otomatis update produk jadi siap jual
        public void VerifyPanen(int idPanen)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand(
                "UPDATE public.panen SET status_verifikasi='Terverifikasi' WHERE id_panen=@id", conn);
            cmd.Parameters.AddWithValue("id", idPanen);
            cmd.ExecuteNonQuery();

            var cmdGet = new NpgsqlCommand(
                "SELECT jumlah_panen, kualitas FROM public.panen WHERE id_panen=@id", conn);
            cmdGet.Parameters.AddWithValue("id", idPanen);
            using var reader = cmdGet.ExecuteReader();
            if (reader.Read())
            {
                decimal jumlah = reader.GetDecimal(0);
                string kualitas = reader.GetString(1);

                reader.Close();

                var cmdProduk = new NpgsqlCommand(
    "UPDATE produk SET status_verifikasi='Siap Jual' WHERE kualitas=@kual", conn);
                cmdProduk.Parameters.AddWithValue("kual", kualitas);
                cmdProduk.ExecuteNonQuery();

            }
        }
    }
}

