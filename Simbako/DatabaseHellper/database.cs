using System;
using System.Text;
using Npgsql;

namespace Simbako.DatabaseHellper
{
   public static class database
    {
        public static NpgsqlConnection GetConnection()
        {
            string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=novaria;Database=simbako";
            return new NpgsqlConnection(connectionString);
        }
    }
}
