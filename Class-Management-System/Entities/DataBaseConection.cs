using MySql.Data.MySqlClient;

namespace Class_Management_System.Entities
{
    /// <summary>
    /// Classe estática para armazenamento dos elementos para conexão com banco MySql
    /// </summary>
    public static class DataBaseConection
    {
        private static MySqlConnection _connection;
        private static string _server;
        private static string _port;
        private static string _database;
        private static string _user;
        private static string _password;
        private static string _connectionString;
        private static string _sqlErrorMsg;

        public static MySqlConnection connection { get => _connection; set => _connection = value; }
        public static string server { get => _server; set => _server = value; }
        public static string port { get => _port; set => _port = value; }
        public static string database { get => _database; set => _database = value; }
        public static string user { get => _user; set => _user = value; }
        public static string password { get => _password; set => _password = value; }
        public static string connectionString { get => _connectionString; set => _connectionString = value; }
        public static string sqlerromsg { get => _sqlErrorMsg; set => _sqlErrorMsg = value; }

    }
}
