using Npgsql;
using Simbako.Model;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class ProduksiRepository
    {
        public List<Produksi> GetAll()
        {
            var list = new List<Produksi>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_produksi, id_panen, jenis_proses, jumlah_diolah, hasil_produksi, kualitas, status_produksi, tanggal_produksi FROM produksi", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Produksi
                {
                    IdProduksi = reader.GetInt32(0),
                    IdPanen = reader.GetInt32(1),
                    JenisProses = reader.GetString(2),
                    JumlahDiolah = reader.GetDecimal(3),
                    HasilProduksi = reader.GetDecimal(4),
                    Kualitas = reader.GetString(5),
                    StatusProduksi = reader.GetString(6),
                    TanggalProduksi = reader.GetDateTime(7)
                });
            }
            return list;
        }
    }
}
