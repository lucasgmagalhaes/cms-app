using MySql.Data.MySqlClient;

namespace Class_Management_System.Entities
{
    /// <summary>
    /// Classe estática para armazenamento dos elementos para conexão com banco MySql
    /// </summary>
    public static class DataBaseConection
    {
        private static MySqlConnection connection;
        private static string serverN;
        private static string port;
        private static string databaseN;
        private static string uidN;
        private static string pwdN;
        private static string connectionString;
        public static string sqlerromsg = null;

        public static MySqlConnection GetConnection()
        {
            return connection;
        }

        /// <summary>
        /// Nome do Servidor Pad = "Servidor"
        /// </summary>
        /// <param name="name"></param>
        public static void ServerName(string name)
        {
            serverN = name;
        }

        public static string GetServerName()
        {
            return serverN;
        }

        /// <summary>
        /// Porta usada Pad = "3306"
        /// </summary>
        /// <param name="porta"></param>
        public static void Port(string porta)
        {
            port = porta;
        }

        public static string GetPort()
        {
            return port;
        }

        /// <summary>
        /// Nome do banco de dados Pad="V11_Mafra"
        /// </summary>
        /// <param name="name"></param>
        public static void DataBaseName(string name)
        {
            databaseN = name;
        }

        public static string GetDataBaseName()
        {
            return databaseN;
        }

        /// <summary>
        /// Usuário para realizar o login Pad="root"
        /// </summary>
        /// <param name="user"></param>
        public static void User(string user)
        {
            uidN = user;
        }

        public static string GetUser()
        {
            return uidN;
        }

        /// <summary>
        /// Senha para realizar o login="mafra1045@"
        /// </summary>
        /// <param name="pass"></param>
        public static void Password(string pass)
        {
            pwdN = pass;
        }

        public static string GetPassword()
        {
            return pwdN;
        }
    }
}
