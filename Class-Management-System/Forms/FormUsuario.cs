using System;
using System.Windows.Forms;
using Class_Management_System.Services;
using Class_Management_System.Utils;
using Class_Management_System.Entities;
using System.Collections.Generic;

namespace Class_Management_System.Forms
{
    public partial class FormUsuario : Form
    {
        private readonly IProcedureService dbService;
        private Usuario user = new Usuario();//usuario que vai manipular na tela , sendo um novo ou um já cadastrado
        private List<PerfilUsuario> listaPerfis;
        /// <summary>
        /// Tela de Cadastro de Usuário
        /// </summary>
        /// <param name="pkUsuario">Parâmetro, se 0 cadastrando um novo usuário ou a PK de um usuário</param>
        public FormUsuario(int pkUsuario)
        {
            try
            {
                this.dbService = DependencyFactory.Resolve<IProcedureService>();
                this.Init();
                if (pkUsuario > 0) //Entrando no cadastro de um usuário 
                {
                    this.user.PkUsuario = pkUsuario;
                    this.MostraRegistro();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro Load_CadUsuario - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public FormUsuario(Usuario usuario)
        {
            this.dbService = DependencyFactory.Resolve<IProcedureService>();
            this.Init();
            this.user = usuario;
            this.MostraRegistro();
        }

        private void Init()
        {
            InitializeComponent();
            this.CarregaPerfil();
        }


        /// <summary>
        /// Mostra os dados do Usuário na tela
        /// </summary>
        public void MostraRegistro()
        {
            try
            {
                TxtNome.Text = this.user.SNome;
                txtCpf.Text = this.user.SCPF;
                txtEmail.Text = this.user.SEmail;
                txtSenha.Text = this.user.SSenha;
                txtLogin.Text = this.user.SLogin;
                CmbPerfil.SelectedItem = this.user.Perfil.GetDescricao();
                CmbPerfil.SelectedValue = this.user.Perfil.GetDescricao();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro MostraRegistro - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregaPerfil()
        {
            try
            {
                this.listaPerfis = dbService.BuscarPerfisUsuario();
                this.listaPerfis.ForEach(perfil => this.CmbPerfil.Items.Add(perfil.GetDescricao()));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro CarregaPerfil - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidaGravar())
                {
                    this.SetDadosUsuario();
                    try
                    {
                        this.user.Gravar();
                        MessageBox.Show("Usuário inserido com sucesso!", "Cadastro usuário",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro BtnGravar_Click - " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (this.user.PkUsuario == 0 && this.VerificaCpfExist())
                {
                    MessageBox.Show("Já existe um usuário com este CPF:" + txtCpf.Text, "Campo faltando",
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
                if ((string.IsNullOrEmpty(txtSenha.Text) && string.IsNullOrEmpty(txtConfirma.Text)))
                {
                    MessageBox.Show("Favor preencher o campo de senha e confirmar senha!", "Campo faltando",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtSenha.Focus();
                    return false;
                }
                if (txtSenha.Text != txtConfirma.Text)
                {
                    MessageBox.Show("Os campos de senha e confirma senha estão diferentes!", "Campo faltando",
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

        public void SetDadosUsuario()
        {
            try
            {
                this.user.SNome = TxtNome.Text;
                this.user.SCPF = ValidadorCpf.RemoverMascaraCpf(txtCpf.Text);
                this.user.SEmail = txtEmail.Text;
                this.user.Perfil = this.BuscarPerfiSelecionado();
                this.user.SLogin = txtLogin.Text;
                this.user.SSenha = txtSenha.Text;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - SetDadosUsuario " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Retorna o PerfilUsuario que foi selecionado no combobox
        /// </summary>
        /// <returns></returns>
        private PerfilUsuario BuscarPerfiSelecionado()
        {
            string descricao = this.CmbPerfil.SelectedItem.ToString();
            return this.listaPerfis.Find(perfil => perfil.GetDescricao() == descricao);
        }

        public bool VerificaCpfExist()
        {
            try
            {
                return this.dbService.CpfCadastrado(ValidadorCpf.RemoverMascaraCpf(this.txtCpf.Text));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro VerificaCpfExist - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void LimpaCampos()
        {
            try
            {
                txtConfirma.Text = "";
                txtCpf.Text = "";
                txtEmail.Text = "";
                txtLogin.Text = "";
                TxtNome.Text = "";
                txtSenha.Text = "";
                CmbPerfil.SelectedValue = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro LimpaCampos - " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                this.user = new Usuario();
                LimpaCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro BtnNovo_Click - " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                this.txtCpf.Text = "52337104044";
                this.txtEmail.Text = "teste@gmail.com";
                this.txtLogin.Text = "loginteste";
                this.TxtNome.Text = "nomeTeste";
                this.txtSenha.Text = "senhateste";
                this.txtConfirma.Text = "senhateste";
                if (this.CmbPerfil.Items.Count > 0)
                {
                    this.CmbPerfil.SelectedIndex = 0;
                }
            }
        }
    }
}

