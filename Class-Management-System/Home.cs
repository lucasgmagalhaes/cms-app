using Class_Management_System.Entities;
using Class_Management_System.Forms;
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
        public Home()
        {
            InitializeComponent();
            this.grafoService = DependencyFactory.Resolve<IGrafoService>();
            this.aulaService = DependencyFactory.Resolve<IAulaService>();
            Configuracoes.CarregarInfosArquivo();
        }

        private void btnGerarGrafo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                LeitorArquivo leitor = new LeitorArquivo();
                FileInfo info = new FileInfo(openFile.FileName);

                List<string> arquivo = leitor.Ler(info.FullName);
                List<Aula> aulas = this.aulaService.CriarListaDeAulas(arquivo);
                List<IDado> dadosAula = new List<IDado>();

                dadosAula.AddRange(aulas);

                List<string> grafo = this.grafoService
                    .GerarHorariosFormatados(Vertice.ConverterParaVertice(dadosAula));

                this.InserirResultadosNaTabela(grafo);
            }
        }

        private void InserirResultadosNaTabela(List<string> resultados)
        {
            string[] divisao;
            resultados.ForEach(resultado =>
            {
                divisao = resultado.Split(';');
                this.dataGridGrafo.Rows.Add(divisao[0], divisao[1], divisao[2], divisao[3], divisao[4]);
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadUsuario cadastro = new CadUsuario();
            cadastro.ShowDialog();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            Sobre about = new Sobre();
            about.ShowDialog();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscaUsuario usuario = new BuscaUsuario();
            usuario.ShowDialog();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            Configuracoes configs = new Configuracoes();
            configs.ShowDialog();
        }
    }
}
