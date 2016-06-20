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
    public partial class CrearInstituto : Form
    {
        public CrearInstituto()
        {
            InitializeComponent();
        }

        private void CrearInstituto_Load(object sender, EventArgs e)
        {
            Alcaldia objSecretaria = new Alcaldia();
            DataSet objData = new DataSet();

            cmbAlcaldia.DataSource = objSecretaria.llenarAlcaldia().Tables[0];
            cmbAlcaldia.DisplayMember = "nombre";//Muestra este campo 
            cmbAlcaldia.ValueMember = "idAlcaldia";//Guarda este campo
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Instituto objInstituto = new Instituto();

            objInstituto.Nombre = txtNombre.Text;
            objInstituto.Direccion = txtDireccion.Text;
            objInstituto.Telefono = long.Parse(txtTelefono.Text);
            objInstituto.IdAlcaldia =long.Parse(cmbAlcaldia.SelectedValue.ToString());
            objInstituto.registrarInstituto();
            this.Close();
        }
    }
}
