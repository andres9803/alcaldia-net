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
    public partial class CrearSecretaria : Form
    {
        public CrearSecretaria()
        {
            InitializeComponent();
        }

        private void CrearSecretaria_Load(object sender, EventArgs e)
        {
            Secretaria objSecretaria = new Secretaria();
            DataSet objData = new DataSet();

            cmbSecretaria.DataSource = objSecretaria.llenarSecretarias().Tables[0];
            cmbSecretaria.DisplayMember = "nombre";//Muestra este campo 
            cmbSecretaria.ValueMember = "idSecretaria";//Guarda este campo

            Usuario objUsuario = new Usuario();

            cmbId.DataSource = objUsuario.traerId().Tables[0];
            cmbId.DisplayMember = "idUsuario";
            cmbId.ValueMember = "idUsuario";

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RolSecretaria objRolSecretaria = new RolSecretaria();

            objRolSecretaria. IdRolSecretaria = long.Parse(cmbId.SelectedValue.ToString());
            objRolSecretaria.Codigo = txtCodigo.Text;
            objRolSecretaria.Idsecretaria = long.Parse(cmbSecretaria.SelectedValue.ToString());
            objRolSecretaria.registrarRolSecretaria();
            this.Close();
        }
    }
}
