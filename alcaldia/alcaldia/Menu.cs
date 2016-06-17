using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

namespace alcaldia
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void crearSecretariasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void imprimirCertificadosDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (Sesion.rolSesion == "Admon")
            {
                menuStrip1.Visible = true;
            }
        }
    }
}
