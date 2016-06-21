namespace alcaldia
{
    partial class VerAlcaldias
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
            this.dtgAlcaldias = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlcaldias)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAlcaldias
            // 
            this.dtgAlcaldias.AllowDrop = true;
            this.dtgAlcaldias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAlcaldias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAlcaldias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlcaldias.Location = new System.Drawing.Point(12, 50);
            this.dtgAlcaldias.Name = "dtgAlcaldias";
            this.dtgAlcaldias.Size = new System.Drawing.Size(697, 288);
            this.dtgAlcaldias.TabIndex = 0;
            this.dtgAlcaldias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlcaldias_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de alcaldias:";
            // 
            // VerAlcaldias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(721, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgAlcaldias);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "VerAlcaldias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerAlcaldias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VerAlcaldias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlcaldias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAlcaldias;
        private System.Windows.Forms.Label label1;
    }
}