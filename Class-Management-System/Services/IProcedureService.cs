using Class_Management_System.Entities;

namespace Class_Management_System.Services
{
    public interface IProcedureService
    {
        /// <summary>
        /// Busca o código de um usuário pelo login e senha do mesmo
        /// procedure usada SPVERIFICA_LOGIN
        /// </summary>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <returns></returns>
        int BuscarCodigoUsuario(string login, string senha);

        /// <summary>
        /// Busca o código de um usuário pelo cpf
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        int BuscarCodigoUsuario(int cpf);

        /// <summary>
        /// Busca um usuário pelo id
        /// Procedure SPCONSULTA_USUARIO
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Usuario BuscarUsuario(int id);

        /// <summary>
        /// Remove um usuário do banco de dados.
        /// </summary>
        /// <param name="usuario"></param>
        void RemoverUsuario(Usuario usuario);

        /// <summary>
        /// Cria um novo registro de um usuário no banco de dados ou atualiza um existente.
        /// </summary>
        /// <param name="usuario"></param>
        void GravarOuAtualizarUsuario(Usuario usuario);

        /// <summary>
        /// Grava um PerfilUsuario no banco
        /// </summary>
        /// <param name="perfil"></param>
        void CriarPerfil(PerfilUsuario perfil);

        /// <summary>
        /// Busca o id de um perfil usuário pela descrição do mesmo
        /// retorna 0 caso nenhum registro seja encontrado
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        int BuscarIdPerfilUsuarioPorDescicao(string descricao);
    }
}
