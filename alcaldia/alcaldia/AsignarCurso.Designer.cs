namespace alcaldia
{
    partial class AsignarCurso
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAsignarCurso = new System.Windows.Forms.Button();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.cmbIdUsuario = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione el curso al que desea registrarse: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAsignarCurso
            // 
            this.btnAsignarCurso.Location = new System.Drawing.Point(38, 139);
            this.btnAsignarCurso.Name = "btnAsignarCurso";
            this.btnAsignarCurso.Size = new System.Drawing.Size(235, 23);
            this.btnAsignarCurso.TabIndex = 2;
            this.btnAsignarCurso.Text = "Registrarme en este curso";
            this.btnAsignarCurso.UseVisualStyleBackColor = true;
            this.btnAsignarCurso.Click += new System.EventHandler(this.btnAsignarCurso_Click);
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(38, 99);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(235, 21);
            this.cmbCurso.TabIndex = 4;
            // 
            // cmbIdUsuario
            // 
            this.cmbIdUsuario.FormattingEnabled = true;
            this.cmbIdUsuario.Location = new System.Drawing.Point(22, 26);
            this.cmbIdUsuario.Name = "cmbIdUsuario";
            this.cmbIdUsuario.Size = new System.Drawing.Size(98, 21);
            this.cmbIdUsuario.TabIndex = 5;
            this.cmbIdUsuario.Visible = false;
            this.cmbIdUsuario.SelectedIndexChanged += new System.EventHandler(this.cmbIdUsuario_SelectedIndexChanged);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(189, 26);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 6;
            this.txtDocumento.Visible = false;
            // 
            // AsignarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 236);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cmbIdUsuario);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.btnAsignarCurso);
            this.Controls.Add(this.label2);
            this.Name = "AsignarCurso";
            this.Text = "AsignarCurso";
            this.Load += new System.EventHandler(this.AsignarCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAsignarCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.ComboBox cmbIdUsuario;
        private System.Windows.Forms.TextBox txtDocumento;
    }
}