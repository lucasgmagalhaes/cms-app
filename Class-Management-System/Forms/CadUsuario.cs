using System;
using System.Windows.Forms;
using Class_Management_System.Services;
using Class_Management_System.ServicesImpl;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class CadUsuario : Form
    {
        private readonly IDataBaseService dbService;
        public CadUsuario()
        {
            InitializeComponent();
            this.dbService = DependencyFactory.Resolve<IDataBaseService>();
        }
        private void CarregaPerfil()
        {
            try
            {
                dbService.CarregaCmb(CmbPerfil, "EXEC SPCARREGA_PERFIL")
;
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void BtnDeletar_Click(object sender, EventArgs e)
        {

        }
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidaGravar())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro BtnGravar_Click - " + ex.Message);
                throw;
            }
        }
        private bool ValidaGravar()
        {
            try
            {
                if (string.IsNullOrEmpty(TxtNome.Text))
                {
                    MessageBox.Show("Favor preencher o campo de Nome!");
                    TxtNome.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    MessageBox.Show("Favor preencher o campo de CPF!");
                    txtCpf.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    MessageBox.Show("Favor preencher o campo de Login!");
                    txtLogin.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Favor preencher o campo de E-mail!");
                    txtEmail.Focus();
                    return false;
                }
                if ((int)CmbPerfil.SelectedValue == 0)
                {
                    MessageBox.Show("Favor selecionar um perfil!");
                    CmbPerfil.Focus();
                    return false;
                }
                if ((string.IsNullOrEmpty(txtSenha.Text) && string.IsNullOrEmpty(txtConfirma.Text)))
                {
                    MessageBox.Show("Favor preencher o campo de senha e confirmar senha!");
                    txtSenha.Focus();
                    return false;
                }
                if (txtSenha.Text != txtConfirma.Text)
                {
                    MessageBox.Show("Os campos de senha e confirma senha estão diferentes!");
                    txtSenha.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - ValidaGravar " + e.Message);
                return false;
            }
        }
    }
}
