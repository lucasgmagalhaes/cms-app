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
        protected readonly IProcedureService procedureService;
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
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
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
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
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
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Gravar()
        {
            this.procedureService.GravarOuAtualizarUsuario(this);
        }
        /// <summary>
        /// Metodo que busca os dados do Usuário no banco de Dados
        /// </summary>
        /// <param name="pk">Codigo do Usuário</param>
        public void GetDados(int pk)
        {
            Usuario infos = this.procedureService.BuscarUsuario(pk);
            this.Perfil = infos.Perfil;
            this.PkPessoa = infos.PkPessoa;
            this.pkUsuario = infos.pkUsuario;
            this.SCPF = infos.SCPF;
            this.SEmail = infos.SEmail;
            this.SLogin = infos.SLogin;
            this.SNome = infos.SNome;
            this.sSenha = infos.sSenha;
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
