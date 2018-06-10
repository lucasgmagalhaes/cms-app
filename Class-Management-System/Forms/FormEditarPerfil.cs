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
            this.perfil.Gravar();
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            this.perfil.Deletar();
            Session.perfil_removido = this.perfil;
        }

        private void FormEditarUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
