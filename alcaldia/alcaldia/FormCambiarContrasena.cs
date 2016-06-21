using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace alcaldia
{
    public partial class FormCambiarContrasena : Form
    {
        public FormCambiarContrasena()
        {
            InitializeComponent();
        }

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("¿Esta seguro de cambiar la contraseña?", "Cambiar contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogo == DialogResult.Yes)
            {
                Usuario objUsuario = new Usuario();
                objUsuario.Documento = long.Parse(txtDocumento.Text);
                objUsuario.Clave = txtClave.Text;
                objUsuario.cambiarContrasena();
                //objUsuario.IdEstablecimiento = int.Parse(cmbEstablecimientos.SelectedValue.ToString());
                //objUsuario. ();

                //this.Close();


            }
        }

        private void FormCambiarContrasena_Load(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            // objUsuario.Documento = long.Parse(Sesion.documentoSesion.ToString());
            txtDocumento.Text = Sesion.documentoSesion.ToString();
            txtClave.Text = Sesion.claveSesion;
        }

        private void documento_Click(object sender, EventArgs e)
        {
            
        }
    }
}
