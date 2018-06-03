using System;
using System.Windows.Forms;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class Login : Form
    {
        private readonly IProcedureService procedureService;
        public Login()
        {
            InitializeComponent();
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = this.procedureService.BuscarCodigoUsuario(this.txtLogin.Text, this.txtSenha.Text);

                if (codigo != 0)
                {
                    Session.usuario = EntidadesDatabase.InstancializarUsuarioPorLogin(codigo);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login e/ou senha estão incorretos!", "Falha login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DataBase Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.txtLogin.Text = "";
            this.txtSenha.Text = "";
        }
    }
}
