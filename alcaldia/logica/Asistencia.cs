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
        private long idCurso;

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

        public long IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
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
            string sentencia = "insert into asistencia (fecha,idRolEstudiante,idCurso) values('" + fecha + "'," + idRolEstudiante + "," + idCurso + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  asistencia (fecha,idRolEstudiante,idCurso) values('" + fecha + "'," + idRolEstudiante + "," + idCurso + ")"))
            {
                MessageBox.Show("Asistencia registrada correctamente");
            }
            else
            {
                MessageBox.Show("Asistencia no Registrada");
            }
        }

        public DataSet consultarAsistencias()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("select * from asistencia");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }

            return ds;
        }
    }
}
