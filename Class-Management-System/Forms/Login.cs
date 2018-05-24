using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Management_System.ServicesImpl;

namespace Class_Management_System.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            DataBaseServiceImpl dbService = new DataBaseServiceImpl();
            DataTable dtbLogin = new DataTable();
            dtbLogin = dbService.BuscaDados("EXEC SPVERIFICA_LOGIN @sLogin= '" + txtLogin.Text + "',@sSenha ='" + txtSenha.Text + "'");
            if (dtbLogin.Rows.Count >0)
            {
                //login validado , direciona tela inicial 
            }
            else
            {
                MessageBox.Show("Login e/ou senha estão incorretos!");
            }
        }
    }
}
