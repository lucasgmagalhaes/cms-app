using Class_Management_System.Global;
using Class_Management_System.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Class_Management_System.Forms
{
    public partial class formSQL : Form
    {
        public formSQL()
        {
            InitializeComponent();
            try
            {
                List<string> file = LeitorArquivo.LerSemValidacao(Session.scriptFilePath);
                StringBuilder builder = new StringBuilder();
                file.ForEach(linha => builder.AppendLine(linha));
                this.txtScript.Text = builder.ToString();
                this.lbllinhas.Text += file.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Falha leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
