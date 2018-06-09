namespace Class_Management_System.Forms
{
    partial class FormEditarPerfil
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
            System.Windows.Forms.Button BtnDeletar;
            System.Windows.Forms.Button BtnGravar;
            this.txtConfirma = new System.Windows.Forms.MaskedTextBox();
            this.txtSenha = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblConfSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.CmbPerfil = new System.Windows.Forms.ComboBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            BtnDeletar = new System.Windows.Forms.Button();
            BtnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnDeletar
            // 
            BtnDeletar.BackColor = System.Drawing.SystemColors.Highlight;
            BtnDeletar.FlatAppearance.BorderSize = 0;
            BtnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnDeletar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnDeletar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BtnDeletar.Location = new System.Drawing.Point(263, 491);
            BtnDeletar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnDeletar.Name = "BtnDeletar";
            BtnDeletar.Size = new System.Drawing.Size(159, 35);
            BtnDeletar.TabIndex = 35;
            BtnDeletar.Text = "Deletar";
            BtnDeletar.UseVisualStyleBackColor = false;
            BtnDeletar.Click += new System.EventHandler(this.BtnDeletar_Click);
            // 
            // BtnGravar
            // 
            BtnGravar.BackColor = System.Drawing.SystemColors.Highlight;
            BtnGravar.FlatAppearance.BorderSize = 0;
            BtnGravar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            BtnGravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            BtnGravar.Location = new System.Drawing.Point(86, 491);
            BtnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new System.Drawing.Size(159, 35);
            BtnGravar.TabIndex = 34;
            BtnGravar.Text = "Gravar";
            BtnGravar.UseVisualStyleBackColor = false;
            BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // txtConfirma
            // 
            this.txtConfirma.AllowDrop = true;
            this.txtConfirma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirma.Location = new System.Drawing.Point(86, 396);
            this.txtConfirma.Name = "txtConfirma";
            this.txtConfirma.Size = new System.Drawing.Size(336, 27);
            this.txtConfirma.TabIndex = 33;
            this.txtConfirma.UseSystemPasswordChar = true;
            // 
            // txtSenha
            // 
            this.txtSenha.AllowDrop = true;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(86, 340);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(336, 27);
            this.txtSenha.TabIndex = 32;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCpf
            // 
            this.txtCpf.AllowDrop = true;
            this.txtCpf.Culture = new System.Globalization.CultureInfo("pt-CH");
            this.txtCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpf.Location = new System.Drawing.Point(86, 283);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(135, 27);
            this.txtCpf.TabIndex = 31;
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.ForeColor = System.Drawing.Color.White;
            this.lblPerfil.Location = new System.Drawing.Point(82, 194);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(49, 21);
            this.lblPerfil.TabIndex = 30;
            this.lblPerfil.Text = "Perfil:";
            // 
            // lblConfSenha
            // 
            this.lblConfSenha.AutoSize = true;
            this.lblConfSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfSenha.Location = new System.Drawing.Point(82, 369);
            this.lblConfSenha.Name = "lblConfSenha";
            this.lblConfSenha.Size = new System.Drawing.Size(182, 21);
            this.lblConfSenha.TabIndex = 29;
            this.lblConfSenha.Text = "Confirma nova senha:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(82, 313);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(106, 21);
            this.lblSenha.TabIndex = 28;
            this.lblSenha.Text = "Nova Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(82, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 21);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(87, 137);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(55, 21);
            this.lblLogin.TabIndex = 26;
            this.lblLogin.Text = "Login:";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(82, 256);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(44, 21);
            this.lblCpf.TabIndex = 25;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(84, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(61, 21);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // CmbPerfil
            // 
            this.CmbPerfil.BackColor = System.Drawing.SystemColors.Window;
            this.CmbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbPerfil.FormattingEnabled = true;
            this.CmbPerfil.Location = new System.Drawing.Point(86, 224);
            this.CmbPerfil.Name = "CmbPerfil";
            this.CmbPerfil.Size = new System.Drawing.Size(135, 29);
            this.CmbPerfil.TabIndex = 23;
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(86, 164);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(336, 27);
            this.txtLogin.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(86, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(336, 27);
            this.txtEmail.TabIndex = 21;
            // 
            // TxtNome
            // 
            this.TxtNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.Location = new System.Drawing.Point(86, 51);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(336, 27);
            this.TxtNome.TabIndex = 20;
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(520, 542);
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
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEditarUsuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtConfirma;
        private System.Windows.Forms.MaskedTextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblConfSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox CmbPerfil;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox TxtNome;
    }
}