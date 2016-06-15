using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;
using System.Windows.Forms;
namespace logica
{
    public class Rol
    {
        private int idRol;
        private string nombre;

        public int IdRol
        {
            get
            {
                return idRol;
            }

            set
            {
                idRol = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public void registrarCliente()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into cliente (nombre) values('" + Nombre +"')";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  cliente (nombre) values('" + Nombre + "'')"))
            {
                MessageBox.Show("Cliente registrado correctamente");
            }
            else
            {
                MessageBox.Show("Cliente no Registrado");
            }

        }
    }
}
