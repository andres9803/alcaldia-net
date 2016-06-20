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
    public partial class CrearUsuarioEstudiante : Form
    {
        public CrearUsuarioEstudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();

            objUsuario.Nombres = txtNombres.Text;
            objUsuario.Apellidos = txtApellidos.Text;
            objUsuario.Documento = long.Parse(txtDocumento.Text);
            objUsuario.TipoDocumento = cmbTipoDocumento.Text;
            objUsuario.Telefono = long.Parse(txtTelefono.Text);
            objUsuario.Celular = long.Parse(txtCelular.Text);
            objUsuario.Direccion = txtDireccion.Text;
            objUsuario.Barrio = txtBarrio.Text;
            objUsuario.Correo = txtCorreo.Text;
            objUsuario.Clave = txtClave.Text;
            objUsuario.IdRol = long.Parse(cmbRol.SelectedValue.ToString());
            objUsuario.registrarUsuario();

            this.Close();

            CrearEstudiante objFormCrearEstudiante = new CrearEstudiante();
            objFormCrearEstudiante.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void CrearUsuarioEstudiante_Load(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            DataSet objData = new DataSet();

            cmbRol.DataSource = objUsuario.llenarRoles().Tables[0];
            cmbRol.DisplayMember = "nombre";//Muestra este campo 
            cmbRol.ValueMember = "idRol";//Guarda este campo
        }
    }
}
