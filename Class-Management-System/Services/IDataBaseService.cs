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
    }
}
