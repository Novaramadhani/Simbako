using Npgsql;

namespace SIMBAKO
{
    public class DBConnection
    {
        private static string connString =
            "Server=localhost;Port=5432;Database=simbako;User Id=postgres;Password=novania";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connString);
        }
    }
}