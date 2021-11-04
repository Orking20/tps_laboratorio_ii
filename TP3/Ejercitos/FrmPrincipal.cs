using Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Ejercitos
{
    public partial class FrmPrincipal : Form
    {
        private Form formularioActivo = null;
        private static List<Ejercito<string, string>> ejercitos;
        private static bool flagExportar = true;
        private string error;

        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirFormularioHijo(new FrmPresentacion());
            CargaDatos();
        }

        /// <summary>
        /// Abre el formulario pasado por parámetro
        /// </summary>
        /// <param name="formularioHijo">Formulario a abrir</param>
        private void AbrirFormularioHijo(Form formularioHijo)
        {
            try
            {
                if (this.formularioActivo != null)
                {
                    this.formularioActivo.Close();
                }

                this.formularioActivo = formularioHijo;

                formularioHijo.TopLevel = false;
                this.pnlPrincipal.Controls.Add(formularioHijo);
                this.pnlPrincipal.Tag = formularioHijo;
                formularioHijo.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAgregarEjercito());
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPresentacion());
        }

        private void btnModificarEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmModificarEliminarEjercito());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarEjercitos());
        }
        private void btnExportar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmExportar());
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFiltro());
        }
        private void btnImportar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmImportar());
        }

        private void CargaDatos()
        {
            ejercitos = new List<Ejercito<string, string>>();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagExportar && MessageBox.Show("No guardaste los cambios. Asegurate de hacerlo con el botón 'Exportar'\n¿Estás seguro que quieres salir?", "¿Desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public static List<Ejercito<string, string>> Ejercitos
        {
            get
            {
                return ejercitos;
            }
            set
            {
                ejercitos = value;
            }
        }

        public static bool FlagExportar
        {
            set
            {
                flagExportar = value;
            }
        }

    }
}
