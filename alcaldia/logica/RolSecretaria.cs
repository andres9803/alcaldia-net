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
    public class RolSecretaria
    {

        private string codigo;
        private long idsecretaria;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public long Idsecretaria
        {
            get { return idsecretaria; }
            set { idsecretaria = value; }
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

        public void registrarRolSecretaria()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into rolSecretaria (codigo,idSecretaria) values('" + codigo + "','" + idsecretaria + "')";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into rolSecretaria (codigo,idSecretaria) values('" + codigo + "','" + idsecretaria + "')"))
            {
                MessageBox.Show("Usuario de secretaria registrado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario de secretaria no registrado");
            }

        }
    }
}
