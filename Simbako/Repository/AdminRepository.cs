using Simbako.Model;
using Simbako.DatabaseHellper;
using Npgsql;

namespace Simbako.Repository
{
        public class AdminRepository
        {
            //  Login admin
            public bool Login(string username, string password)
            {
                using var conn = DBConnection.GetConnection();
                conn.Open();
                var cmd = new NpgsqlCommand(
                    "SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p", conn);
                cmd.Parameters.AddWithValue("u", username);
                cmd.Parameters.AddWithValue("p", password);

                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }

        //  Ambil data admin (opsional)
        public Admin? GetAdmin(string username)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT username, password FROM admin WHERE username=@u", conn);
            cmd.Parameters.AddWithValue("u", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Admin
                {
                    Username = reader.GetString(0),
                    Password = reader.GetString(1)
                };
            }
            return null;
        }
    }
}
