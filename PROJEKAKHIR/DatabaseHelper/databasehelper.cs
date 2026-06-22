using Npgsql;

namespace BibitKu.Helpers
{
    public class DatabaseHelper
    {
        private static readonly string connectionString =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=projekakhirpbo;" +
            "Username=postgres;" +
            "Password=rakha123;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }
    }
}
