using Npgsql;
using Simbako.Model;
using System.Collections.Generic;

namespace Simbako.Repository
{
    public class PetaniRepository
    {
        public List<Petani> GetAll()
        {
            var list = new List<Petani>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_petani, nama_petani, alamat, no_hp FROM petani", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Petani
                {
                    IdPetani = reader.GetInt32(0),
                    NamaPetani = reader.GetString(1),
                    Alamat = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    NoHP = reader.IsDBNull(3) ? "" : reader.GetString(3)
                });
            }
            return list;
        }
    }
}