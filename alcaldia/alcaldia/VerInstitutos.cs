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
    public partial class VerInstitutos : Form
    {
        public VerInstitutos()
        {
            InitializeComponent();
        }

        int indice;
        private void VerInstitutos_Load(object sender, EventArgs e)
        {
            Instituto objInstituto = new Instituto();
            dgvInstitutos.DataSource = objInstituto.consultarInstitutos().Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvInstitutos.CurrentCell.RowIndex;
        }
    }
}
