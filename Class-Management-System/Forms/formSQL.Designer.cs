namespace Class_Management_System.Forms
{
    partial class formSQL
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
            this.txtScript = new System.Windows.Forms.RichTextBox();
            this.lbllinhas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(12, 33);
            this.txtScript.Name = "txtScript";
            this.txtScript.ReadOnly = true;
            this.txtScript.Size = new System.Drawing.Size(415, 430);
            this.txtScript.TabIndex = 0;
            this.txtScript.Text = "";
            // 
            // lbllinhas
            // 
            this.lbllinhas.AutoSize = true;
            this.lbllinhas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllinhas.ForeColor = System.Drawing.Color.White;
            this.lbllinhas.Location = new System.Drawing.Point(325, 13);
            this.lbllinhas.Name = "lbllinhas";
            this.lbllinhas.Size = new System.Drawing.Size(51, 17);
            this.lbllinhas.TabIndex = 1;
            this.lbllinhas.Text = "Linhas:";
            // 
            // formSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(439, 475);
            this.Controls.Add(this.lbllinhas);
            this.Controls.Add(this.txtScript);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "formSQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script SQL ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formSQL_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtScript;
        private System.Windows.Forms.Label lbllinhas;
    }
}