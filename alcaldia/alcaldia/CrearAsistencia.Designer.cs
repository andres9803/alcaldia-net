namespace alcaldia
{
    partial class CrearAsistencia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(83, 190);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(120, 31);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar asistencia";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(40, 135);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(205, 21);
            this.cmbEstudiante.TabIndex = 3;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(40, 78);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(205, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // CrearAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearAsistencia";
            this.Text = "CrearAsistencia";
            this.Load += new System.EventHandler(this.CrearAsistencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.TextBox txtFecha;
    }
}