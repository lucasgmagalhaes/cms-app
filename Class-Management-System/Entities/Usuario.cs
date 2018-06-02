using System;
using System.Data;
using System.Collections.Generic; 
using Class_Management_System.Services; 
using Class_Management_System.Utils;

namespace Class_Management_System.Entities
{
    /// <summary>
    /// Mapeado da tabela USUARIO
    /// </summary>
    public class Usuario : Pessoa
    {
        protected readonly IDataBaseService srvUsuario;
        /// <summary>
        /// COD_USUARIO
        /// </summary>
        private int pkUsuario;
        /// <summary>
        /// LOGIN
        /// </summary>
        private string sLogin;
        /// <summary>
        /// SENHA
        /// </summary>
        private string sSenha;
        /// <summary>
        /// COD_PERFIL_USUARIO
        /// </summary>
        private PerfilUsuario perfil;

        public string SSenha { get => sSenha; set => sSenha = value; }
        public string SLogin { get => sLogin; set => sLogin = value; }
        public int PkUsuario { get => pkUsuario; set => pkUsuario = value; }
        public PerfilUsuario Perfil { get => perfil; set => perfil = value; }

        public Usuario() : base()
        {
            this.PkUsuario = 0;
            this.SLogin = "";
            this.SSenha = "";
            this.SNome = "";
            this.SEmail = "";
            this.SCPF = "";
            this.PkPessoa = 0;
            this.srvUsuario = DependencyFactory.Resolve<IDataBaseService>();
        }

        public Usuario(int pkUsuario, PerfilUsuario iCodPerfil, string sLogin, string sSenha, string nom, string email, string cpf, int pkPess) : base(nom, email, cpf, pkPess)
        {
            this.perfil = iCodPerfil;
            this.PkUsuario = pkUsuario;
            this.SLogin = sLogin;
            this.SSenha = sSenha;
            this.SNome = nom;
            this.SEmail = email;
            this.SCPF = cpf;
            this.PkPessoa = pkPess;
            this.srvUsuario = DependencyFactory.Resolve<IDataBaseService>();
        }
        public Usuario(int pkUsuario, PerfilUsuario iCodPerfil, string sLogin, string sSenha, string nom, string email, string cpf) : base(nom, email, cpf)
        {
            this.perfil = iCodPerfil;
            this.PkUsuario = pkUsuario;
            this.SLogin = sLogin;
            this.SSenha = sSenha;
            this.SNome = nom;
            this.SEmail = email;
            this.SCPF = cpf;
            this.srvUsuario = DependencyFactory.Resolve<IDataBaseService>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Gravar()
        {
            try
            {
                if (this.PkUsuario == 0) //NOVO USUARIO
                { 
                    srvUsuario.ExecutaQuery("CALL SPCRIA_ACESSO ('" + this.SNome + "','"
                        + this.SCPF + "','" + this.SEmail + "','" + this.SLogin + "','" + this.SSenha +
                        "'," + this.perfil.GetCodigo() + ")");
                }
                else
                {
                    srvUsuario.ExecutaQuery("CALL " + DataBaseConection.database + ".SPGRAVA_DADOS_USUARIO ('" + this.SNome +
                        "','" + this.SCPF + "','" + this.SEmail + "','" + this.SLogin +
                        "', '" + this.SSenha + "'," + this.perfil.GetCodigo() + ", " + PkUsuario + ")");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// Metodo que busca os dados do Usuário no banco de Dados
        /// </summary>
        /// <param name="pk">Codigo do Usuário</param>
        public void GetDados(int pk)
        {
            try
            {
                DataTable dtbDados = new DataTable();
                dtbDados = srvUsuario.BuscaDados(" CALL SPCONSULTA_USUARIO ( pkUsuario = '" + pk + "' )");
                if (dtbDados.Rows.Count > 0)
                {
                    this.PkUsuario = dtbDados.Rows[0].Field<int>("ID");
                    this.PkPessoa = dtbDados.Rows[0].Field<int>("COD_PESSOA");
                    this.SLogin = dtbDados.Rows[0].Field<string>("LOGIN");
                    this.SSenha = dtbDados.Rows[0].Field<string>("SENHA");
                    this.SLogin = dtbDados.Rows[0].Field<string>("EMAIL");
                    this.SSenha = dtbDados.Rows[0].Field<string>("COD_CPF");
                    this.perfil.SetCodigo(dtbDados.Rows[0].Field<int>("COD_PERFIL_USUARIO"));
                    this.perfil.SetDescricao(dtbDados.Rows[0].Field<string>("PERFIL"));
                } 
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void GetDados()
        {
            try
            {
                DataTable dtbDados = new DataTable();
                dtbDados = srvUsuario.BuscaDados(" CALL SPCONSULTA_USUARIO ( pkUsuario = '" + this.PkUsuario + "' )");
                if (dtbDados.Rows.Count > 0)
                { 
                    this.PkPessoa = dtbDados.Rows[0].Field<int>("COD_PESSOA");
                    this.SLogin = dtbDados.Rows[0].Field<string>("LOGIN");
                    this.SSenha = dtbDados.Rows[0].Field<string>("SENHA");
                    this.SLogin = dtbDados.Rows[0].Field<string>("EMAIL");
                    this.SSenha = dtbDados.Rows[0].Field<string>("COD_CPF");
                    this.perfil.SetCodigo(dtbDados.Rows[0].Field<int>("COD_PERFIL_USUARIO"));
                    this.perfil.SetDescricao(dtbDados.Rows[0].Field<string>("PERFIL"));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Deleta()
        {
            try
            {
                this.srvUsuario.ExecutaQuery(" CALL SPDELETA_USUARIO (pkUsuario = " + this.PkUsuario + ")");
            }
            catch (System.Exception)
            {
                throw;
            }
        } 
        public override bool Equals(object obj)
        {
            var usuario = obj as Usuario;
            return usuario != null &&
                   this.perfil.GetCodigo() == usuario.perfil.GetCodigo() &&
                   this.PkUsuario == usuario.PkUsuario &&
                   this.SLogin == usuario.SLogin &&
                   this.SSenha == usuario.SSenha;
        }

        public override int GetHashCode()
        {
            var hashCode = -1541256906;
            hashCode = hashCode * -1521134295 + this.perfil.GetCodigo().GetHashCode();
            hashCode = hashCode * -1521134295 + this.PkUsuario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.SLogin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.SSenha);
            return hashCode;
        }
    }
}
