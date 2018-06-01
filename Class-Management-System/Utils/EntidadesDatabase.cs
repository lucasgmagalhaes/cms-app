using Class_Management_System.Entities;
using System.Data;

namespace Class_Management_System.Utils
{
    /// <summary>
    /// Classe utilitária par instâncializar objetos
    /// </summary>
    public static class EntidadesDatabase
    {
        /// <summary>
        /// Cria um objeto do tipo Usuario para um DataTable
        /// Procedure: SPVERIFICA_LOGIN
        /// </summary>
        /// <param name="resultado_sql"></param>
        /// <returns></returns>
        public static Usuario InstancializarUsuarioPorLogin(int pk)
        {
            Usuario usuario = new Usuario();
            usuario.GetDados(pk);
            return usuario;
        }
    }
}
