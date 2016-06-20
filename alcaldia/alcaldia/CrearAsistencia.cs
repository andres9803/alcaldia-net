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
    public partial class CrearAsistencia : Form
    {
        public CrearAsistencia()
        {
            InitializeComponent();
        }

        private void CrearAsistencia_Load(object sender, EventArgs e)
        {
            Asistencia objEstudiante = new Asistencia();
            DataSet objData = new DataSet();

            cmbEstudiante.DataSource = objEstudiante.llenarRolEstudiantes().Tables[0];
            cmbEstudiante.DisplayMember = "idRolEstudiante";//Muestra este campo 
            cmbEstudiante.ValueMember = "idRolEstudiante";//Guarda este campo
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Asistencia objAsistencia = new Asistencia();

            objAsistencia.Fecha = DateTime.Parse(txtFecha.Text);
            objAsistencia.IdRolEstudiante = long.Parse(cmbEstudiante.SelectedValue.ToString());           
            objAsistencia.registrarAsistencia();
            this.Close();
        }
    }
}
