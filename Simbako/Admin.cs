using System;
using System.Collections.Generic;
using System.Text;

namespace SIMBAKO
{
    public class Admin : User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string GetRole()
        {
            return "Admin";
        }

        public bool Login(string username, string password)
        {
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new Npgsql.NpgsqlCommand(
                "SELECT COUNT(*) FROM admin WHERE username=@u AND password=@p", conn);
            cmd.Parameters.AddWithValue("u", username);
            cmd.Parameters.AddWithValue("p", password);
            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }
    }
}