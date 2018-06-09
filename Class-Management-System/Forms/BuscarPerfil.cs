using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Class_Management_System.Entities;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class BuscarPerfil : Form
    {
        private readonly IDataBaseService dbService;
        private readonly IProcedureService procedureService;
        private DataTable dtbPesquisa = new DataTable();
        private List<PerfilUsuario> usuariosPesquisa;
        private FormEditarPerfil formEditar;
        public BuscarPerfil()
        {
            InitializeComponent();
            this.formEditar = new FormEditarPerfil();
            this.formEditar.FormClosed += FormEditar_FormClosed;
            this.dbService = DependencyFactory.Resolve<IDataBaseService>();
            this.procedureService = DependencyFactory.Resolve<IProcedureService>();
        }

        private void FormEditar_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.usuario_removido != null)
            {
                int index = this.usuariosPesquisa.FindIndex(usuario => usuario.Equals(Session.usuario_removido));
                this.dtgPesquisa.Rows.RemoveAt(index);
                Session.usuario_removido = null;
            }
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                this.usuariosPesquisa = this.procedureService.BuscarPerfisUsuario(this.txtPesquisa.Text);
                this.InserirResultadoNoDataGrid(this.usuariosPesquisa);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - BtnPesquisar_Click " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InserirResultadoNoDataGrid(List<PerfilUsuario> usuarios)
        {
            this.dtgPesquisa.Rows.Clear();
            usuarios.ForEach(perfil => this.dtgPesquisa.Rows.Add(perfil.GetCodigo(), perfil.GetDescricao()));
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            this.dtgPesquisa.Rows.Clear();
        }

        private void dtgPesquisa_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3 && e.Value != null)
                {
                    Double.TryParse(e.Value.ToString(), out double d);
                    e.Value = d.ToString(@"000\.000\.000-000");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - DtgPesquisa_CellFormatting " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.formEditar.DefinirUsuario(this.usuariosPesquisa[e.RowIndex]);
            this.formEditar.ShowDialog();
        }

        private void BuscaUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
