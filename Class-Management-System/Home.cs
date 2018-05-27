using Class_Management_System.Entities;
using Class_Management_System.Interfaces;
using Class_Management_System.Services;
using Class_Management_System.Structures;
using Class_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            }
        }

        private void InserirResultadosNaTabela(List<string> resultados)
        {
            this.
        }
    }
}
