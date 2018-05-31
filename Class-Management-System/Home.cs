using Class_Management_System.Entities;
using Class_Management_System.Forms;
using Class_Management_System.Global;
using Class_Management_System.Interfaces;
using Class_Management_System.Services;
using Class_Management_System.Structures;
using Class_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Class_Management_System
{
    public partial class Home : Form
    {
        private readonly IGrafoService grafoService;
        private readonly IAulaService aulaService;
        private readonly IDataBaseService dataBaseService;

        private Configuracoes configuracoes;
        private Sobre sobre;
        private BuscaUsuario buscarUsuario;
        private CadUsuario cadastroUsuario;
        private Login login;

        private HashSet<string> periodos;
        private HashSet<string> materias;
        private HashSet<string> professores;
        private HashSet<string> dias;
        private HashSet<string> horarios;

        public Home()
        {
            InitializeComponent();
            this.grafoService = DependencyFactory.Resolve<IGrafoService>();
            this.aulaService = DependencyFactory.Resolve<IAulaService>();
            this.dataBaseService = DependencyFactory.Resolve<IDataBaseService>();

            this.periodos = new HashSet<string>();
            this.materias = new HashSet<string>();
            this.professores = new HashSet<string>();
            this.dias = new HashSet<string>();
            this.horarios = new HashSet<string>();
        }
        private void Home_Shown(object sender, EventArgs e)
        {
            Configuracoes.CarregarInfosArquivo();
            this.IniciarConexaoBanco();
        }

        public void IniciarConexaoBanco()
        {
            try
            {
                this.dataBaseService.Open();
            }
            catch
            {
               DialogResult result = MessageBox.Show("Não foi possível conectar com o banco de dados. " +
                    "Deseja abrir a tela de configurações ?", "Banco de dados", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Exclamation);

                if(result == DialogResult.Yes)
                {
                    this.AbrirConfiguracoes();
                }
            }
        }
        /// <summary>
        /// Limpa todos os componentes da tela relacionados ao grafo
        /// </summary>
        private void LimparValoresTela()
        {
            this.checkBoxSelecaoUnica.Checked = true;

            this.periodos.Clear();
            this.dias.Clear();
            this.horarios.Clear();
            this.professores.Clear();
            this.materias.Clear();

            this.cmbDiaSemana.Items.Clear();
            this.cmbHorario.Items.Clear();
            this.cmbMateria.Items.Clear();
            this.cmbPeriodo.Items.Clear();
            this.cmbProfessor.Items.Clear();
            this.dataGridGrafo.Rows.Clear();
        }

        private void AbrirBuscarUsuario()
        {
            if (this.buscarUsuario == null) this.buscarUsuario = new BuscaUsuario();
            this.buscarUsuario.ShowDialog();
        }

        private void AbrirSobre()
        {
            if (this.sobre == null) this.sobre = new Sobre();
            this.sobre.ShowDialog();
        }

        private void AbrirConfiguracoes()
        {
            if (this.configuracoes == null) this.configuracoes = new Configuracoes();
            this.configuracoes.ShowDialog();
        }

        private void AbrirLogin()
        {
            if (this.login == null) this.login = new Login();
            this.login.ShowDialog();
        }

        private void AbrirCadastroUsuario()
        {
            this.cadastroUsuario = new CadUsuario(Session.usuario.PkUsuario);
            this.cadastroUsuario.ShowDialog();
        }

        /// <summary>
        /// Lê o arquivo com as informações das aulas, gera o grafo e exibe ele na tela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGerarGrafo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(openFile.FileName);
                txtFilePath.Text = info.FullName;

                LeitorArquivo leitor = new LeitorArquivo();
                List<string> arquivo = leitor.Ler(info.FullName);

                this.LimparValoresTela();

                List<Aula> aulas = this.aulaService.CriarListaDeAulas(arquivo);
                List<IDado> dadosAula = new List<IDado>();

                dadosAula.AddRange(aulas);

                List<string> grafo = this.grafoService
                    .GerarHorariosFormatados(Vertice.ConverterParaVertice(dadosAula));
                this.groupFiltro.Enabled = true;
                this.InserirResultadosNaTabela(grafo);
                this.InserirListasNoComboBox();
            }
        }

        /// <summary>
        /// Insere os valores de cada dado do grafo em uma lista HashSet
        /// </summary>
        /// <param name="periodo"></param>
        /// <param name="materia"></param>
        /// <param name="professor"></param>
        /// <param name="horario"></param>
        /// <param name="dia"></param>
        private void CarregarListaValores(string periodo, string materia, string professor, string horario, string dia)
        {
            this.periodos.Add(periodo);
            this.materias.Add(materia);
            this.professores.Add(professor);
            this.horarios.Add(horario);
            this.dias.Add(dia);
        }

        /// <summary>
        /// Insere os valores da lista de cada dado do grafo nos combobox respectivos à eles
        /// </summary>
        private void InserirListasNoComboBox()
        {
            foreach (string periodo in this.periodos) this.cmbPeriodo.Items.Add(periodo);
            foreach (string materia in this.materias) this.cmbMateria.Items.Add(materia);
            foreach (string professor in this.professores) this.cmbProfessor.Items.Add(professor);
            foreach (string horario in this.horarios) this.cmbHorario.Items.Add(horario);
            foreach (string dia in this.dias) this.cmbDiaSemana.Items.Add(dia);
        }

        /// <summary>
        /// Insere grafo no DataGridView
        /// </summary>
        /// <param name="resultados"></param>
        private void InserirResultadosNaTabela(List<string> resultados)
        {
            string[] divisao;

            resultados.ForEach(resultado =>
            {
                divisao = resultado.Split(';');
                this.dataGridGrafo.Rows.Add(divisao[0], divisao[1], divisao[2], divisao[3], divisao[4]);
                this.CarregarListaValores(divisao[0], divisao[1], divisao[2], divisao[3], divisao[4]);
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.AbrirLogin();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.AbrirCadastroUsuario();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.AbrirSobre();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            this.AbrirBuscarUsuario();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            this.AbrirConfiguracoes();
        }

        /// <summary>
        /// Torna todas as linhas do DataGrid visíveis e desmarca todos os ComboBox
        /// </summary>
        private void HabilitarLinhasDataGrid()
        {
            foreach (DataGridViewRow linha in this.dataGridGrafo.Rows)
            {
                linha.Visible = true;
            }

            this.cmbDiaSemana.SelectedIndex = -1;
            this.cmbHorario.SelectedIndex = -1;
            this.cmbMateria.SelectedIndex = -1;
            this.cmbPeriodo.SelectedIndex = -1;
            this.cmbProfessor.SelectedIndex = -1;
        }

        /// <summary>
        /// Seleciona no DataGridView apenas os itens quem contém a informação selecionada no combox
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="indexCell"></param>
        private void ExecutarFiltro(ComboBox combo, int indexCell)
        {
            if (combo.SelectedItem != null)
            {
                string itemSelecionado = combo.SelectedItem.ToString();
                if (this.checkBoxSelecaoUnica.Checked)
                {
                    foreach (DataGridViewRow linha in this.dataGridGrafo.Rows)
                    {
                        if (linha.Cells[indexCell].Value.ToString() != itemSelecionado) linha.Visible = false;
                        else linha.Visible = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow linha in this.dataGridGrafo.Rows)
                    {
                        if (linha.Cells[indexCell].Value.ToString() != itemSelecionado) linha.Visible = false;
                    }
                }
            }
        }
        
        /// <summary>
        /// Limpa os valores do ComboBox exceto aquele que foi selecionado
        /// </summary>
        /// <param name="combo"></param>
        private void LimparSelectedComboboxExceto(ComboBox combo)
        {
            if (combo.SelectedItem != null && this.checkBoxSelecaoUnica.Checked)
            {
                if (this.cmbDiaSemana.Name != combo.Name) this.cmbDiaSemana.SelectedIndex = -1;
                if (this.cmbHorario.Name != combo.Name) this.cmbHorario.SelectedIndex = -1;
                if (this.cmbMateria.Name != combo.Name) this.cmbMateria.SelectedIndex = -1;
                if (this.cmbPeriodo.Name != combo.Name) this.cmbPeriodo.SelectedIndex = -1;
                if (this.cmbProfessor.Name != combo.Name) this.cmbProfessor.SelectedIndex = -1;
            }
        }

        private void cmbPeriodo_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExecutarFiltro(this.cmbPeriodo, 0);
            this.LimparSelectedComboboxExceto(this.cmbPeriodo);
        }

        private void cmbMateria_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExecutarFiltro(this.cmbMateria, 1);
            this.LimparSelectedComboboxExceto(this.cmbMateria);
        }

        private void cmbProfessor_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExecutarFiltro(this.cmbProfessor, 2);
            this.LimparSelectedComboboxExceto(this.cmbProfessor);
        }

        private void cmbHorario_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExecutarFiltro(this.cmbHorario, 3);
            this.LimparSelectedComboboxExceto(this.cmbHorario);
        }

        private void cmbDiaSemana_SelectedValueChanged(object sender, EventArgs e)
        {
            this.ExecutarFiltro(this.cmbDiaSemana, 4);
            this.LimparSelectedComboboxExceto(this.cmbDiaSemana);
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            this.HabilitarLinhasDataGrid();
        }
    }
}
