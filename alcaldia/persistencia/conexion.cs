using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace persistencia
{
    public class Conexion
    {
        SqlConnection conexion;//Cadena Conexion
        SqlCommand comando;// ejecutar insert, delete o update 
        SqlDataAdapter adaptador;//ejecutar un consulta
        DataSet ds;//almacenar la info de la consulta

        public void conectar()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-60EH57K\\SQLEXPRESS;Initial Catalog=alcaldia;Integrated Security=True");
                conexion.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        public void desconectar()
        {
            conexion.Close();
        }

        public bool ejecutar(string sentencia)
        {
            conectar();
            bool verificar = false;
            comando = new SqlCommand();
            try
            {
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                comando.ExecuteNonQuery();//Ejecutar la sentencia
                verificar = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                verificar = false;
            }
            desconectar();
            return verificar;

        }

        public DataSet consultar(string sentencia)
        {
            conectar();
            ds = new DataSet();
            try
            {
                adaptador = new SqlDataAdapter(sentencia, conexion);
                adaptador.Fill(ds);
            }
            catch (SqlException ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            desconectar();
            return ds;

        }

    }
}
