﻿namespace alcaldia
{
    partial class VerSecretarias
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
            this.dgvSecretarias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretarias)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de secretarias :";
            // 
            // dgvSecretarias
            // 
            this.dgvSecretarias.Location = new System.Drawing.Point(12, 48);
            this.dgvSecretarias.Name = "dgvSecretarias";
            this.dgvSecretarias.Size = new System.Drawing.Size(486, 255);
            this.dgvSecretarias.TabIndex = 1;
            this.dgvSecretarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSecretarias_CellContentClick);
            // 
            // VerSecretarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 315);
            this.Controls.Add(this.dgvSecretarias);
            this.Controls.Add(this.label1);
            this.Name = "VerSecretarias";
            this.Text = "VerSecretarias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VerSecretarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecretarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSecretarias;
    }
}