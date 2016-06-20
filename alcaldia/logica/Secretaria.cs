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
    public class Secretaria
    {

        private string nombre;
        private string direccion;
        private long telefono;
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



        public long IdAlcaldia
        {
            get { return idAlcaldia; }
            set { idAlcaldia = value; }
        }

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
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

        public DataSet llenarSecretarias()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from secretaria";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void registrarSecretaria()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into secetaria (nombre,direccion,telefono,idAlcaldia) values('" + nombre + "','" + direccion + "'," + Telefono + ", " + idAlcaldia + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into secretaria (nombre,direccion,telefono,idAlcaldia) values('" + nombre + "','" + direccion + "'," + Telefono + "," + idAlcaldia + ")"))
            {
                MessageBox.Show("Secretaria registrada correctamente");
            }
            else
            {
                MessageBox.Show("Secretaria no registrada");
            }
        }

        public DataSet consultarSecretarias()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("select * from secretaria");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }

            return ds;
        }
    }
}
