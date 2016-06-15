using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Curso
    {

        private string descripcion;
        private string horario;
        private DateTime fechaInicial;
        private DateTime fechaFinal;
        private long valor;
        private int totalHoras;
        private int maximoAsistentes;
        private DateTime fechaInicialInscripciones;
        private DateTime fechaFinalInscripciones;
        private long idInstituto;

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Horario
        {
            get
            {
                return horario;
            }

            set
            {
                horario = value;
            }
        }

        public DateTime FechaInicial
        {
            get
            {
                return fechaInicial;
            }

            set
            {
                fechaInicial = value;
            }
        }

        public DateTime FechaFinal
        {
            get
            {
                return fechaFinal;
            }

            set
            {
                fechaFinal = value;
            }
        }

        public long Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public int TotalHoras
        {
            get
            {
                return totalHoras;
            }

            set
            {
                totalHoras = value;
            }
        }

        public int MaximoAsistentes
        {
            get
            {
                return maximoAsistentes;
            }

            set
            {
                maximoAsistentes = value;
            }
        }

        public DateTime FechaInicialInscripciones
        {
            get
            {
                return fechaInicialInscripciones;
            }

            set
            {
                fechaInicialInscripciones = value;
            }
        }

        public DateTime FechaFinalInscripciones
        {
            get
            {
                return fechaFinalInscripciones;
            }

            set
            {
                fechaFinalInscripciones = value;
            }
        }

        public long IdInstituto
        {
            get
            {
                return idInstituto;
            }

            set
            {
                idInstituto = value;
            }
        }
    }
}
