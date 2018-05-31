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
            DataBaseConection.connection.Close();
        }

        /// <summary>
        /// Abrir conexão da aplicação com o banco de dados V11
        /// </summary>
        /// <returns></returns>
        public void Open()
        {
            string server = DataBaseConection.server;
            string port = DataBaseConection.port;
            string databaseName = DataBaseConection.database;
            string user = DataBaseConection.user;
            string password = DataBaseConection.password;
            MySqlConnection connection = DataBaseConection.connection;

            DataBaseConection.connectionString = "SERVER=" + server + ";Port=" + port + ";DATABASE=" + databaseName + ";UID="
                + user + ";Pwd=" + password + "";

            if (server != "" && databaseName != "" && user != "" && password != "")
            {
                try
                {
                    DataBaseConection.connection = new MySqlConnection(DataBaseConection.connectionString);
                    DataBaseConection.connection.Open();
                }
                catch (MySqlException error)
                {
                    switch (error.Number)
                    {
                        case 0:
                            DataBaseConection.sqlerromsg = "Não foi possível conectar ao servidor";
                            throw new Exception(DataBaseConection.sqlerromsg);
                        case 1:
                            DataBaseConection.sqlerromsg = "Usuário ou senha inválidos";
                            throw new Exception(DataBaseConection.sqlerromsg);
                        case 1042:
                            DataBaseConection.sqlerromsg = "Não foi possível encontrar um host com essas especificações";
                            throw new Exception(DataBaseConection.sqlerromsg);
                    }
                }
                catch (Exception ex)
                {
                    DataBaseConection.sqlerromsg = "Servidor Offiline";
                    throw new Exception(DataBaseConection.sqlerromsg);
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
                MySqlDataAdapter sqlDtb = new MySqlDataAdapter(sSql, DataBaseConection.connection);
                sqlDtb.Fill(dtbResult);
                return dtbResult;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
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
        public void CarregaCmb(System.Windows.Forms.ComboBox cmb, string sSql)
        {
            try
            {
                MySqlCommand sQlCmd = new MySqlCommand(sSql); 
                DataTable dtbResult = new DataTable();
               // MySqlDataAdapter sqlDtb = new MySqlDataAdapter(sQlCmd);
                using (MySqlDataAdapter sqlDtb = new MySqlDataAdapter(sSql, DataBaseConection.connection))
                {
                    sqlDtb.Fill(dtbResult);
                }

                //sqlDtb.Fill(dtbResult);
                foreach(DataRow linha in dtbResult.Rows)
                {
                    cmb.Items.Add(linha.Field<int>(0));
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ConnectionState State()
        {
            return DataBaseConection.connection.State;
        }
    }
}
