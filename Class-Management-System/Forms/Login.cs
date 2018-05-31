using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Management_System.Services;
using Class_Management_System.ServicesImpl;
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
            dtbLogin = this.databaseService.BuscaDados(" CALL SPVERIFICA_LOGIN (sLogin= '" + txtLogin.Text + "',sSenha ='" + txtSenha.Text + "')");
            if (dtbLogin.Rows.Count > 0)
            {
                //login validado , direciona tela inicial 
            }
            else
            {
                MessageBox.Show("Login e/ou senha estão incorretos!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
