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
    public partial class VerCursos : Form
    {
        public VerCursos()
        {
            InitializeComponent();
        }
        int indice;
        private void VerCursos_Load(object sender, EventArgs e)
        {
            Curso objAlcaldia = new Curso();
            dgvCursos.DataSource = objAlcaldia.consultarCursos().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvCursos.CurrentCell.RowIndex;
        }
    }
}
