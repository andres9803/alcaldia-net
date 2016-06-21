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
        private long telefono;

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

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public void registrarAlcaldia()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into alcaldia (nombre,direccion,telefono) values('" + nombre + "','" + direccion + "'," + Telefono + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into alcaldia (nombre,direccion,telefono) values('" + nombre + "','" + direccion + "'," + Telefono + ")"))
            {
                MessageBox.Show("Alcaldia registrada correctamente");
            }
            else
            {
                MessageBox.Show("Alcaldia no registrada");
            }

        }

        public DataSet llenarAlcaldia()
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

        public DataSet consultarAlcaldias()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("select * from alcaldia");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }

            return ds;
        }
    }
}
