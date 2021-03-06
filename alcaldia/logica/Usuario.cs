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
    public class Usuario
    {

        private string nombres;
        private string apellidos;
        private long documento;
        private string tipoDocumento;
        private long telefono;
        private long celular;
        private string direccion;
        private string barrio;
        private string correo;
        private string clave;
        private long idRol;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public long Documento
        {
            get { return documento; }
            set { documento = value; }
        }

     

        public long Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public long Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Barrio
        {
            get { return barrio; }
            set { barrio = value; }
        }

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public long IdRol
        {
            get { return idRol; }
            set { idRol = value; }
        }

        public string TipoDocumento
        {
            get
            {
                return tipoDocumento;
            }

            set
            {
                tipoDocumento = value;
            }
        }

        public DataSet llenarRoles()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "select * from rol";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void registrarUsuario()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "insert into usuario(nombres,apellidos,documento,tipoDocumento,telefono,celular,direccion,barrio,correo,clave,idRol) values('" + nombres + "','" + apellidos + "'," + documento + ",'" + tipoDocumento + "'," + telefono + "," + celular + ",'" + direccion + "','" + barrio + "','" + correo + "','" + clave + "'," + idRol + ")";

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("insert into usuario(nombres,apellidos,documento,tipoDocumento,telefono,celular,direccion,barrio,correo,clave,idRol) values('" + nombres + "', '" + apellidos + "'," + documento + ",'" + tipoDocumento + "'," + telefono + "," + celular + ",'" + direccion + "','" + barrio + "','" + correo + "','" + clave + "'," + idRol + ")"))
            {
                MessageBox.Show("Usuario registrado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }

        }

        public void cambiarContrasena()
        {

            Conexion objConexion = new Conexion();
            string sentencia = "UPDATE  usuario  SET  clave='" + clave + "' WHERE documento=" + documento + "";
            

            MessageBox.Show(sentencia);

            if (objConexion.ejecutar("UPDATE  usuario  SET  clave='" + clave + "' WHERE documento=" + documento + ""))
            {
                MessageBox.Show("Contraseña modificada correctamente");
            }
            else
            {
                MessageBox.Show("la contraseña no se pudo modificar");
            }

        }

        public DataSet iniciarSesion()
        {
            Conexion objConexion = new Conexion();
            DataSet ds = new DataSet();
            ds = objConexion.consultar("SELECT usuario.documento , usuario.nombres , rol.nombre FROM usuario INNER JOIN rol ON  rol.idRol = usuario.idRol WHERE usuario.documento =" + documento + " AND usuario.clave = '" + clave + "'");
          
            return ds;
        }

        public DataSet traerId()
        {
            try
            {
                Conexion objConexion = new Conexion();
                string consulta = "SELECT TOP 1 usuario.idUsuario FROM usuario ORDER BY idUsuario DESC;";
                DataSet data = new DataSet();
                data = objConexion.consultar(consulta);

                return data;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public DataSet consultarCursosCreadosPoELRolSecretaria()
        {
            DataSet ds = new DataSet();
            Conexion objConexion = new Conexion();
            ds = objConexion.consultar("select curso.nombre, curso.descripcion, curso.horario, curso.fechaInicial, curso.fechaFinal, curso.totalHoras, curso.valor from curso where curso.documento = " + documento+"");
            if (ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("No exinten registros");
            }

            return ds;
        }
    }
}
