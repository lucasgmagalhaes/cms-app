namespace Class_Management_System.Forms
{
    partial class CadUsuario
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
            System.Windows.Forms.Button BtnGravar;
            System.Windows.Forms.Button BtnDeletar;
            System.Windows.Forms.Button BtnNovo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuario));
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.CmbPerfil = new System.Windows.Forms.ComboBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtConfirma = new System.Windows.Forms.MaskedTextBox();
            BtnGravar = new System.Windows.Forms.Button();
            BtnDeletar = new System.Windows.Forms.Button();
            BtnNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGravar
            // 
            BtnGravar.BackColor = System.Drawing.SystemColors.Highlight;
            BtnGravar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnGravar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            BtnGravar.FlatAppearance.BorderSize = 45;
            BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BtnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BtnGravar.Location = new System.Drawing.Point(337, 415);
            BtnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new System.Drawing.Size(129, 42);
            BtnGravar.TabIndex = 17;
            BtnGravar.Text = "Salvar";
            BtnGravar.UseVisualStyleBackColor = false;
            BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackColor = System.Drawing.Color.Red;
            BtnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnDeletar.FlatAppearance.BorderSize = 0;
            BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BtnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnDeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BtnDeletar.Location = new System.Drawing.Point(337, 467);
            BtnDeletar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new System.Drawing.Size(129, 42);
            BtnDeletar.TabIndex = 18;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.UseVisualStyleBackColor = false;
            // 
            // BtnNovo
            // 
            BtnNovo.BackColor = System.Drawing.SystemColors.Highlight;
            BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnNovo.FlatAppearance.BorderSize = 0;
            BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            BtnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnNovo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BtnNovo.Location = new System.Drawing.Point(131, 415);
            BtnNovo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new System.Drawing.Size(129, 42);
            BtnNovo.TabIndex = 19;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = false;
            BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(181, 45);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(268, 33);
            this.TxtNome.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(180, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(268, 33);
            this.txtEmail.TabIndex = 1;
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(180, 253);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(268, 33);
            this.txtLogin.TabIndex = 4;
            // 
            // CmbPerfil
            // 
            this.CmbPerfil.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CmbPerfil.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPerfil.FormattingEnabled = true;
            this.CmbPerfil.Location = new System.Drawing.Point(181, 199);
            this.CmbPerfil.Name = "CmbPerfil";
            this.CmbPerfil.Size = new System.Drawing.Size(268, 33);
            this.CmbPerfil.TabIndex = 6;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(86, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 22);
            this.lblNome.TabIndex = 7;
            this.lblNome.Text = "Nome:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCpf.Location = new System.Drawing.Point(102, 151);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(50, 22);
            this.lblCpf.TabIndex = 8;
            this.lblCpf.Text = "CPF:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogin.Location = new System.Drawing.Point(91, 258);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(64, 22);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "Login:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEmail.Location = new System.Drawing.Point(86, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 22);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSenha.Location = new System.Drawing.Point(82, 307);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(73, 22);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConfSenha.Location = new System.Drawing.Point(12, 355);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(162, 22);
            this.lblConfSenha.TabIndex = 12;
            this.lblConfSenha.Text = "Confirma Senha:";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPerfil.Location = new System.Drawing.Point(97, 204);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(56, 22);
            this.lblPerfil.TabIndex = 13;
            this.lblPerfil.Text = "Perfil:";
            // 
            // txtCpf
            // 
            this.txtCpf.AllowDrop = true;
            this.txtCpf.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtCpf.Culture = new System.Globalization.CultureInfo("pt-CH");
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(180, 146);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(268, 33);
            this.txtCpf.TabIndex = 14;
            // 
            // txtSenha
            // 
            this.txtSenha.AllowDrop = true;
            this.txtSenha.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(180, 302);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(268, 33);
            this.txtSenha.TabIndex = 15;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtConfirma
            // 
            this.txtConfirma.AllowDrop = true;
            this.txtConfirma.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtConfirma.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.Location = new System.Drawing.Point(180, 350);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(268, 33);
            this.txtConfirma.TabIndex = 16;
            this.txtConfirma.UseSystemPasswordChar = true;
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(603, 536);
            this.Controls.Add(BtnNovo);
            this.Controls.Add(BtnDeletar);
            this.Controls.Add(BtnGravar);
            this.Controls.Add(this.txtConfirma);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblPerfil);
            this.Controls.Add(this.lblConfSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.CmbPerfil);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Coral;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.ComboBox CmbPerfil;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox txtConfirma;
    }
}