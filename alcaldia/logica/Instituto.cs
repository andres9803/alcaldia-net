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
    public class Instituto
    {

        private string nombre;
        private string direccion;
        private string telefono;
        private long idAlcaldia;

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

        public long IdAlcaldia
        {
            get { return idAlcaldia; }
            set { idAlcaldia = value; }
        }

        public DataSet llenarAlcaldias()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from alcaldia";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void registrarCurso()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into instituto (nombre,direccion,telefono,idAlcaldia) values('" + nombre + "','" + direccion + "'," + telefono + "," + idAlcaldia + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into instituto (nombre,direccion,telefono,idAlcaldia) values('" + nombre + "','" + direccion + "'," + telefono + "," + idAlcaldia + "')"))
            {
                MessageBox.Show("Instituto registrado correctamente");
            }
            else
            {
                MessageBox.Show("Instituto no registrado");
            }

        }
    }
}
