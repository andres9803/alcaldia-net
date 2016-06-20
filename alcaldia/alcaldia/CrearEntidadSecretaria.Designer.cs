namespace alcaldia
{
    partial class CrearEntidadSecretaria
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarSecretaria = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cmbAlcaldia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alcaldia:";
            // 
            // btnRegistrarSecretaria
            // 
            this.btnRegistrarSecretaria.Location = new System.Drawing.Point(107, 226);
            this.btnRegistrarSecretaria.Name = "btnRegistrarSecretaria";
            this.btnRegistrarSecretaria.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarSecretaria.TabIndex = 4;
            this.btnRegistrarSecretaria.Text = "Registrar";
            this.btnRegistrarSecretaria.UseVisualStyleBackColor = true;
            this.btnRegistrarSecretaria.Click += new System.EventHandler(this.btnRegistrarSecretaria_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(38, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(38, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(194, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(38, 143);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(194, 20);
            this.txtTelefono.TabIndex = 7;
            // 
            // cmbAlcaldia
            // 
            this.cmbAlcaldia.FormattingEnabled = true;
            this.cmbAlcaldia.Location = new System.Drawing.Point(38, 192);
            this.cmbAlcaldia.Name = "cmbAlcaldia";
            this.cmbAlcaldia.Size = new System.Drawing.Size(194, 21);
            this.cmbAlcaldia.TabIndex = 8;
            // 
            // CrearEntidadSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbAlcaldia);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnRegistrarSecretaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearEntidadSecretaria";
            this.Text = "Crear Secretariá";
            this.Load += new System.EventHandler(this.CrearEntidadSecretaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarSecretaria;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cmbAlcaldia;
    }
}