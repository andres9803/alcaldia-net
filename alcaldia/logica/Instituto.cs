using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public long IdAlcaldia
        {
            get
            {
                return idAlcaldia;
            }

            set
            {
                idAlcaldia = value;
            }
        }
    }
}
