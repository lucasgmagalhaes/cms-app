using System;
using System.Data;
using System.Windows.Forms;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class Login : Form
    {
        private readonly IDataBaseService databaseService;
        public Login()
        {
            InitializeComponent();
            this.databaseService = DependencyFactory.Resolve<IDataBaseService>();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataTable dtbLogin = new DataTable();
            try
            {
                dtbLogin = this.databaseService.BuscaDados(" CALL cms.SPVERIFICA_LOGIN ('" + txtLogin.Text + "','" + txtSenha.Text + "')");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível conectar-se ao banco. Por favor, verifique sua conexão." +
                    " Erro retornado: " + ex.Message,  "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtbLogin.Rows.Count > 0)
            {
                Session.usuario = EntidadesDatabase.InstancializarUsuarioPorLogin(dtbLogin, txtLogin.Text, txtSenha.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Login e/ou senha estão incorretos!", "Falha login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
