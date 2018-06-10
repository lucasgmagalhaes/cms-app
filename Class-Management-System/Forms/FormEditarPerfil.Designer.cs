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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
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
            BtnDeletar.Location = new System.Drawing.Point(194, 176);
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
            BtnGravar.Location = new System.Drawing.Point(27, 176);
            BtnGravar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            BtnGravar.Name = "BtnGravar";
            BtnGravar.Size = new System.Drawing.Size(159, 35);
            BtnGravar.TabIndex = 34;
            BtnGravar.Text = "Gravar";
            BtnGravar.UseVisualStyleBackColor = false;
            BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(43, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 21);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Descrição";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(43, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(31, 21);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(136, 43);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(82, 27);
            this.txtid.TabIndex = 20;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(136, 89);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(205, 27);
            this.txtdescricao.TabIndex = 36;
            // 
            // FormEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(366, 230);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(BtnDeletar);
            this.Controls.Add(BtnGravar);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormEditarUsuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdescricao;
    }
}