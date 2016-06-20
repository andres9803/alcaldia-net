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
    public partial class VerSecretarias : Form
    {
        public VerSecretarias()
        {
            InitializeComponent();
        }
        int indice;
        private void dgvSecretarias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvSecretarias.CurrentCell.RowIndex;
        }

        private void VerSecretarias_Load(object sender, EventArgs e)
        {
            Secretaria objSecretaria = new Secretaria();
            dgvSecretarias.DataSource = objSecretaria.consultarSecretarias().Tables[0];
        }
    }
}
