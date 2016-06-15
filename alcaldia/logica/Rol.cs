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
        

        public void registrarCliente()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into cliente (nombre,apellido,direccion,telefono) values('" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "')";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  cliente (nombre,apellido,direccion,telefono) values('" + nombre + "','" + apellido + "','" + direccion + "','" + telefono + "')"))
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
