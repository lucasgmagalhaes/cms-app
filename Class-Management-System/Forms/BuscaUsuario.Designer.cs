namespace Class_Management_System.Forms
{
    partial class BuscaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaUsuario));
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisa.ForeColor = System.Drawing.Color.White;
            this.lblPesquisa.Location = new System.Drawing.Point(62, 28);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(99, 22);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisar:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(66, 55);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(566, 35);
            this.txtPesquisa.TabIndex = 1;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisar.Location = new System.Drawing.Point(642, 55);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(113, 38);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnlimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlimpar.Location = new System.Drawing.Point(765, 55);
            this.btnlimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(172, 38);
            this.btnlimpar.TabIndex = 4;
            this.btnlimpar.Text = "Limpar Resultados";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_login,
            this.col_nome,
            this.col_cpf,
            this.col_email,
            this.col_perfil});
            this.dtgPesquisa.Location = new System.Drawing.Point(66, 115);
            this.dtgPesquisa.Margin = new System.Windows.Forms.Padding(5);
            this.dtgPesquisa.MultiSelect = false;
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.RowHeadersVisible = false;
            this.dtgPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPesquisa.ShowCellErrors = false;
            this.dtgPesquisa.ShowEditingIcon = false;
            this.dtgPesquisa.ShowRowErrors = false;
            this.dtgPesquisa.Size = new System.Drawing.Size(871, 430);
            this.dtgPesquisa.TabIndex = 3;
            this.dtgPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPesquisa_CellContentClick);
            this.dtgPesquisa.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgPesquisa_CellFormatting_1);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Width = 80;
            // 
            // col_login
            // 
            this.col_login.HeaderText = "LOGIN";
            this.col_login.Name = "col_login";
            this.col_login.ReadOnly = true;
            this.col_login.Width = 130;
            // 
            // col_nome
            // 
            this.col_nome.HeaderText = "NOME";
            this.col_nome.Name = "col_nome";
            this.col_nome.ReadOnly = true;
            this.col_nome.Width = 150;
            // 
            // col_cpf
            // 
            this.col_cpf.HeaderText = "CPF";
            this.col_cpf.Name = "col_cpf";
            this.col_cpf.ReadOnly = true;
            this.col_cpf.Width = 150;
            // 
            // col_email
            // 
            this.col_email.HeaderText = "EMAIL";
            this.col_email.Name = "col_email";
            this.col_email.ReadOnly = true;
            this.col_email.Width = 230;
            // 
            // col_perfil
            // 
            this.col_perfil.HeaderText = "PERFIL";
            this.col_perfil.Name = "col_perfil";
            this.col_perfil.ReadOnly = true;
            this.col_perfil.Width = 130;
            // 
            // BuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.dtgPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuscaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_login;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_perfil;
    }
}