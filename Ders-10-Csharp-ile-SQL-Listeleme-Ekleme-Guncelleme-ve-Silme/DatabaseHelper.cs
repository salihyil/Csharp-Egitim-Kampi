using System;
using System.Data.SqlClient;

namespace Ders_10_Csharp_ile_SQL_Listeleme_Ekleme_Guncelleme_ve_Silme
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "Data Source=SALIH;Initial Catalog=EgitimKampiDb;integrated security=true;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public static SqlCommand CreateCommand(string commandText, SqlConnection connection)
        {
            return new SqlCommand(commandText, connection);
        }
    }
}
