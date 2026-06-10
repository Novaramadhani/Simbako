using Npgsql;
using Simbako.Model;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class PanenRepository
    {
        public List<Panen> GetByPetani(int idPetani)
        {
            var list = new List<Panen>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_panen, tanggal_panen, jumlah_panen, kualitas, status_verifikasi FROM panen WHERE id_petani=@id", conn);
            cmd.Parameters.AddWithValue("id", idPetani);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Panen
                {
                    IdPanen = reader.GetInt32(0),
                    TanggalPanen = reader.GetDateTime(1),
                    JumlahPanen = reader.GetDecimal(2),
                    Kualitas = reader.GetString(3),
                    StatusVerifikasi = reader.GetString(4)
                });
            }
            return list;
        }
    }
}
