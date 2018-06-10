using Class_Management_System.Entities;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;
using System;
using System.Windows.Forms;

namespace Class_Management_System.Forms
{
    public partial class FormEditarPerfil : Form
    {
        private readonly IProcedureService procedureService;
        private PerfilUsuario perfil;

        public FormEditarPerfil()
        {
            InitializeComponent();
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
        }

        public void DefinirPerfil(PerfilUsuario perfil)
        {
            this.perfil = perfil;
            this.txtid.Text = this.perfil.GetCodigo().ToString();
            this.txtdescricao.Text = this.perfil.GetDescricao();
        }

        /// <summary>
        /// Remove os caracteres especiais do cpf
        /// </summary>
        /// <param name="cpf"></param>
        /// <returns></returns>
        private string RemoverMascaraCpf(string cpf)
        {
            return cpf.Replace(".", "").Replace("-", "").Replace(",", "");
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if(this.perfil == null)
            {
                this.perfil = new PerfilUsuario();
            }
            this.perfil.SetDescricao(this.txtdescricao.Text);
            try
            {
                this.perfil.Gravar();
                this.txtid.Text = this.perfil.GetCodigo().ToString();
                MessageBox.Show("Perfil cadastrado com sucesso", "Falha ao gravar perfil", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Falha ao gravar perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                this.perfil.Deletar();
                Session.perfil_removido = this.perfil;
                 MessageBox.Show("Perfil removido com sucesso", "Falha ao gravar perfil", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Falha ao remover perfil", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormEditarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
