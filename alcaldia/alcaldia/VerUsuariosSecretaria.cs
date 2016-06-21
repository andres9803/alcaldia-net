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
    public partial class VerUsuariosSecretaria : Form
    {
        public VerUsuariosSecretaria()
        {
            InitializeComponent();
        }
        int indice;
        private void VerUsuariosSecretaria_Load(object sender, EventArgs e)
        {
            RolSecretaria objSecretarias = new RolSecretaria();
            dgvSecretarias.DataSource = objSecretarias.consultarSecretarias().Tables[0];
        }

        private void dgvSecretarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvSecretarias.CurrentCell.RowIndex;
        }
    }
}
