using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Asistencia
    {

        private DateTime fecha;
        private long idRolEstudiante;

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public long IdRolEstudiante
        {
            get
            {
                return idRolEstudiante;
            }

            set
            {
                idRolEstudiante = value;
            }
        }
    }
}
