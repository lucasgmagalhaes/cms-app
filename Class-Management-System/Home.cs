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

        private Configuracoes configuracoes = new Configuracoes();
        private Sobre sobre;
        private BuscaUsuario buscarUsuario;
        private FormUsuario cadastroUsuario;
        private Login login;
        private FormEditarUsuario editarUsuario;

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

            try
            {
                Configuracoes.CarregarInfosArquivo();
                this.IniciarConexaoBanco();
            }
            catch
            {
                DialogResult resultado = MessageBox.Show("Falha na leitura do arquivo de configuração. " +
                    "Deseja abrir as configurações agora ?", "Config file", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    this.configuracoes.ShowDialog();
                }
                else return;
            }

            try
            {
                this.login = new Login();
                this.sobre = new Sobre();
                this.buscarUsuario = new BuscaUsuario();
                this.cadastroUsuario = new FormUsuario(0);
                this.editarUsuario = new FormEditarUsuario();

                this.login.FormClosed += Login_FormClosed;
                this.editarUsuario.FormClosed += EditarUsuario_FormClosed;
                this.periodos = new HashSet<string>();
                this.materias = new HashSet<string>();
                this.professores = new HashSet<string>();
                this.dias = new HashSet<string>();
                this.horarios = new HashSet<string>();
            }
            catch
            {
                DialogResult resultado = MessageBox.Show("Houve um problema na abertura do sistema. conecte ao banco e abra o aplicativo novamente", "Config file", 
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                this.Close();
            }
        }

        private void EditarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.usuario_removido != null)
            {
                this.lblusuario_logado.Visible = false;
                this.AcoesLogout();
                Session.usuario_removido = null;
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Session.usuario != null)
            {
                this.lblusuario_logado.Visible = true;
                this.lblusuario_logado.Text = "Bem vindo, " + Session.usuario.SNome;
                this.AcoesLogin();
            }
        }

        private void AcoesLogout()
        {
            this.btnLogin.Text = "Login";
            this.btnCadastrar.Enabled = false;
            this.btnBuscarUsuario.Enabled = false;
            this.btnPerfil.Enabled = false;
        }

        private void AcoesLogin()
        {
            this.btnLogin.Text = "Logout";
            this.btnCadastrar.Enabled = true;
            this.btnBuscarUsuario.Enabled = true;
            this.btnPerfil.Enabled = true;
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

                if (result == DialogResult.Yes)
                {
                    this.configuracoes.ShowDialog();
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

                List<string> arquivo = LeitorArquivo.Ler(info.FullName);

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
            if (this.btnLogin.Text.Equals("Logout"))
            {
                Session.usuario = null;
                this.lblusuario_logado.Visible = false;
                this.AcoesLogout();
            }
            else
            {
                this.login.ShowDialog();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.cadastroUsuario.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            this.sobre.ShowDialog();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            this.buscarUsuario.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            this.configuracoes.ShowDialog();
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

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            this.editarUsuario.DefinirUsuario(Session.usuario);
            this.editarUsuario.ShowDialog();
        }
    }
}
