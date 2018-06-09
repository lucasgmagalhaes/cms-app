using Class_Management_System.Entities;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Class_Management_System.Forms
{
    public partial class FormEditarPerfil : Form
    {
        private Usuario usuario;
        private readonly IProcedureService procedureService;
        private List<PerfilUsuario> listaPerfis;

        public FormEditarPerfil()
        {
            InitializeComponent();
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
            this.CarregaPerfil();
        }

        public void DefinirUsuario(Usuario usuario)
        {
            this.usuario = usuario;
            this.MostraRegistro();
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

        private void CarregaPerfil()
        {
            try
            {
                this.listaPerfis = this.procedureService.BuscarPerfisUsuario();
                this.listaPerfis.ForEach(perfil => this.CmbPerfil.Items.Add(perfil.GetDescricao()));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro CarregaPerfil - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Pega os valores dos textbox e define nas propriedades correspondentes do objeto usuário
        /// </summary>
        private void DefinirValoresInterfaceSemSenha()
        {
            this.DefinirValoresBase();
        }

        /// <summary>
        /// Pega os valores dos textbox e define nas propriedades correspondentes do objeto usuário
        /// incluindo a senha
        /// </summary>
        private void DefinirValoresInterfaceComSenha()
        {
            this.DefinirValoresBase();
            this.usuario.SSenha = this.txtSenha.Text;
        }

        /// <summary>
        /// Definição base dos valores padrões
        /// </summary>
        private void DefinirValoresBase()
        {
            this.usuario.SNome = this.TxtNome.Text;
            this.usuario.SCPF = ValidadorCpf.RemoverMascaraCpf(this.usuario.SCPF);
            this.usuario.SEmail = this.txtEmail.Text;
            this.usuario.SLogin = this.txtLogin.Text;
            this.usuario.Perfil = this.listaPerfis[this.CmbPerfil.SelectedIndex];
        }

        /// <summary>
        /// Mostra os dados do Usuário na tela
        /// </summary>
        public void MostraRegistro()
        {
            try
            {
                TxtNome.Text = this.usuario.SNome;
                txtCpf.Text = this.usuario.SCPF;
                txtEmail.Text = this.usuario.SEmail;
                txtLogin.Text = this.usuario.SLogin;
                CmbPerfil.SelectedItem = this.usuario.Perfil.GetDescricao();
                CmbPerfil.SelectedValue = this.usuario.Perfil.GetDescricao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro MostraRegistro - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidaGravar()
        {
            try
            {
                if (string.IsNullOrEmpty(TxtNome.Text))
                {
                    MessageBox.Show("Favor preencher o campo de Nome!", "Campo faltando",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtNome.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    MessageBox.Show("Favor preencher o campo de CPF!", "Campo faltando",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpf.Focus();
                    return false;
                }
                if (ValidadorCpf.ValidaCpf(txtCpf.Text) == false)
                {
                    MessageBox.Show("CPF Inválido : " + txtCpf.Text, "Campo faltando",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpf.Focus();
                    return false;
                }
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    MessageBox.Show("Favor preencher o campo de E-mail!", "Campo faltando",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEmail.Focus();
                    return false;
                }
                if (CmbPerfil.SelectedIndex == -1)
                {
                    MessageBox.Show("Favor selecionar um perfil!", "Campo faltando",
                       MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    CmbPerfil.Focus();
                    return false;
                }
                if (txtSenha.Text != txtConfirma.Text)
                {
                    MessageBox.Show("As senhas não são iguais!", "Campo faltando",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - ValidaGravar " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool VerificaCpfExist()
        {
            try
            {
                return this.procedureService.CpfCadastrado(ValidadorCpf.RemoverMascaraCpf(this.txtCpf.Text));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro VerificaCpfExist - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaGravar())
                {
                    if (this.txtSenha.Text == "") this.DefinirValoresInterfaceSemSenha();
                    else this.DefinirValoresInterfaceComSenha();
                    this.procedureService.GravarOuAtualizarUsuario(this.usuario);
                    MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso alteração",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "Falha gravação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja remover o usuário ?", "Remover", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.procedureService.RemoverUsuario(usuario);
                    result = MessageBox.Show("Usuário removido com sucesso!", "Sucesso deletar",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Session.usuario_removido = this.usuario;
                    this.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message, "Falha deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormEditarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
