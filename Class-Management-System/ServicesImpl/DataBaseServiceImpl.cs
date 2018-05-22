using Class_Management_System.Entities;
using Class_Management_System.Services;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Class_Management_System.ServicesImpl
{
    public class DataBaseServiceImpl : IDataBaseService
    {
        public void Close()
        {
            DataBaseConection.GetConnection().Close();
        }

        /// <summary>
        /// Abrir conexão da aplicação com o banco de dados V11
        /// </summary>
        /// <returns></returns>
        public void Open()
        {
            string server = DataBaseConection.GetServerName();
            string port = DataBaseConection.GetPort();
            string databaseName = DataBaseConection.GetDataBaseName();
            string user = DataBaseConection.GetUser();
            string password = DataBaseConection.GetPassword();
            MySqlConnection connection = DataBaseConection.GetConnection();

            string connectionString = "SERVER=" + server + ";Port=" + port + ";DATABASE=" + databaseName + ";UID="
                + user + ";Pwd=" + password + "";

            if (server != "" && databaseName != "" && user != "" && password != "")
            {
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                catch (MySqlException error)
                {
                    switch (error.Number)
                    {
                        case 0:
                            DataBaseConection.sqlerromsg = "Não foi possível conectar ao servidor";
                            break;
                        case 1:
                            DataBaseConection.sqlerromsg = "Usuário ou senha inválidos";
                            break;
                    }
                }
                catch (Exception)
                {
                    DataBaseConection.sqlerromsg = "Servidor Offiline";
                }
            }
        }

        public string GetErrorMessage()
        {
            return DataBaseConection.sqlerromsg;
        }

        public ConnectionState State()
        {
            return DataBaseConection.GetConnection().State;
        }
    }
}
