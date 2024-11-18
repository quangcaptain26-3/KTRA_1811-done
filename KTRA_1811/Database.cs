using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTRA_1811
{
    internal class Database
    {
        private static string connectionString =
            @"Data Source=PHAMMINHQUANG;Initial Catalog=QuanLyChungChi;Integrated Security=True;TrustServerCertificate=True";

        private static SqlConnection connection;

        public static DataTable Query(string sql)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return dataTable;
        }
        public static void Execute(string sql, Dictionary<string, object> param = null)
        {
            Console.WriteLine(sql);
            connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            foreach(var item in param)
            {
                command.Parameters.AddWithValue(item.Key, item.Value);
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
       
    }
}
