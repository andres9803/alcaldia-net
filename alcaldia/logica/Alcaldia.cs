using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;
using System.Windows.Forms;
using System.Data;

namespace logica
{
    public class Alcaldia
    {

        private string nombre;
        private string direccion;
        private string telefono;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public void registrarAlcaldia()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into alcaldia (nombre,direccion,telefono) values('" + nombre + "','" + direccion + "'," + telefono + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into alcaldia (nombre,direccion,telefono) values('" + nombre + "','" + direccion + "'," + telefono + "')"))
            {
                MessageBox.Show("Alcaldia registrada correctamente");
            }
            else
            {
                MessageBox.Show("Alcaldia no registrada");
            }

        }
    }
}
