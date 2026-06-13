using Simbako.DatabaseHellper;
using Npgsql;

namespace Simbako.Repository
{
    public class Form1Repository
    {
        // Cek login admin
        public bool Login(string username, string password)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand(
                "SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p", conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);

            var resultObj = cmd.ExecuteScalar();
            int result = resultObj == null ? 0 : Convert.ToInt32(resultObj);
            return result > 0;
        }
    }
}
