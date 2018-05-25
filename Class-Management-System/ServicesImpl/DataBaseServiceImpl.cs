using Class_Management_System.Entities;
using Class_Management_System.Services;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Class_Management_System.ServicesImpl
{
    /// <summary>
    /// Classe implementadora do serviço de banco de dados
    /// </summary>
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
        /// <summary>
        /// Busca dados pela consulta feita
        /// </summary>
        /// <param name="sSql"> Query a ser executada</param>
        /// <returns>Retorna DataTable com o resultado</returns>
        public DataTable BuscaDados(string sSql)
        {
            try
            {
                MySqlCommand sQlCmd = new MySqlCommand(sSql); 
                DataTable dtbResult = new DataTable();
                MySqlDataAdapter sqlDtb = new MySqlDataAdapter(sQlCmd);
                sqlDtb.Fill(dtbResult);
                return dtbResult;
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// Execura Query que alteram, apagam ou inserem dados no BD
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns>Retorna quantidade de linhas afetadas</returns>
        public int ExecutaQuery(string sSql)
        {
            try
            {
                MySqlCommand sQlCmd = new MySqlCommand(sSql);
                return sQlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string GetErrorMessage()
        {
            return DataBaseConection.sqlerromsg;
        }
        public void CarregaCmb(System.Windows.Forms.ComboBox cmb,string sSql)
        {
            try
            {
                MySqlCommand sQlCmd = new MySqlCommand(sSql);
                DataTable dtbResult = new DataTable();
                MySqlDataAdapter sqlDtb = new MySqlDataAdapter(sQlCmd);
                sqlDtb.Fill(dtbResult);
                cmb.DataSource = dtbResult;
            }
            catch (Exception)
            {

                throw;
            } 
        }
        public ConnectionState State()
        {
            return DataBaseConection.GetConnection().State;
        }
    }
}
