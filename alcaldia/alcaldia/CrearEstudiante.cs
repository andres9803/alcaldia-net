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
    public partial class CrearEstudiante : Form
    {
        public CrearEstudiante()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RolEstudiante objRolEstudiante = new RolEstudiante();

            objRolEstudiante.IdRolEstudiante = long.Parse(cmbId.SelectedValue.ToString());
            objRolEstudiante.registrarRolEstudiante();
            this.Close();
        }

        private void CrearEstudiante_Load(object sender, EventArgs e)
        {
           Usuario objUsuario = new Usuario();

            cmbId.DataSource = objUsuario.traerId().Tables[0];
            cmbId.DisplayMember = "idUsuario";
            cmbId.ValueMember = "idUsuario";
        }
    }
}
