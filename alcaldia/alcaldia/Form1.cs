using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using logica;

namespace alcaldia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            objUsuario.Documento = long.Parse(txtDocumento.Text);
            objUsuario.Clave = txtClave.Text;
            DataSet ds = new DataSet();
            ds = objUsuario.iniciarSesion();
            if (ds.Tables[0].Rows.Count > 0)
            {

                Sesion.documentoSesion = long.Parse(ds.Tables[0].Rows[0][0].ToString());
                Sesion.nombreSesion = ds.Tables[0].Rows[0][1].ToString();
                Sesion.rolSesion = ds.Tables[0].Rows[0][2].ToString();
                Sesion.claveSesion = txtClave.Text;
                Menu menu = new Menu();
                menu.ShowDialog();
                Form1 login = new Form1();
                login.Hide();

                //cerrarVentanaLogin();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos");
            }
        }

        public void cerrarVentanaLogin()
        {
            //this.Close();
            Form1 login = new Form1();
            login.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            CrearUsuarioEstudiante crearEstudiante = new CrearUsuarioEstudiante();
            crearEstudiante.ShowDialog();
            Form1 login = new Form1();
            login.Hide();
        }
    }
}

