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
    public partial class VerCursosInscritos : Form
    {
        public VerCursosInscritos()
        {
            InitializeComponent();
        }

        int indice;

        private void VerCursosInscritos_Load(object sender, EventArgs e)
        {
            DataSet objData = new DataSet();

            EstudianteCurso objEstudianteCurso = new EstudianteCurso();
            txtDocumento.Text = Sesion.documentoSesion.ToString();
            objEstudianteCurso.Documento = long.Parse(txtDocumento.Text);

            cmbIdUsuario.DataSource = objEstudianteCurso.traerIdRolEstudiante().Tables[0];
            cmbIdUsuario.DisplayMember = "idRolEstudiante";//Muestra este campo 
            cmbIdUsuario.ValueMember = "idRolEstudiante";//Guarda este campo

            objEstudianteCurso.IdRolEstudiante = long.Parse(cmbIdUsuario.SelectedValue.ToString());

            dgvCursosInscritos.DataSource = objEstudianteCurso.consultarCursosInscrito().Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvCursosInscritos.CurrentCell.RowIndex;
        }
    }
}
