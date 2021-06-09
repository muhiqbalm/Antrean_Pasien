using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AntreanPasien
{
    public class Akses
    {
        private static DataModel dbo;
        private static SqlConnection dbCehatSqlConnection;
        private static string path = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

        public static DataModel Tabel()
        {
            if (dbo == null)
            {
                dbo = new DataModel();
            }
            return dbo;
        }

        public static SqlConnection GetSqlConnection()
        {
            if (dbCehatSqlConnection == null)
            {
                dbCehatSqlConnection = new SqlConnection(path);
            }

            return dbCehatSqlConnection;
        }

        public static SqlConnection GetSqlConnection(string connString)
        {
            if (dbCehatSqlConnection == null)
            {
                dbCehatSqlConnection = new SqlConnection(connString);
            }

            return dbCehatSqlConnection;
        }
    }
}
