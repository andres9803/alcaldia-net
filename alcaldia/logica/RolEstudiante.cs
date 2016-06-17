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

        private int calificacion;

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        public void registrarRolEstudiante()
        {
            Conexion objConexion = new Conexion();
            string sentencia = "insert into rol (calificacion) values(" + calificacion + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into  nombre (calificacion) values(" + calificacion + ")"))
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
