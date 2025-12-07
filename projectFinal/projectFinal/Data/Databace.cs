using System.Data.SqlClient;

namespace projectFinal.Data
{
    public static class Database
    {
        private static string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=LavanderiaDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
