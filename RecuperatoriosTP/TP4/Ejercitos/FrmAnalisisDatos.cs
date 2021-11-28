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
using System.Net.Mail;

namespace Formularios
{
    public partial class FrmAnalisisDatos : Form
    {
        private List<Ejercito<string, string>> ejercitosFiltrados;
        private string nombreArchivo;
        private string criterio;
        private float porcentaje;

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmAnalisisDatos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos provenientes de Dormenia
        /// y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDormenios_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.Dormenios(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeDormenios.csv";
            this.criterio = "Ejércitos de naciones dormenias";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos provenientes de Eridios
        /// y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEridios_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.Eridios(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeEridios.csv";
            this.criterio = "Ejércitos de naciones eridias";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos provenientes de Gunear
        /// y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuneares_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.Guneares(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeGuneares.csv";
            this.criterio = "Ejércitos de naciones guneares";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos provenientes de Harrassia
        /// y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHarrasianos_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.Harrassianos(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeHarrassianos.csv";
            this.criterio = "Ejércitos de naciones harrassianas";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos de infantería y los
        /// muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfanteriaLigera_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.InfanteriaLigera(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeInfanteriaLigera.csv";
            this.criterio = "Ejércitos de infanterías ligeras";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos con tropas individuales
        /// iguales o mayores a 5000 y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMayores5000_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.EjercitosMayoresA5000(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeEjercitosMayoresA5000.csv";
            this.criterio = "Ejércitos con 5000 o más tropas unitarias";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos de infantería con entre
        /// 1000 y 5000 tropas individuales y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfanteriaEntre1000Y5000_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.InfanteriaEntre1000Y5000(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeInfanteriaEntre1000Y5000.csv";
            this.criterio = "Ejércitos de infantería entre 1000 y 5000 tropas unitarias";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos de caballería con buena autonomía
        /// completa y los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCaballeriaBuenaAutonomia_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.CaballeriaConBuenaAutonomia(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeCaballeriaConBuenaAutonomia.csv";
            this.criterio = "Ejércitos de caballería con buena autonomía";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        /// <summary>
        /// Calcula el porcentaje de ejércitos con autonomía completa y
        /// los muestra por el DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAutonomiaCompleta_Click(object sender, EventArgs e)
        {
            int dividendo;

            this.ejercitosFiltrados = Filtro.AutonomiaCompleta(FrmPrincipal.Ejercitos);
            this.nombreArchivo = "PorcentajeAutonomiaCompleta.csv";
            this.criterio = "Ejércitos con autonomía completa";

            LimpiarCeldas();
            dividendo = this.ejercitosFiltrados.Count;
            this.porcentaje = CalcularPorcentaje(dividendo);
            this.dgvEjercitos.Rows.Add(this.criterio, this.porcentaje);
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            StringBuilder sbMejorEjercito = new StringBuilder();
            StringBuilder sb = new StringBuilder();

            sbMejorEjercito.AppendLine(Analisis.MejorEjercito());
            sb.AppendLine(Analisis.CompararDormeniosEridios());
            sb.AppendLine(Analisis.CompararDormeniosHarrasianos());
            sb.AppendLine(Analisis.CompararDormeniosGuneares());
            sb.AppendLine(Analisis.CompararEridiosHarrasianos());
            sb.AppendLine(Analisis.CompararEridiosGuneares());
            sb.AppendLine(Analisis.CompararHarrassianosGuneares());

            rtxMejorEjercito.Visible = true;
            rtxMejorEjercito.Text = sbMejorEjercito.ToString();
            rtxInfo.Visible = true;
            rtxInfo.Text = sb.ToString();
        }

        /// <summary>
        /// Guarda los datos del criterio y el porcentaje en el archivo especificado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportar_Click(object sender, EventArgs e)
        {
            string error;

            Archivo.EscribirPorcentajes(criterio, porcentaje, nombreArchivo, out error);

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
        /// Borra los datos mostrados en cada celda del DataGrid
        /// </summary>
        private void LimpiarCeldas()
        {
            try
            {
                this.dgvEjercitos.Rows.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Calcula el porcentaje de algún criterio dependiendo de el valor total de
        /// ejércitos y el valor de los ejércitos filtrados
        /// </summary>
        /// <param name="dividendo">Número de ejércitos filtrados</param>
        /// <returns></returns>
        private float CalcularPorcentaje(int dividendo)
        {
            int totalEjercitos = FrmPrincipal.Ejercitos.Count;
            float resultado;

            if (totalEjercitos > 0)
            {
                resultado = ((float)dividendo / totalEjercitos) * 100;
            }
            else
            {
                resultado = 0;
            }

            return resultado;
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
