using System.Data;

namespace Class_Management_System.Services
{
    /// <summary>
    /// Serviço para gerenciar conexão com o banco
    /// </summary>
    public interface IDataBaseService
    {
        /// <summary>
        /// Cria uma conexão com o banco de dados MySql
        /// </summary>
        void Open();

        /// <summary>
        /// Encerra a conexão com o banco de dados MySql
        /// </summary>
        void Close();

        /// <summary>
        /// Informa a mensagem do erro do banco, caso exista
        /// </summary>
        /// <returns></returns>
        string GetErrorMessage();

        /// <summary>
        /// Informa o estado da conexão com o banco
        /// </summary>
        /// <returns></returns>
        ConnectionState State();

        /// <summary>
        /// Busca dados pela consulta feita
        /// </summary>
        /// <param name="sSql"> Query a ser executada</param>
        /// <returns>Retorna DataTable com o resultado</returns>
        DataTable BuscaDados(string sSql);

        /// <summary>
        /// Execura Query que alteram, apagam ou inserem dados no BD
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns>Retorna quantidade de linhas afetadas</returns>
        int ExecutaQuery(string sSql);

        void CarregaCmb(System.Windows.Forms.ComboBox cmb, string sSql);
    }
}
