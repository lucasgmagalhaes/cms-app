using System;
using System.Data;
using System.Collections.Generic; 
using Class_Management_System.ServicesImpl;
using Class_Management_System.Services; 
using Class_Management_System.Utils;

namespace Class_Management_System.Entities
{
    public class Usuario : Pessoa
    {
        private readonly IDataBaseService srvUsuario; 
        private int iCodPerfil;
        private int pkUsuario;
        private string sLogin;
        private string sSenha;

        public Usuario() : base()
        {
            this.iCodPerfil = 0;
            this.pkUsuario = 0;
            this.sLogin = "";
            this.sSenha = "";
            this.sNome = "";
            this.sEmail = "";
            this.sCPF = "";
            this.pkPessoa = 0;
            this.srvUsuario = DependencyFactory.Resolve<IDataBaseService>();
        }

        public Usuario(int pkUsuario, int iCodPerfil, string sLogin, string sSenha, string nom, string email, string cpf, int pkPess) : base(nom, email, cpf, pkPess)
        {
            this.iCodPerfil = iCodPerfil;
            this.pkUsuario = pkUsuario;
            this.sLogin = sLogin;
            this.sSenha = sSenha;
            this.sNome = nom;
            this.sEmail = email;
            this.sCPF = cpf;
            this.pkPessoa = pkPess;
            this.srvUsuario = DependencyFactory.Resolve<IDataBaseService>();
        }
        public Usuario(int pkUsuario, int iCodPerfil, string sLogin, string sSenha, string nom, string email, string cpf) : base(nom, email, cpf)
        {
            this.iCodPerfil = iCodPerfil;
            this.pkUsuario = pkUsuario;
            this.sLogin = sLogin;
            this.sSenha = sSenha;
            this.sNome = nom;
            this.sEmail = email;
            this.sCPF = cpf;
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
                if (this.pkUsuario == 0) //NOVO USUARIO
                {
                    srvUsuario.ExecutaQuery(" EXEC SPCRIA_ACESSO @sNome = '" + this.sNome + "',@sCpf ='" + this.sCPF + "',@sEmail = '" + this.sEmail + "',@sLoginUS = '" +
                      this.sLogin + "', @sSenhaUS = '" + this.sSenha + "',@pkPerfilUS = " + this.iCodPerfil);
                }
                else
                {
                    srvUsuario.ExecutaQuery(" EXEC SPGRAVA_DADOS_USUARIO @sNome = '" + this.sNome + "',@sCpf ='" + this.sCPF + "',@sEmail = '" + this.sEmail + "',@sLoginUS = '" +
                      this.sLogin + "', @sSenhaUS = '" + this.sSenha + "',@pkPerfilUS = " + this.iCodPerfil + ", @pkUsuario = " + pkUsuario);
                }
            }
            catch (Exception)
            {

                throw;
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
                dtbDados = srvUsuario.BuscaDados(" EXEC SPCONSULTA_USUARIO  @pkUsuario = '" + pk + "'");
                foreach (DataRow dr in dtbDados.Rows)
                {
                    //dr[X] X = NUMERO DA COLUNA NA CONSULTA
                    this.sNome = dr[3].ToString();
                    this.pkUsuario = (int)dr[0];
                    this.iCodPerfil = (int)dr[7];
                    this.sLogin = dr[1].ToString();
                    this.sSenha = dr[8].ToString();
                    this.sEmail = dr[5].ToString();
                    this.sCPF = dr[4].ToString();
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
                srvUsuario.ExecutaQuery(" EXEC SPDELETA_USUARIO @pkUsuario = " + this.pkUsuario);
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
                   iCodPerfil == usuario.iCodPerfil &&
                   pkUsuario == usuario.pkUsuario &&
                   sLogin == usuario.sLogin &&
                   sSenha == usuario.sSenha;
        }

        public override int GetHashCode()
        {
            var hashCode = -1541256906;
            hashCode = hashCode * -1521134295 + iCodPerfil.GetHashCode();
            hashCode = hashCode * -1521134295 + pkUsuario.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sLogin);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(sSenha);
            return hashCode;
        }
    }
}
