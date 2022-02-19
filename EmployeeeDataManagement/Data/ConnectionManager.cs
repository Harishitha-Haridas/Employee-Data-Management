using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace EmployeeeDataManagement.Data
{
    internal class ConnectionManager
    {
        static string _connectionString = @"Data Source=LAPTOP-89EK6LNU\SQLEXPRESS;Initial Catalog=keltron_c;Integrated Security=True";
        public static readonly SqlConnection Connection;

        static ConnectionManager()
        {
            Connection = new SqlConnection(_connectionString);
        }

        public static void EnsureConnectionIsActive()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
                Connection.Open();
        }
    }
}
