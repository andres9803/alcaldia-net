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
    public class Rol
    {
        private int idRol;
        private string nombre;

        public int IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public void registrarRol()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into rol (nombre) values('" + Nombre + "')";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  nombre (nombre) values('" + Nombre + "'')"))
            {
                MessageBox.Show("Rol registrado correctamente");
            }
            else
            {
                MessageBox.Show("Rol no Registrado");
            }

        }
    }
}
