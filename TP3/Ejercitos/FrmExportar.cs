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
    public partial class FrmExportar : Form
    {
        private string error;

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmExportar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Guarda los datos de una lista en un archivo .csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScv_Click(object sender, EventArgs e)
        {
            Archivo.EscribirCsv(FrmPrincipal.Ejercitos, "Ejercitos.csv", out error);
            FrmPrincipal.FlagExportar = true;

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        /// <summary>
        /// Guarda los datos de una lista en un archivo .xml
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            Archivo.EscribirXml(FrmPrincipal.Ejercitos, out error);
            FrmPrincipal.FlagExportar = true;

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        /// <summary>
        /// Guarda los datos de una lista en un archivo .json
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJson_Click(object sender, EventArgs e)
        {
            Archivo.EscribirJson(FrmPrincipal.Ejercitos, out error);
            FrmPrincipal.FlagExportar = true;

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
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
