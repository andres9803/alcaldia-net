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
    public partial class InformeCursosCreadosSecretaria : Form
    {
        public InformeCursosCreadosSecretaria()
        {
            InitializeComponent();
        }
        int indice;
        private void InformeCursosCreadosSecretaria_Load(object sender, EventArgs e)
        {
            Usuario objUsuario = new Usuario();
            txtDocumento.Text = Sesion.documentoSesion.ToString();
            objUsuario.Documento = long.Parse(txtDocumento.Text);

            dgvCursosCreados.DataSource = objUsuario.consultarCursosCreadosPoELRolSecretaria().Tables[0];
        }

        private void dgvCursosCreados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvCursosCreados.CurrentCell.RowIndex;
        }
    }
}
