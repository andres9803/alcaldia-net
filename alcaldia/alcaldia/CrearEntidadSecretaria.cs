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
    public partial class CrearEntidadSecretaria : Form
    {
        public CrearEntidadSecretaria()
        {
            InitializeComponent();
        }

        private void CrearEntidadSecretaria_Load(object sender, EventArgs e)
        {
            Alcaldia objSecretaria = new Alcaldia();
            DataSet objData = new DataSet();

            cmbAlcaldia.DataSource = objSecretaria.llenarAlcaldia().Tables[0];
            cmbAlcaldia.DisplayMember = "nombre";//Muestra este campo 
            cmbAlcaldia.ValueMember = "idAlcaldia";//Guarda este campo
        }

        private void btnRegistrarSecretaria_Click(object sender, EventArgs e)
        {
            Secretaria objSecretaria = new Secretaria();

            objSecretaria.Nombre = txtNombre.Text;
            objSecretaria.Direccion = txtDireccion.Text;
            objSecretaria.Telefono = long.Parse(txtTelefono.Text);
            objSecretaria.IdAlcaldia = long.Parse(cmbAlcaldia.SelectedValue.ToString());
            objSecretaria.registrarSecretaria();
            this.Close();
        }
    }
}
