using Npgsql;

namespace SIMBAKO
{
    public class DBConnection
    {
        // Ganti sesuai pengaturan PostgreSQL kamu
        private static string connString =
            "Host=localhost;Port=5432;Database=simbako;Username=postgres;Password=12345";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}
