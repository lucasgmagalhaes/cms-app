using Class_Management_System.Entities;
using System.Collections.Generic;
using System.Data;

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
        /// Pesquisa perfis cadastrados no banco de dados
        /// </summary>
        /// <param name="filtro">Descrição do perfil que está buscando</param>
        /// <returns></returns>
        DataTable BuscaPerfil(string filtro);

        /// <summary>
        /// Cria um PerfilUsuario no banco
        /// </summary>
        /// <param name="perfil"></param>
        int CriarPerfil(PerfilUsuario perfil);


        /// <summary>
        ///  Altera um PerfilUsuario no banco
        /// </summary>
        /// <param name="perfil"></param>
        void GravaPerfil(PerfilUsuario perfil);

        /// <summary>
        /// Deleta um perfil
        /// </summary>
        /// <param name="perfil"></param>
        void DeletaPerfil(PerfilUsuario perfil);

        /// <summary>
        /// Busca o id de um perfil usuário pela descrição do mesmo
        /// retorna 0 caso nenhum registro seja encontrado
        /// </summary>
        /// <param name="descricao"></param>
        /// <returns></returns>
        int BuscarIdPerfilUsuarioPorDescicao(string descricao);

        /// <summary>
        /// Busca por usuários através de um filtro. Se o filtro for vazio ou nulo,
        /// é buscado todos os usuários cadastrados. se não, a busca é feita pelo nome,
        /// cpf, ou id do usuário.
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        List<Usuario> BuscarUsuarios(string filtro);

        /// <summary>
        /// Busca a lista de perfis de usuário
        /// </summary>
        /// <returns></returns>
        List<PerfilUsuario> BuscarPerfisUsuario(string filtro);

        /// <summary>
        /// Retorna se um cpf já está cadastrado
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        bool CpfCadastrado(string cpf);
    }
}
