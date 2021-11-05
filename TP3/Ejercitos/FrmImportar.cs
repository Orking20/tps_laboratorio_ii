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
    public partial class FrmImportar : Form
    {
        string error;

        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmImportar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Obtiene los datos de un archivo .csv y los guarda en una lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCsv_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Ejercitos = Archivo.LeerCsv(out error);

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
        /// Obtiene los datos de un archivo .xml y los guarda en una lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXml_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Ejercitos = Archivo.LeerXml(out error);

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
        /// Obtiene los datos de un archivo .json y los guarda en una lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJson_Click(object sender, EventArgs e)
        {
            FrmPrincipal.Ejercitos = Archivo.LeerJson(out error);

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
        /// Reproduce un sonido indicando al usuario que se leyeron correctamente los datos
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
