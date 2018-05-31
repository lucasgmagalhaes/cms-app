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
                foreach (DataRow dr in dtbDados.Rows)
                {
                    //dr[X] X = NUMERO DA COLUNA NA CONSULTA
                    this.SNome = dr[3].ToString();
                    this.PkUsuario = (int)dr[0];
                    //this.ICodPerfil = (int)dr[7];
                    this.SLogin = dr[1].ToString();
                    this.SSenha = dr[8].ToString();
                    this.SEmail = dr[5].ToString();
                    this.SCPF = dr[4].ToString();
                    this.PkPessoa = (int)dr[6];
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
                foreach (DataRow dr in dtbDados.Rows)
                {
                    //dr[X] X = NUMERO DA COLUNA NA CONSULTA
                    this.SNome = dr[3].ToString();
                    this.PkUsuario = (int)dr[0];
                    //this.ICodPerfil = (int)dr[7];
                    this.SLogin = dr[1].ToString();
                    this.SSenha = dr[8].ToString();
                    this.SEmail = dr[5].ToString();
                    this.SCPF = dr[4].ToString();
                    this.PkPessoa = (int)dr[6];
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
