namespace Class_Management_System.Entities
{
    /// <summary>
    /// Classe mapeada de PERFIL_USUARIO
    /// </summary>
    public class PerfilUsuario
    {
        /// <summary>
        /// COD_PERFIL_USUARIO
        /// </summary>
        private int codigo;
        /// <summary>
        /// DSC_PERFIL_USUARIO
        /// </summary>
        private string descricao;

        //Usado para um novo perfil
        public PerfilUsuario(string descricao)
        {
            this.descricao = descricao;
        }

        //Usado para um perfil existente
        public PerfilUsuario(int codigo, string descricao)
        {
            this.codigo = codigo;
            this.descricao = descricao;
        }

        public string GetDescricao()
        {
            return this.descricao;
        }

        public void SetDescricao(string descricao)
        {
            this.descricao = descricao;
        }

        public int GetCodigo()
        {
            return this.codigo;
        }
    }
}
