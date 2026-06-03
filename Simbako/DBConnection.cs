using Npgsql;

namespace Simbako
{
    public class DBConnection
    {
        // Ganti sesuai pengaturan PostgreSQL kamu
        private static string connString =
            "Host=localhost;Port=5432;Database=simbako;Username=postgres;Password=novania";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}