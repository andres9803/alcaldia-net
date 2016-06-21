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
    public partial class VerAsistencias : Form
    {
        public VerAsistencias()
        {
            InitializeComponent();
        }
        int indice;

        private void VerAsistencias_Load(object sender, EventArgs e)
        {
            Asistencia objAsistencia = new Asistencia();
            dgvAsistencia.DataSource = objAsistencia.consultarAsistencias().Tables[0];
        }

        private void dgvAsistencia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvAsistencia.CurrentCell.RowIndex;
        }
    }
}
