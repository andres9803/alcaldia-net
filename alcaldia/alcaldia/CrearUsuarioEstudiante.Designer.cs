namespace alcaldia
{
    partial class CrearUsuarioEstudiante
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nombres = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(364, 377);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(98, 40);
            this.btnRegistrar.TabIndex = 53;
            this.btnRegistrar.Text = "Registrar usuario";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtClave);
            this.groupBox2.Controls.Add(this.txtCorreo);
            this.groupBox2.Controls.Add(this.txtBarrio);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(303, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 310);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(35, 278);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(160, 20);
            this.txtClave.TabIndex = 39;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(35, 215);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(160, 20);
            this.txtCorreo.TabIndex = 38;
            // 
            // txtBarrio
            // 
            this.txtBarrio.Location = new System.Drawing.Point(35, 162);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(160, 20);
            this.txtBarrio.TabIndex = 37;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(35, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 20);
            this.txtDireccion.TabIndex = 36;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(35, 44);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(160, 20);
            this.txtCelular.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Clave:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Barrio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Celular:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.txtApellidos);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 310);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Nombres:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Items.AddRange(new object[] {
            "CC",
            "TI"});
            this.cmbTipoDocumento.Location = new System.Drawing.Point(27, 162);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(169, 21);
            this.cmbTipoDocumento.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tipo de documento:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(27, 278);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 20);
            this.txtTelefono.TabIndex = 34;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(27, 215);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(169, 20);
            this.txtDocumento.TabIndex = 33;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(27, 97);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(169, 20);
            this.txtApellidos.TabIndex = 32;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(27, 44);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(169, 20);
            this.txtNombres.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Documento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Apellidos:";
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(33, 388);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(241, 21);
            this.cmbRol.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Rol:";
            // 
            // Nombres
            // 
            this.Nombres.AutoSize = true;
            this.Nombres.Location = new System.Drawing.Point(74, 59);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(52, 13);
            this.Nombres.TabIndex = 48;
            this.Nombres.Text = "Nombres:";
            // 
            // CrearUsuarioEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 463);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nombres);
            this.Name = "CrearUsuarioEstudiante";
            this.Text = "Crear usuario estudiante";
            this.Load += new System.EventHandler(this.CrearUsuarioEstudiante_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nombres;
    }
}