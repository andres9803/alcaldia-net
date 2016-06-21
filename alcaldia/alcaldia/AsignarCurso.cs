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
    public partial class AsignarCurso : Form
    {
        public AsignarCurso()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsignarCurso_Load(object sender, EventArgs e)
        {
            DataSet objData = new DataSet();

            EstudianteCurso objEstudianteCurso = new EstudianteCurso();
            txtDocumento.Text = Sesion.documentoSesion.ToString();
            objEstudianteCurso.Documento = long.Parse(txtDocumento.Text);
           
            cmbIdUsuario.DataSource = objEstudianteCurso.traerIdRolEstudiante().Tables[0];
            cmbIdUsuario.DisplayMember = "idRolEstudiante";//Muestra este campo 
            cmbIdUsuario.ValueMember = "idRolEstudiante";//Guarda este campo

            Curso objCurso = new Curso();
            cmbCurso.DataSource = objCurso.llenarCurso().Tables[0];
            cmbCurso.DisplayMember = "nombre";//Muestra este campo 
            cmbCurso.ValueMember = "idCurso";//Guarda este campo       

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarCurso_Click(object sender, EventArgs e)
        {
            EstudianteCurso objEstudianteCurso = new EstudianteCurso();
          
            objEstudianteCurso.IdRolEstudiante = long.Parse(cmbIdUsuario.SelectedValue.ToString()); ;
            objEstudianteCurso.IdCurso= long.Parse(cmbCurso.SelectedValue.ToString());
            objEstudianteCurso.registrarEntudianteCurso();
        }

        private void cmbIdUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
