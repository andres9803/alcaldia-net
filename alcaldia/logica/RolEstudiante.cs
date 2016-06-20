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
    public class RolEstudiante
    {
        private long idRolEstudiante;
        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public long IdRolEstudiante
        {
            get { return idRolEstudiante; }
            set { idRolEstudiante = value; }
        }

        public void registrarRolEstudiante()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into rolEstudiante (idRolEstudiante) values(" + idRolEstudiante + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into rolEstudiante (idRolEstudiante) values(" + idRolEstudiante + ")"))
            {
                MessageBox.Show("Usuario estudiante registrado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario estudiante no Registrado");
            }

        }
    }
}
