using System;
using System.Data;
using System.Windows.Forms;
using Class_Management_System.Entities;
using Class_Management_System.Services;
using Class_Management_System.Utils;

namespace Class_Management_System.Forms
{
    public partial class BuscaUsuario : Form
    {
        private readonly IDataBaseService dbService;
        DataTable dtbPesquisa = new DataTable();
        public BuscaUsuario()
        {
            InitializeComponent();
            this.dbService = DependencyFactory.Resolve<IDataBaseService>();
            MontaDtb();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                dtbPesquisa = GeraDadosPesquisa();
                dtgPesquisa.DataSource = dtbPesquisa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - BtnPesquisar_Click " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
        public void MontaDtb()
        {
            try
            {
                dtbPesquisa.Columns.Add("ID", Type.GetType("System.Int32"));
                dtbPesquisa.Columns.Add("LOGIN", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("NOME", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("CPF", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("E-MAIL", Type.GetType("System.String"));
                dtbPesquisa.Columns.Add("PERFIL", Type.GetType("System.String"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - MontaDtb " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        public DataTable GeraDadosPesquisa()
        {
            try
            {
                string sSql = " CALL SPCONSULTA_USUARIO ( ";
                if (string.IsNullOrEmpty(txtPesquisa.Text) == false)
                {
                    switch (CmbFiltro.SelectedItem.ToString())
                    {
                        case "ID":
                            sSql += "  '" + txtPesquisa.Text + "', '', '', ''";
                            break;
                        case "LOGIN":
                            sSql += " '', '" + txtPesquisa.Text + "', '', ''";
                            break;
                        case "NOME":
                            sSql += " '', '', '" + txtPesquisa.Text + "', ''";
                            break;
                        case "CPF":
                            sSql += " '','','', '" + txtPesquisa.Text + "'";
                            break;
                        default:
                            break;
                    }
                }
                sSql += ")";
                return dbService.BuscaDados(sSql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro - MontaGrade " + e.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void DtgPesquisa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void DtgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                object value = dtgPesquisa.Rows[e.RowIndex].Cells[0].Value;
                if (value is DBNull) { return; }
                int pkUsuario = (int)value;
                FormUsuario cadastro = new FormUsuario(pkUsuario);
                cadastro.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro - DtgPesquisa_CellContentClick " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }
    }
}
