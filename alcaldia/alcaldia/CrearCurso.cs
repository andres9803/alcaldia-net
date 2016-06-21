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
    public partial class CrearCurso : Form
    {
        public CrearCurso()
        {
            InitializeComponent();
        }

        private void CrearCurso_Load(object sender, EventArgs e)
        {
            Curso objCurso = new Curso();
            DataSet objData = new DataSet();

            cmbInstituto.DataSource = objCurso.llenarInstitutos().Tables[0];
            cmbInstituto.DisplayMember = "nombre";//Muestra este campo 
            cmbInstituto.ValueMember = "idInstituto";//Guarda este campo

            txtDocumento.Text = Sesion.documentoSesion.ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Curso objCurso = new Curso();

            objCurso.Nombre = txtNombre.Text;
            objCurso.Descripcion = txtDescripcion.Text;
            objCurso.Horario = txtHorario.Text;
            objCurso.FechaInicial = DateTime.Parse(txtFechaInicial.Text);
            objCurso.FechaFinal = DateTime.Parse(txtFechaFinal.Text);
            objCurso.Valor = long.Parse(txtValor.Text);
            objCurso.TotalHoras = int.Parse(txtTotalDeHoras.Text);
            objCurso.MaximoAsistentes = int.Parse(txtMaxAsistentes.Text);
            objCurso.FechaInicialInscripciones = DateTime.Parse(txtFechaInicialInscripcion.Text);
            objCurso.FechaFinalInscripciones = DateTime.Parse(txtFechaFinalInscripcion.Text);
            objCurso.IdInstituto = long.Parse(cmbInstituto.SelectedValue.ToString());
            objCurso.ValoracionCurso = int.Parse(txtValorCurso.Text);
            objCurso.Documento = long.Parse(txtDocumento.Text);
            objCurso.registrarCurso();
            this.Close();
        }
    }
}
