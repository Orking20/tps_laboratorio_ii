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
using Ejercitos;
using System.Media;
using System.IO;

namespace Formularios
{
    public partial class FrmFiltro : Form
    {
        private List<Ejercito<string, string>> ejercitosFiltrados;
        private string nombreArchivo;

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmFiltro()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Filtra por ejércitos de Dormenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDormenios_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.Dormenios(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "Dormenios.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de Eridie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEridios_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.Eridios(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "Eridios.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de Harrassia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHarrasianos_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.Harrassianos(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "Harrassianos.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos Guneares
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuneares_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.Guneares(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "Guneares.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de infantería ligera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfanteriaLigera_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.InfanteriaLigera(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "InfanteriaLigera.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos con tropas individuales de igual o mayor tamaño a 5000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMayores5000_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.EjercitosMayoresA5000(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "EjercitosMayoresA5000.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de infantería entre 1000 y 5000 tropas individuales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfanteriaEntre1000Y5000_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.InfanteriaEntre1000Y5000(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "InfanteriaEntre1000Y5000.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de caballería de buena autonomía
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaballeriaBuenaAutonomia_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.CaballeriaConBuenaAutonomia(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "CaballeriaConBuenaAutonomia.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Filtra por ejércitos de autonomía completa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutonomiaCompleta_Click(object sender, EventArgs e)
        {
            this.ejercitosFiltrados = Filtro.AutonomiaCompleta(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "AutonomiaCompleta.csv";

            LimpiarCeldas();
            MostrarDatos(this.ejercitosFiltrados);
        }

        /// <summary>
        /// Guarda los datos del ejército filtrado en el archivo especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            string error;

            Archivo.EscribirCsv(this.ejercitosFiltrados, this.nombreArchivo, out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblInfo.Visible = true;
                ReproducirSonidoExito();
            }
        }

        /// <summary>
        /// Muestra los datos de todos los ejércitos pasados por la lista filtrada
        /// </summary>
        /// <param name="ejercitosFiltradosAux">Lista filtrada de los ejércitos</param>
        private void MostrarDatos(List<Ejercito<string, string>> ejercitosFiltradosAux)
        {
            Ejercito<string, string> ejercito;

            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                if (ejercitosFiltradosAux.Count > 0)
                {
                    for (int i = 0; i < ejercitosFiltradosAux.Count; i++)
                    {
                        try
                        {
                            ejercito = ejercitosFiltradosAux[i];

                            dgvEjercitos.Rows.Add(ejercito.Id, ejercito.Nombre, ejercito.Nacion, ejercito.Tipo, ejercito.Autonomia, ejercito.CantMaxEjercito);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ejércitos cargados. Asegúrese de importarlos o de agregar nuevos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Borra los datos mostrados en cada celda del DataGrid
        /// </summary>
        private void LimpiarCeldas()
        {
            try
            {
                dgvEjercitos.Rows.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Reproduce un sonido indicando al usuario que se guardó correctamente
        /// </summary>
        private void ReproducirSonidoExito()
        {
            try
            {
                SoundPlayer sonido = new SoundPlayer($"{Directory.GetCurrentDirectory()}\\Sonido\\Exito.wav");
                sonido.Play();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("No tienes permisos para hacer esta acción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha surgido un error.\nAsegúrese de que el archivo 'Exito.wav' se encuentre en la carpeta 'Sonido'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
