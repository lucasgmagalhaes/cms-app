using Class_Management_System.Entities;
using Class_Management_System.Services;
using Class_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Data;

namespace Class_Management_System.ServicesImpl
{
    public class ProcedureServiceImpl : IProcedureService
    {
        private readonly IDataBaseService dataService;

        public ProcedureServiceImpl()
        {
            this.dataService = DependencyFactory.Resolve<IDataBaseService>();
        }

        public int BuscarCodigoUsuario(string login, string senha)
        {
            if ((login == null || login == "") && (senha == "" || senha == null))
                throw new Exception("Login e senha inválido para busca");
            else if (login == null || login == "") throw new Exception("login inválido para busca");
            else if (senha == "" || senha == null) throw new Exception("senha inválida para busca");
            return this.dataService.BuscaDados(" CALL SPVERIFICA_LOGIN ('" + login + "','" + senha + "')")
                 .Rows[0].Field<int>(0);
        }

        public int BuscarCodigoUsuario(int cpf)
        {
            if (cpf <= 0) throw new Exception("CPF inválido para busca");
            return this.dataService.BuscaDados(" CALL SPVERIFICA_CPF ('" + cpf.ToString() + "')")
               .Rows[0].Field<int>(0);
        }

        public Usuario BuscarUsuario(int id)
        {
            if (id == 0) throw new Exception("ID inválido para busca de usuário");
            try
            {
                DataTable dtbDados = new DataTable();
                Usuario user = new Usuario();
                dtbDados = this.dataService.BuscaDados(" CALL SPCONSULTA_USUARIO ('" + id + "' )");
                if (dtbDados.Rows.Count > 0)
                {
                    user.PkUsuario = dtbDados.Rows[0].Field<int>("ID");
                    user.PkPessoa = dtbDados.Rows[0].Field<int>("COD_PESSOA");
                    user.SLogin = dtbDados.Rows[0].Field<string>("LOGIN");
                    user.SSenha = dtbDados.Rows[0].Field<string>("SENHA");
                    user.SLogin = dtbDados.Rows[0].Field<string>("EMAIL");
                    user.SSenha = dtbDados.Rows[0].Field<string>("COD_CPF");
                    user.Perfil.SetCodigo(dtbDados.Rows[0].Field<int>("COD_PERFIL_USUARIO"));
                    user.Perfil = new PerfilUsuario(dtbDados.Rows[0].Field<int>("COD_PERFIL_USUARIO"),
                        dtbDados.Rows[0].Field<string>("PERFIL"));
                }
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void CriarPerfil(PerfilUsuario perfil)
        {
            try
            {
                this.dataService.ExecutaQuery("INSERT INTO PERFIL_USUARIO(DSC_PERFIL_USUARIO) VALUES('" + perfil.GetDescricao() + "'");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public int BuscarIdPerfilUsuarioPorDescicao(string descricao)
        {
            try
            {
                DataTable resultado = this.dataService.BuscaDados("SELECT COD_PERFIL_USUARIO FROM PERFIL_USUARIO " +
                    "WHERE DSC_PERFIL_USUARIO = '" + descricao + "'");
                if (resultado.Rows.Count > 0)
                {
                    return resultado.Rows[0].Field<int>(0);
                }
                return 0;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Usuario> BuscarUsuarios(string filtro)
        {
            string sql = "";
            if (filtro == "" || filtro == null)
            {
                sql = "SELECT U.COD_USUARIO ID , U.LOGIN LOGIN, PU.DSC_PERFIL_USUARIO PERFIL, " +
                    "P.NOME_PESSOA, P.COD_CPF, P.EMAIL, P.COD_PESSOA, PU.COD_PERFIL_USUARIO, U.SENHA " +
                    "FROM USUARIO U LEFT JOIN PERFIL_USUARIO PU ON PU.COD_PERFIL_USUARIO = U.COD_PERFIL_USUARIO " +
                    " LEFT JOIN PESSOA P ON P.COD_PESSOA = U.COD_PESSOA WHERE 1 = 1";
            }
            else
            {
                try
                {
                    long cpf = long.Parse(filtro);
                    if (filtro.Length == 11)
                    {
                        sql = "SELECT U.COD_USUARIO ID , U.LOGIN LOGIN, PU.DSC_PERFIL_USUARIO PERFIL, " +
                              "P.NOME_PESSOA, P.COD_CPF, P.EMAIL, P.COD_PESSOA, PU.COD_PERFIL_USUARIO, U.SENHA " +
                              "FROM USUARIO U LEFT JOIN PERFIL_USUARIO PU ON PU.COD_PERFIL_USUARIO = U.COD_PERFIL_USUARIO " +
                              " LEFT JOIN PESSOA P ON P.COD_PESSOA = U.COD_PESSOA WHERE 1 = 1 AND P.COD_CPF = '" + filtro + "'";
                    }
                    else
                    {
                        sql = "SELECT U.COD_USUARIO ID , U.LOGIN LOGIN, PU.DSC_PERFIL_USUARIO PERFIL, " +
                              "P.NOME_PESSOA, P.COD_CPF, P.EMAIL, P.COD_PESSOA, PU.COD_PERFIL_USUARIO, U.SENHA " +
                              "FROM USUARIO U LEFT JOIN PERFIL_USUARIO PU ON PU.COD_PERFIL_USUARIO = U.COD_PERFIL_USUARIO " +
                              " LEFT JOIN PESSOA P ON P.COD_PESSOA = U.COD_PESSOA WHERE 1 = 1 AND U.COD_USUARIO = '" + filtro + "'";
                    }
                }
                catch
                {
                    sql = "SELECT U.COD_USUARIO ID , U.LOGIN LOGIN, PU.DSC_PERFIL_USUARIO PERFIL, " +
                          " P.NOME_PESSOA, P.COD_CPF, P.EMAIL, P.COD_PESSOA, PU.COD_PERFIL_USUARIO, U.SENHA " +
                          " FROM USUARIO U LEFT JOIN PERFIL_USUARIO PU ON PU.COD_PERFIL_USUARIO = U.COD_PERFIL_USUARIO " +
                          " LEFT JOIN PESSOA P ON P.COD_PESSOA = U.COD_PESSOA WHERE 1 = 1 AND P.NOME_PESSOA = '" + filtro + "'";
                }
            }

            Usuario usuario;
            List<Usuario> usuarios = new List<Usuario>();
            try
            {
                DataTable result = this.dataService.BuscaDados(sql);

                foreach (DataRow linha in result.Rows)
                {
                    usuario = new Usuario();
                    usuario.PkUsuario = linha.Field<int>("ID");
                    usuario.SLogin = linha.Field<string>("LOGIN");
                    usuario.Perfil = new PerfilUsuario(linha.Field<int>("COD_PERFIL_USUARIO"), linha.Field<string>("PERFIL"));
                    usuario.PkPessoa = linha.Field<int>("COD_PESSOA");
                    usuario.SNome = linha.Field<string>("NOME_PESSOA");
                    usuario.SCPF = linha.Field<string>("COD_CPF");
                    usuario.SEmail = linha.Field<string>("EMAIL");
                    usuario.SSenha = linha.Field<string>("SENHA");
                    usuarios.Add(usuario);
                }
                return usuarios;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void GravarOuAtualizarUsuario(Usuario usuario)
        {
            try
            {
                if (usuario.PkUsuario == 0) //NOVO USUARIO
                {
                    this.dataService.ExecutaQuery("CALL SPCRIA_ACESSO ('" + usuario.SNome + "','"
                        + usuario.SCPF + "','" + usuario.SEmail + "','" + usuario.SLogin + "','" + usuario.SSenha +
                        "'," + usuario.Perfil.GetCodigo() + ")");
                }
                else
                {
                    this.dataService.ExecutaQuery("CALL " + DataBaseConection.database + ".SPGRAVA_DADOS_USUARIO ('" + usuario.SNome +
                        "','" + usuario.SCPF + "','" + usuario.SEmail + "','" + usuario.SLogin +
                        "', '" + usuario.SSenha + "'," + usuario.Perfil.GetCodigo() + ", " + usuario.PkUsuario + ")");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RemoverUsuario(Usuario usuario)
        {
            if (usuario == null) throw new Exception("Usuário nullo");
            else if (usuario.PkUsuario == 0) throw new Exception("ID do usuário vazia");
            try
            {
                this.dataService.ExecutaQuery(" CALL SPDELETA_USUARIO (" + usuario.PkUsuario + ")");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
