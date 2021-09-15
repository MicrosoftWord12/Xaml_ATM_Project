using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace Xaml_ATM_Project.Database
{
    internal class DBCommand
    {
        public static NpgsqlCommand Command(String SQL)
        {
            DBConnection conn = new DBConnection();
            NpgsqlCommand cmd = new NpgsqlCommand(SQL, conn.Connection());
            return cmd;
        }
    }
}
