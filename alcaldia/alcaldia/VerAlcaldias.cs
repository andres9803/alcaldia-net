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
    public partial class VerAlcaldias : Form
    {
        public VerAlcaldias()
        {
            InitializeComponent();
        }

        int indice;
        private void VerAlcaldias_Load(object sender, EventArgs e)
        {
            Alcaldia objAlcaldia = new Alcaldia();
            dtgAlcaldias.DataSource = objAlcaldia.consultarAlcaldias().Tables[0];
        }

        private void dtgAlcaldias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dtgAlcaldias.CurrentCell.RowIndex;
        }
    }
}
