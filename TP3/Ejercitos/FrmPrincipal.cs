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

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prepara la aplicación inicializando la lista de ejércitos y preparando el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CargaDatos();
            AbrirFormularioHijo(new FrmPresentacion());
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

        /// <summary>
        /// Abre el formulario principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picLogo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmPresentacion());
        }

        /// <summary>
        /// Abre el formulario para agregar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmAgregarEjercito());
        }

        /// <summary>
        /// Abre el formulario para modificar o eliminar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarEliminar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmModificarEliminarEjercito());
        }

        /// <summary>
        /// Abre el formulario para mostrar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmMostrarEjercitos());
        }

        /// <summary>
        /// Abre el formulario para filtrar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmFiltro());
        }

        /// <summary>
        /// Abre el formulario para exportar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmExportar());
        }

        /// <summary>
        /// Abre el formulario para importar ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImportar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmImportar());
        }

        /// <summary>
        /// Inicializa la lista de ejércitos
        /// </summary>
        private void CargaDatos()
        {
            ejercitos = new List<Ejercito<string, string>>();
        }

        /// <summary>
        /// Avisa antes de salir, de ser así, que los cambios no se guardaron y da la opción al usuario de volver a guardarlos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!flagExportar && MessageBox.Show("No guardaste los cambios. Asegurate de hacerlo con el botón 'Exportar'\n¿Estás seguro que quieres salir?", "¿Desea salir?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Obtiene o establece la lista de ejércitos
        /// </summary>
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

        /// <summary>
        /// Establece el valor de flagExportar
        /// </summary>
        public static bool FlagExportar
        {
            set
            {
                flagExportar = value;
            }
        }
    }
}
