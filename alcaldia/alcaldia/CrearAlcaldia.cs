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
    public partial class CrearAlcaldia : Form
    {
        public CrearAlcaldia()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alcaldia objAlcaldia = new Alcaldia();

            objAlcaldia.Nombre = txtNombre.Text;
            objAlcaldia.Direccion = txtDireccion.Text;
            objAlcaldia.Telefono = long.Parse(txtTelefono.Text);
            objAlcaldia.registrarAlcaldia();
            this.Close();
        }

        private void CrearAlcaldia_Load(object sender, EventArgs e)
        {

        }
    }
}
