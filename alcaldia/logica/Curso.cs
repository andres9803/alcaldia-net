﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using persistencia;
using System.Windows.Forms;
using System.Data;

namespace logica
{
    public class Curso
    {
        private string nombre;
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
        private int valoracionCurso;
        private long documento;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Horario
        {
            get { return horario; }
            set { horario = value; }
        }

        public DateTime FechaInicial
        {
            get { return fechaInicial; }
            set { fechaInicial = value; }
        }

        public DateTime FechaFinal
        {
            get { return fechaFinal; }
            set { fechaFinal = value; }
        }

        public long Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public int TotalHoras
        {
            get { return totalHoras; }
            set { totalHoras = value; }
        }

        public int MaximoAsistentes
        {
            get { return maximoAsistentes; }
            set { maximoAsistentes = value; }
        }

        public DateTime FechaInicialInscripciones
        {
            get { return fechaInicialInscripciones; }
            set { fechaInicialInscripciones = value; }
        }

        public DateTime FechaFinalInscripciones
        {
            get { return fechaFinalInscripciones; }
            set { fechaFinalInscripciones = value; }
        }

        public long IdInstituto
        {
            get { return idInstituto; }
            set { idInstituto = value; }
        }

        public int ValoracionCurso
        {
            get { return valoracionCurso; }
            set { valoracionCurso = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Documento
        {
            get { return documento; }
            set { documento = value; }
        }

        public DataSet llenarInstitutos()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from instituto";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet llenarCurso()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from curso";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void registrarCurso()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into curso (nombre,descripcion,horario,fechaInicial,fechaFinal,valor,totalHoras,maximoAsistentes,fechaInicialInscripciones,fechaFinalInscripciones,idInstituto,documento) values('" + nombre + "','" + descripcion + "','" + horario + "','" + fechaInicial + "','" + fechaFinal + "'," + valor + "," + totalHoras + "," + maximoAsistentes + ",'" + FechaFinalInscripciones + "','" + FechaFinalInscripciones + "'," + idInstituto + "," + documento + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into curso (nombre,descripcion,horario,fechaInicial,fechaFinal,valor,totalHoras,maximoAsistentes,fechaInicialInscripciones,fechaFinalInscripciones,idInstituto,documento) values('" + nombre + "','" + descripcion + "','" + horario + "','" + fechaInicial + "','" + fechaFinal + "'," + valor + "," + totalHoras + "," + maximoAsistentes + ",'" + FechaFinalInscripciones + "','" + FechaFinalInscripciones + "'," + idInstituto + "," + documento + ")"))
            {
                MessageBox.Show("Curso registrado correctamente");
            }
            else
            {
                MessageBox.Show("Curso no registrado");
            }
        }

        public DataSet consultarCursos()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("select * from curso");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }
            
            return ds;
        }

      
    }
}
