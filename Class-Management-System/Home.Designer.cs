namespace Class_Management_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGerarGrafo = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.dataGridGrafo = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dia_semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnConfiguracoes = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupFiltro = new System.Windows.Forms.GroupBox();
            this.checkBoxSelecaoUnica = new System.Windows.Forms.CheckBox();
            this.btnResetar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbDiaSemana = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbHorario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbProfessor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPeriodo = new System.Windows.Forms.ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrafo)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGerarGrafo);
            this.groupBox1.Controls.Add(this.txtFilePath);
            this.groupBox1.Location = new System.Drawing.Point(352, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(750, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnGerarGrafo
            // 
            this.btnGerarGrafo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGerarGrafo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnGerarGrafo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerarGrafo.Location = new System.Drawing.Point(453, 29);
            this.btnGerarGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGerarGrafo.Name = "btnGerarGrafo";
            this.btnGerarGrafo.Size = new System.Drawing.Size(268, 38);
            this.btnGerarGrafo.TabIndex = 1;
            this.btnGerarGrafo.Text = "Criar Grade De Horários";
            this.btnGerarGrafo.UseVisualStyleBackColor = false;
            this.btnGerarGrafo.Click += new System.EventHandler(this.btnGerarGrafo_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilePath.Location = new System.Drawing.Point(28, 29);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(414, 35);
            this.txtFilePath.TabIndex = 0;
            // 
            // dataGridGrafo
            // 
            this.dataGridGrafo.AllowUserToAddRows = false;
            this.dataGridGrafo.AllowUserToDeleteRows = false;
            this.dataGridGrafo.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridGrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGrafo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.materia,
            this.professor,
            this.horario,
            this.dia_semana});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGrafo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridGrafo.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridGrafo.Location = new System.Drawing.Point(352, 160);
            this.dataGridGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridGrafo.MultiSelect = false;
            this.dataGridGrafo.Name = "dataGridGrafo";
            this.dataGridGrafo.ReadOnly = true;
            this.dataGridGrafo.RowHeadersVisible = false;
            this.dataGridGrafo.ShowCellErrors = false;
            this.dataGridGrafo.ShowCellToolTips = false;
            this.dataGridGrafo.ShowRowErrors = false;
            this.dataGridGrafo.Size = new System.Drawing.Size(754, 671);
            this.dataGridGrafo.TabIndex = 4;
            // 
            // periodo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodo.DefaultCellStyle = dataGridViewCellStyle2;
            this.periodo.HeaderText = "Período";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            // 
            // materia
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materia.DefaultCellStyle = dataGridViewCellStyle3;
            this.materia.HeaderText = "Matéria";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            // 
            // professor
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.professor.DefaultCellStyle = dataGridViewCellStyle4;
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            // 
            // horario
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.horario.DefaultCellStyle = dataGridViewCellStyle5;
            this.horario.HeaderText = "Horário";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            // 
            // dia_semana
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dia_semana.DefaultCellStyle = dataGridViewCellStyle6;
            this.dia_semana.HeaderText = "Dia Semana";
            this.dia_semana.Name = "dia_semana";
            this.dia_semana.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnSobre);
            this.panel1.Controls.Add(this.btnConfiguracoes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 749);
            this.panel1.TabIndex = 5;
            // 
            // btnSobre
            // 
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSobre.Location = new System.Drawing.Point(0, 446);
            this.btnSobre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(261, 49);
            this.btnSobre.TabIndex = 10;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnConfiguracoes
            // 
            this.btnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguracoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguracoes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfiguracoes.Location = new System.Drawing.Point(0, 398);
            this.btnConfiguracoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConfiguracoes.Name = "btnConfiguracoes";
            this.btnConfiguracoes.Size = new System.Drawing.Size(261, 49);
            this.btnConfiguracoes.TabIndex = 9;
            this.btnConfiguracoes.Text = "Configurações";
            this.btnConfiguracoes.UseVisualStyleBackColor = true;
            this.btnConfiguracoes.Click += new System.EventHandler(this.btnConfiguracoes_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Class Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 50);
            this.label2.TabIndex = 7;
            this.label2.Text = "CMS";
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(0, 160);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(261, 49);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(0, 351);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(261, 49);
            this.button6.TabIndex = 3;
            this.button6.Text = "Grafo";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 303);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(261, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "Visualizar Perfil";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(0, 255);
            this.btnBuscarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(261, 49);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "Buscar Usuário";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 208);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(261, 49);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar Usuário";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bem vindo, ";
            // 
            // groupFiltro
            // 
            this.groupFiltro.Controls.Add(this.checkBoxSelecaoUnica);
            this.groupFiltro.Controls.Add(this.btnResetar);
            this.groupFiltro.Controls.Add(this.label8);
            this.groupFiltro.Controls.Add(this.cmbDiaSemana);
            this.groupFiltro.Controls.Add(this.label7);
            this.groupFiltro.Controls.Add(this.cmbHorario);
            this.groupFiltro.Controls.Add(this.label6);
            this.groupFiltro.Controls.Add(this.cmbProfessor);
            this.groupFiltro.Controls.Add(this.label5);
            this.groupFiltro.Controls.Add(this.cmbMateria);
            this.groupFiltro.Controls.Add(this.label4);
            this.groupFiltro.Controls.Add(this.cmbPeriodo);
            this.groupFiltro.Enabled = false;
            this.groupFiltro.Location = new System.Drawing.Point(1116, 55);
            this.groupFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupFiltro.Name = "groupFiltro";
            this.groupFiltro.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupFiltro.Size = new System.Drawing.Size(278, 597);
            this.groupFiltro.TabIndex = 7;
            this.groupFiltro.TabStop = false;
            this.groupFiltro.Text = "Filtros";
            // 
            // checkBoxSelecaoUnica
            // 
            this.checkBoxSelecaoUnica.AutoSize = true;
            this.checkBoxSelecaoUnica.Checked = true;
            this.checkBoxSelecaoUnica.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelecaoUnica.Location = new System.Drawing.Point(116, 29);
            this.checkBoxSelecaoUnica.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSelecaoUnica.Name = "checkBoxSelecaoUnica";
            this.checkBoxSelecaoUnica.Size = new System.Drawing.Size(132, 24);
            this.checkBoxSelecaoUnica.TabIndex = 10;
            this.checkBoxSelecaoUnica.Tag = "";
            this.checkBoxSelecaoUnica.Text = "Seleção  única";
            this.toolTip.SetToolTip(this.checkBoxSelecaoUnica, "Define se só poderá selecionar um único combobox");
            this.checkBoxSelecaoUnica.UseVisualStyleBackColor = true;
            // 
            // btnResetar
            // 
            this.btnResetar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnResetar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.btnResetar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnResetar.Location = new System.Drawing.Point(116, 65);
            this.btnResetar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetar.Name = "btnResetar";
            this.btnResetar.Size = new System.Drawing.Size(146, 35);
            this.btnResetar.TabIndex = 8;
            this.btnResetar.Text = "Limpar Filtro";
            this.btnResetar.UseVisualStyleBackColor = false;
            this.btnResetar.Click += new System.EventHandler(this.btnResetar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 469);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dia Semana";
            // 
            // cmbDiaSemana
            // 
            this.cmbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDiaSemana.FormattingEnabled = true;
            this.cmbDiaSemana.Location = new System.Drawing.Point(38, 505);
            this.cmbDiaSemana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDiaSemana.Name = "cmbDiaSemana";
            this.cmbDiaSemana.Size = new System.Drawing.Size(222, 28);
            this.cmbDiaSemana.Sorted = true;
            this.cmbDiaSemana.TabIndex = 8;
            this.cmbDiaSemana.SelectedValueChanged += new System.EventHandler(this.cmbDiaSemana_SelectedValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 377);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Horário";
            // 
            // cmbHorario
            // 
            this.cmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHorario.FormattingEnabled = true;
            this.cmbHorario.Location = new System.Drawing.Point(38, 412);
            this.cmbHorario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbHorario.Name = "cmbHorario";
            this.cmbHorario.Size = new System.Drawing.Size(222, 28);
            this.cmbHorario.Sorted = true;
            this.cmbHorario.TabIndex = 6;
            this.cmbHorario.SelectedValueChanged += new System.EventHandler(this.cmbHorario_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 282);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Professor";
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessor.FormattingEnabled = true;
            this.cmbProfessor.Location = new System.Drawing.Point(38, 317);
            this.cmbProfessor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.Size = new System.Drawing.Size(222, 28);
            this.cmbProfessor.Sorted = true;
            this.cmbProfessor.TabIndex = 4;
            this.cmbProfessor.SelectedValueChanged += new System.EventHandler(this.cmbProfessor_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Matéria";
            // 
            // cmbMateria
            // 
            this.cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(38, 238);
            this.cmbMateria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(222, 28);
            this.cmbMateria.Sorted = true;
            this.cmbMateria.TabIndex = 2;
            this.cmbMateria.SelectedValueChanged += new System.EventHandler(this.cmbMateria_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Período";
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FormattingEnabled = true;
            this.cmbPeriodo.Location = new System.Drawing.Point(38, 152);
            this.cmbPeriodo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(222, 28);
            this.cmbPeriodo.Sorted = true;
            this.cmbPeriodo.TabIndex = 0;
            this.cmbPeriodo.SelectedValueChanged += new System.EventHandler(this.cmbPeriodo_SelectedValueChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.groupFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridGrafo);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrafo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupFiltro.ResumeLayout(false);
            this.groupFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGerarGrafo;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.DataGridView dataGridGrafo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfiguracoes;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dia_semana;
        private System.Windows.Forms.GroupBox groupFiltro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbDiaSemana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbHorario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbProfessor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPeriodo;
        private System.Windows.Forms.Button btnResetar;
        private System.Windows.Forms.CheckBox checkBoxSelecaoUnica;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

