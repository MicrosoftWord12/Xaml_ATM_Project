using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Xaml_ATM_Project.Database
{
    internal class DBConnection
    {
        public NpgsqlConnection Connection()
        {
            String connectionString = "Host=localhost;Username=postgres;Password=1832;Database=C#Projects";
            NpgsqlConnection conn = new NpgsqlConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
