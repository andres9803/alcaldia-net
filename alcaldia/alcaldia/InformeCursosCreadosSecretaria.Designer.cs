namespace alcaldia
{
    partial class InformeCursosCreadosSecretaria
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
            this.dgvCursosCreados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosCreados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosCreados
            // 
            this.dgvCursosCreados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosCreados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosCreados.Location = new System.Drawing.Point(13, 46);
            this.dgvCursosCreados.Name = "dgvCursosCreados";
            this.dgvCursosCreados.Size = new System.Drawing.Size(513, 259);
            this.dgvCursosCreados.TabIndex = 0;
            this.dgvCursosCreados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursosCreados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de cursos creados ";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(323, 12);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(203, 20);
            this.txtDocumento.TabIndex = 26;
            this.txtDocumento.Visible = false;
            // 
            // InformeCursosCreadosSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 317);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCursosCreados);
            this.Name = "InformeCursosCreadosSecretaria";
            this.Text = "InformeCursosCreadosSecretaria";
            this.Load += new System.EventHandler(this.InformeCursosCreadosSecretaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosCreados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursosCreados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumento;
    }
}