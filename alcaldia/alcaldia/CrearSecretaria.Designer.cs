namespace alcaldia
{
    partial class CrearSecretaria
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cmbSecretaria = new System.Windows.Forms.ComboBox();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(37, 157);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(214, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Secretaria:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(90, 280);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(119, 32);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar secretaria";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cmbSecretaria
            // 
            this.cmbSecretaria.FormattingEnabled = true;
            this.cmbSecretaria.Location = new System.Drawing.Point(37, 224);
            this.cmbSecretaria.Name = "cmbSecretaria";
            this.cmbSecretaria.Size = new System.Drawing.Size(214, 21);
            this.cmbSecretaria.TabIndex = 7;
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(37, 75);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(214, 21);
            this.cmbId.TabIndex = 8;
            // 
            // CrearSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 360);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.cmbSecretaria);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Rol secretaria";
            this.Load += new System.EventHandler(this.CrearSecretaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cmbSecretaria;
        private System.Windows.Forms.ComboBox cmbId;
    }
}