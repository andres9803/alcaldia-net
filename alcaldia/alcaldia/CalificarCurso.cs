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
    public partial class CalificarCurso : Form
    {
        public CalificarCurso()
        {
            InitializeComponent();
        }

        private void CalificarCurso_Load(object sender, EventArgs e)
        {
            Curso objCurso = new Curso();
            cmbCurso.DataSource = objCurso.llenarCurso().Tables[0];
            cmbCurso.DisplayMember = "nombre";//Muestra este campo 
            cmbCurso.ValueMember = "idCurso";//Guarda este campo 
        }

        private void btnCalificar_Click(object sender, EventArgs e)
        {
            EstudianteCurso objEstudiantecurso = new EstudianteCurso();
            objEstudiantecurso.IdCurso = long.Parse(cmbCurso.SelectedValue.ToString());
            objEstudiantecurso.ValoracionCurso = int.Parse(txtCalificacion.Text);
            objEstudiantecurso.calificarCurso();
        }
    }
}
