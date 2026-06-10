using Npgsql;
using Simbako.Model;
using System.Collections.Generic;



namespace Simbako.Repository
{
    public class CustomerRepository
    {
        public List<Customer> GetAll()
        {
            var list = new List<Customer>();
            using var conn = DBConnection.GetConnection();
            conn.Open();
            var cmd = new NpgsqlCommand("SELECT id_customer, nama_customer, no_hp FROM customer", conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Customer
                {
                    IdCustomer = reader.GetInt32(0),
                    NamaCustomer = reader.GetString(1),
                    NoHP = reader.GetString(2)
                });
            }
            return list;
        }
    }
}
