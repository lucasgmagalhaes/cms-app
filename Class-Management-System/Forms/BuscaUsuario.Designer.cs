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
            this.lblPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.CmbFiltro = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.lblPesquisa.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPesquisa.Location = new System.Drawing.Point(135, 31);
            this.lblPesquisa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(90, 25);
            this.lblPesquisa.TabIndex = 0;
            this.lblPesquisa.Text = "Pesquisa:";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(139, 55);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(546, 35);
            this.txtPesquisa.TabIndex = 1;
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F);
            this.BtnPesquisar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPesquisar.Location = new System.Drawing.Point(821, 55);
            this.BtnPesquisar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(113, 38);
            this.BtnPesquisar.TabIndex = 2;
            this.BtnPesquisar.Text = "PESQUISAR";
            this.BtnPesquisar.UseVisualStyleBackColor = false;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Location = new System.Drawing.Point(139, 116);
            this.dtgPesquisa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.Size = new System.Drawing.Size(795, 523);
            this.dtgPesquisa.TabIndex = 3;
            this.dtgPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPesquisa_CellContentClick);
            // 
            // CmbFiltro
            // 
            this.CmbFiltro.Font = new System.Drawing.Font("Segoe UI Semibold", 16.25F);
            this.CmbFiltro.FormattingEnabled = true;
            this.CmbFiltro.Items.AddRange(new object[] {
            "ID",
            "LOGIN",
            "NOME",
            "CPF"});
            this.CmbFiltro.Location = new System.Drawing.Point(692, 55);
            this.CmbFiltro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbFiltro.Name = "CmbFiltro";
            this.CmbFiltro.Size = new System.Drawing.Size(121, 38);
            this.CmbFiltro.TabIndex = 4;
            // 
            // BuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 674);
            this.Controls.Add(this.CmbFiltro);
            this.Controls.Add(this.dtgPesquisa);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblPesquisa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "BuscaUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button BtnPesquisar;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.ComboBox CmbFiltro;
    }
}