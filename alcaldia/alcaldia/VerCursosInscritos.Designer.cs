namespace alcaldia
{
    partial class VerCursosInscritos
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
            this.dgvCursosInscritos = new System.Windows.Forms.DataGridView();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbIdUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosInscritos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosInscritos
            // 
            this.dgvCursosInscritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCursosInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosInscritos.Location = new System.Drawing.Point(13, 39);
            this.dgvCursosInscritos.Name = "dgvCursosInscritos";
            this.dgvCursosInscritos.Size = new System.Drawing.Size(608, 306);
            this.dgvCursosInscritos.TabIndex = 1;
            this.dgvCursosInscritos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(417, 13);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.Visible = false;
            // 
            // cmbIdUsuario
            // 
            this.cmbIdUsuario.FormattingEnabled = true;
            this.cmbIdUsuario.Location = new System.Drawing.Point(523, 12);
            this.cmbIdUsuario.Name = "cmbIdUsuario";
            this.cmbIdUsuario.Size = new System.Drawing.Size(98, 21);
            this.cmbIdUsuario.TabIndex = 7;
            this.cmbIdUsuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Listado de cursos en los que me encuentro registrado:";
            // 
            // VerCursosInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cmbIdUsuario);
            this.Controls.Add(this.dgvCursosInscritos);
            this.Name = "VerCursosInscritos";
            this.Text = "VerCursosInscritos";
            this.Load += new System.EventHandler(this.VerCursosInscritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosInscritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCursosInscritos;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cmbIdUsuario;
        private System.Windows.Forms.Label label1;
    }
}