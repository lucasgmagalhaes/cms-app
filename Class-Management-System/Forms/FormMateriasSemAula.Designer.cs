namespace Class_Management_System.Forms
{
    partial class FormMateriasSemAula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridGrafo = new System.Windows.Forms.DataGridView();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrafo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGrafo
            // 
            this.dataGridGrafo.AllowUserToAddRows = false;
            this.dataGridGrafo.AllowUserToDeleteRows = false;
            this.dataGridGrafo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridGrafo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridGrafo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGrafo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridGrafo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.periodo,
            this.materia,
            this.professor,
            this.horario});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGrafo.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridGrafo.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridGrafo.Location = new System.Drawing.Point(13, 14);
            this.dataGridGrafo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridGrafo.MultiSelect = false;
            this.dataGridGrafo.Name = "dataGridGrafo";
            this.dataGridGrafo.ReadOnly = true;
            this.dataGridGrafo.RowHeadersVisible = false;
            this.dataGridGrafo.ShowCellErrors = false;
            this.dataGridGrafo.ShowCellToolTips = false;
            this.dataGridGrafo.ShowRowErrors = false;
            this.dataGridGrafo.Size = new System.Drawing.Size(654, 419);
            this.dataGridGrafo.TabIndex = 5;
            // 
            // periodo
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.MediumBlue;
            this.periodo.DefaultCellStyle = dataGridViewCellStyle14;
            this.periodo.HeaderText = "Período";
            this.periodo.Name = "periodo";
            this.periodo.ReadOnly = true;
            this.periodo.Width = 150;
            // 
            // materia
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materia.DefaultCellStyle = dataGridViewCellStyle15;
            this.materia.HeaderText = "Matéria";
            this.materia.Name = "materia";
            this.materia.ReadOnly = true;
            this.materia.Width = 200;
            // 
            // professor
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.professor.DefaultCellStyle = dataGridViewCellStyle16;
            this.professor.HeaderText = "Professor";
            this.professor.Name = "professor";
            this.professor.ReadOnly = true;
            this.professor.Width = 150;
            // 
            // horario
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.horario.DefaultCellStyle = dataGridViewCellStyle17;
            this.horario.HeaderText = "Aulas Semanais";
            this.horario.Name = "horario";
            this.horario.ReadOnly = true;
            this.horario.Width = 150;
            // 
            // FormMateriasSemAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 448);
            this.Controls.Add(this.dataGridGrafo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMateriasSemAula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matérias sem Aula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGrafo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGrafo;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn professor;
        private System.Windows.Forms.DataGridViewTextBoxColumn horario;
    }
}