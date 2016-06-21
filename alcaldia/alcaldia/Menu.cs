using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (Sesion.rolSesion == "Administrador")
            {
                menuStrip1.Visible = true;
            }
            if (Sesion.rolSesion == "Secretaria")
            {
                menuStrip2.Visible = true;
            }
            if (Sesion.rolSesion == "Estudiante")
            {
                menuStrip3.Visible = true;
            }

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void secretariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearEntidadSecretaria objFormularioCrearSecretaria = new CrearEntidadSecretaria();
            objFormularioCrearSecretaria.MdiParent = this;
            objFormularioCrearSecretaria.Show();
        }

        private void institutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearInstituto objFormularioCrearInstitucion = new CrearInstituto();
            objFormularioCrearInstitucion.MdiParent = this;
            objFormularioCrearInstitucion.Show();
        }

        private void usuariosDeSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearUsuarioSecretaria objFormulario = new CrearUsuarioSecretaria();
            objFormulario.MdiParent = this;
            objFormulario.Show();
        }

        private void alcaldiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearAlcaldia objFormCrearAlcaldia = new CrearAlcaldia();
            objFormCrearAlcaldia.MdiParent = this;
            objFormCrearAlcaldia.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearCurso objFormCrearCurso = new CrearCurso();
            objFormCrearCurso.MdiParent = this;
            objFormCrearCurso.Show();
        }

        private void asistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CrearAsistencia objFormCrearAsistencia = new CrearAsistencia();
            objFormCrearAsistencia.MdiParent = this;
            objFormCrearAsistencia.Show();
        }

        private void verSecretariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerSecretarias objSecretarias = new VerSecretarias();
            objSecretarias.MdiParent = this;
            objSecretarias.Show();
        }

        private void verInstitutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInstitutos objInstitutos = new VerInstitutos();
            objInstitutos.MdiParent = this;
            objInstitutos.Show();
        }

        private void verAlcaldiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAlcaldias objAlcaldias = new VerAlcaldias();
            objAlcaldias.MdiParent = this;
            objAlcaldias.Show();
        }

        private void verUsuariosDeSecretariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerUsuariosSecretaria objSecretarias = new VerUsuariosSecretaria();
            objSecretarias.MdiParent = this;
            objSecretarias.Show();
        }

        private void cambiarLaContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarContrasena objFormCambiarContrasena = new FormCambiarContrasena();
            objFormCambiarContrasena.MdiParent = this;
            objFormCambiarContrasena.Show();
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCambiarContrasena objFormCambiarContrasena = new FormCambiarContrasena();
            objFormCambiarContrasena.MdiParent = this;
            objFormCambiarContrasena.Show();
        }

        private void cambiarContraseñaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCambiarContrasena objFormCambiarContrasena = new FormCambiarContrasena();
            objFormCambiarContrasena.MdiParent = this;
            objFormCambiarContrasena.Show();
        }

        private void verCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerCursos objVerCursos = new VerCursos();
            objVerCursos.MdiParent = this;
            objVerCursos.Show();
        }

        private void verCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCursos objVerCursos = new VerCursos();
            objVerCursos.MdiParent = this;
            objVerCursos.Show();

        }

        private void cursosCreadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerAsistencias objVerCursos = new VerAsistencias();
            objVerCursos.MdiParent = this;
            objVerCursos.Show();
        }

        private void inscribirseAUnNuevoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarCurso objAsignarcurso = new AsignarCurso();
            objAsignarcurso.MdiParent = this;
            objAsignarcurso.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void cursosEnLosQueSeEncuentraInscritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerCursosInscritos objVerCursosInscritos = new VerCursosInscritos();
            objVerCursosInscritos.MdiParent = this;
            objVerCursosInscritos.Show();
        }

        private void cancelarInscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calificarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
