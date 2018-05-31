using Class_Management_System.Entities;
using Class_Management_System.Global;
using Class_Management_System.Services;
using Class_Management_System.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace Class_Management_System.Forms
{
    public partial class Configuracoes : Form
    {
        private string backupNameServidor;
        private string backupPort;
        private string backupUser;
        private string backupPassword;
        private string backupDatabase;
        private readonly IDataBaseService databaseService;

        public Configuracoes()
        {
            InitializeComponent();
            this.CarregarInfosDataBase();
            CarregarInfosArquivo();
            this.databaseService = DependencyFactory.Resolve<IDataBaseService>();
        }

        /// <summary>
        /// Carrega as informações da classe DataBaseConection nos textbox
        /// </summary>
        private void CarregarInfosDataBase()
        {
            this.txtBanco.Text = DataBaseConection.database;
            this.txtPorta.Text = DataBaseConection.port;
            this.txtSenha.Text = DataBaseConection.password;
            this.txtServidor.Text = DataBaseConection.server;
            this.txtUsuario.Text = DataBaseConection.user;

            this.backupDatabase = this.txtBanco.Text;
            this.backupPort = this.txtPorta.Text;
            this.backupPassword = this.txtSenha.Text;
            this.backupNameServidor = this.txtServidor.Text;
            this.backupUser = this.txtUsuario.Text;
        }

        /// <summary>
        /// Busca as informações da configuração de acesso ao banco de dados
        /// Que estão salvas em um arquivo. As informações estão salvar no seguinte formato:
        /// banco;porta;senha;servidor;usuario
        /// </summary>
        /// <returns></returns>
        public static void CarregarInfosArquivo()
        {
            if (File.Exists(Session.configFilePath))
            {
                using (StreamReader leitor = new StreamReader(Session.configFilePath))
                {
                    try
                    {
                        string[] infos = leitor.ReadLine().Split(';');
                        leitor.Close();

                        if (infos.Length > 0)
                        {
                            if (DataBaseConection.database == null) DataBaseConection.database = infos[0];
                            if (DataBaseConection.port == null) DataBaseConection.port = infos[1];
                            if (DataBaseConection.password == null) DataBaseConection.password = infos[2];
                            if (DataBaseConection.server == null) DataBaseConection.server = infos[3];
                            if (DataBaseConection.user == null) DataBaseConection.user = infos[4];
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Falha na leitura do arquivo de configuração" + e.Message,
                            "File Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                File.Create(Session.configFilePath);
            }
        }

        /// <summary>
        /// Persiste as informações de conexão com o banco no arquivo txt
        /// </summary>
        /// <param name="banco"></param>
        /// <param name="porta"></param>
        /// <param name="senha"></param>
        /// <param name="servidor"></param>
        /// <param name="usuario"></param>
        public static void SalvarInformacoesEmArquivo(string banco, string porta, string senha, string servidor, string usuario)
        {
            using (StreamWriter escrever = new StreamWriter(Session.configFilePath))
            {
                escrever.Write(banco + ";" + porta + ";" + senha + ";" + servidor + ";" + usuario);

                DataBaseConection.server = servidor;
                DataBaseConection.port = porta;
                DataBaseConection.user = usuario;
                DataBaseConection.password = senha;
                DataBaseConection.database = banco;

                escrever.Close();
            }
        }

        /// <summary>
        /// Testa a conexão com o banco, iniciando ela
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestarConexao_Click(object sender, EventArgs e)
        {
            DataBaseConection.server = txtServidor.Text;
            DataBaseConection.port = txtPorta.Text;
            DataBaseConection.user = txtUsuario.Text;
            DataBaseConection.password = txtSenha.Text;
            DataBaseConection.database = txtBanco.Text;

            try
            {
                this.databaseService.Open();
                MessageBox.Show("Conexão feita com sucesso!", "Sucesso",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha na conexão com o banco. Erro retornado: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvarEFechar_Click(object sender, EventArgs e)
        {
            SalvarInformacoesEmArquivo(txtBanco.Text, txtPorta.Text, txtSenha.Text, txtServidor.Text, txtUsuario.Text);

            this.backupDatabase = this.txtBanco.Text;
            this.backupPort = this.txtPorta.Text;
            this.backupPassword = this.txtSenha.Text;
            this.backupNameServidor = this.txtServidor.Text;
            this.backupUser = this.txtUsuario.Text;

            this.Close();
        }

        private void Configuracoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((this.txtBanco.Text != this.backupDatabase && this.backupDatabase != null) ||
                (this.txtPorta.Text != this.backupPort && this.backupPort != null) || (this.txtSenha.Text != this.backupPassword
                && this.backupPassword != null) || (this.txtServidor.Text != this.backupNameServidor && this.backupNameServidor != null)
                || (this.txtUsuario.Text != this.backupUser && this.backupUser != null))
            {
                DialogResult resultado = MessageBox.Show("Há alterações que não foram salvas. Deseja salva-las agora ?",
                    "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    SalvarInformacoesEmArquivo(this.txtBanco.Text, this.txtPorta.Text, this.txtSenha.Text,
                        this.txtServidor.Text, this.txtUsuario.Text);
                }
                else if (resultado == DialogResult.No)
                {
                    SalvarInformacoesEmArquivo(this.backupDatabase, this.backupPort, this.backupPassword,
                        this.backupNameServidor, this.backupUser);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                SalvarInformacoesEmArquivo(this.txtBanco.Text, this.txtPorta.Text, this.txtSenha.Text,
                       this.txtServidor.Text, this.txtUsuario.Text);
            }
        } 
    }
}
