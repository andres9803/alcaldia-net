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
    public class Asistencia
    {

        private DateTime fecha;
        private long idRolEstudiante;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public long IdRolEstudiante
        {
            get { return idRolEstudiante; }
            set { idRolEstudiante = value; }
        }

        public DataSet llenarRolEstudiantes()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from rolEstudiante";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void registrarAsistencia()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into asistencia (fecha,idRolEstudiante) values('" + fecha + "',"+idRolEstudiante+")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  asistencia (fecha,idRolEstudiante) values('" + fecha + "'," + idRolEstudiante + ")"))
            {
                MessageBox.Show("Asistencia registrada correctamente");
            }
            else
            {
                MessageBox.Show("Asistencia no Registrada");
            }

        }
    }
}
