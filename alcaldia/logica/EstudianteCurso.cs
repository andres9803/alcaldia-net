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
    public class EstudianteCurso
    {

        private long idRolEstudiante;
        private long idCurso;
        private long documento;
        private int valoracionCurso;

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

        public long Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public int ValoracionCurso
        {
            get { return valoracionCurso; }
            set { valoracionCurso = value; }
        }

        public void registrarEntudianteCurso()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into estudiantesCurso (idRolEstudiante,idCurso) values(" + idRolEstudiante + "," + IdCurso + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into estudiantesCurso (idRolEstudiante,idCurso) values(" + idRolEstudiante + "," + IdCurso + ")"))
            {
                MessageBox.Show("Usted fue asignado correctamente a este curso");
            }
            else
            {
                MessageBox.Show("no se pudo asignar a este curso");
            }
        }

        public DataSet traerIdRolEstudiante()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "SELECT rolEstudiante.idRolEstudiante  FROM rolEstudiante INNER JOIN usuario on rolEstudiante.idRolEstudiante = usuario.idUsuario WHERE usuario.documento=" + documento + "";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet consultarCursosInscrito()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("SELECT curso.nombre, curso.descripcion, curso.horario, curso.fechaInicial, curso.fechaFinal, curso.totalHoras, curso.valor FROM estudiantesCurso INNER JOIN curso on curso.idCurso = estudiantesCurso.idCurso  WHERE estudiantesCurso.idRolEstudiante= " + idRolEstudiante + " ");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }

            return ds;
        }

        public void calificarCurso()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "UPDATE  estudiantesCurso  SET  valoracionCurso=" + valoracionCurso + " WHERE idCurso=" + idCurso + "";


            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("UPDATE  estudiantesCurso  SET  valoracionCurso = " + valoracionCurso + " WHERE idCurso = " + idCurso + ""))
            {
                MessageBox.Show("Curso calificado correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo calificar el curso");
            }

        }
    }
}
