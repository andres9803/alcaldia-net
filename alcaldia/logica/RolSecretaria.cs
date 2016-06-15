using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class RolSecretaria
    {

        private string codigo;
        private long idUsecretaria;

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public long IdUsecretaria
        {
            get
            {
                return idUsecretaria;
            }

            set
            {
                idUsecretaria = value;
            }
        }
    }
}
