using Npgsql;
using Simbako.Model;

namespace Simbako.Repository
{
    public class AdminRepository
    {
        public bool Login(string username, string password)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p", conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);
            return (long)cmd.ExecuteScalar() > 0;
        }
    }
}
