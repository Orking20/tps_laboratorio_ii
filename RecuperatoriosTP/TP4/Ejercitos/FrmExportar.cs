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
using System.Threading;

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
		private void btnCsv_Click(object sender, EventArgs e)
		{
			ExportarCsv();
			ComprobarExportacion();
		}

		/// <summary>
		/// Guarda los datos de una lista en un archivo .xml
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnXml_Click(object sender, EventArgs e)
		{
			ExportarXml();
			ComprobarExportacion();
		}

		/// <summary>
		/// Guarda los datos de una lista en un archivo .json
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnJson_Click(object sender, EventArgs e)
		{
			ExportarJson();
			ComprobarExportacion();
		}

		/// <summary>
		/// Guarda los datos de una lista en los tres tipos de archivos: .csv, .xml y .json
		/// usando hilos para que su ejecución sea más rápida
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnExportarTodo_Click(object sender, EventArgs e)
		{
			try
			{
				Task exportarCsv = Task.Run(() => ExportarCsv());
				Task exportarXml = Task.Run(() => ExportarXml());
				Task exportarJson = Task.Run(() => ExportarJson());

				Task.WaitAll(exportarCsv, exportarXml, exportarJson);

				Thread.Sleep(1000);

				ComprobarExportacion();
			}
			catch (Exception)
			{
				MessageBox.Show("Hubo un error al exportar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Si hubo un error lo muesta, si no indica que todo salió correctamente
		/// </summary>
		private void ComprobarExportacion()
		{
			if (error.Length != 0)
			{
				MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
                foreach (Ejercito<string, string> ejercito in FrmPrincipal.Ejercitos)
                {
					ejercito.FlagExportar = true;
					Ejercito<string, string>.EjercitosNoExportadosSB.Clear();
				}

				FrmPrincipal.FlagExportar = true;
				this.lblInfo.Visible = true;
				this.lblInfo.Text = "Exportación exitosa";
				ReproducirSonidoExito();
			}
		}

		/// <summary>
		/// Guarda los datos de una lista en un archivo .csv
		/// </summary>
		private void ExportarCsv()
		{
			Archivo.EscribirCsv(FrmPrincipal.Ejercitos, "Ejercitos.csv", out error);
		}

		/// <summary>
		/// Guarda los datos de una lista en un archivo .xml
		/// </summary>
		private void ExportarXml()
		{
			Archivo.EscribirXml(FrmPrincipal.Ejercitos, "EjercitosXml.xml", out error);
		}

		/// <summary>
		/// Guarda los datos de una lista en un archivo .json
		/// </summary>
		private void ExportarJson()
		{
			Archivo.EscribirJson(FrmPrincipal.Ejercitos, "EjercitosJson.json", out error);
		}

        private void btnVerCambiosSinGuardar_Click(object sender, EventArgs e)
        {
            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                foreach (Ejercito<string, string> ejercito in FrmPrincipal.Ejercitos)
                {
					ejercito.NotificarCambiosSinGuardar(ejercito);
                }
            }

            if (Ejercito<string, string>.EjercitosNoExportadosSB.Length > 0)
            {
				MessageBox.Show(Ejercito<string, string>.EjercitosNoExportadosSB.ToString(), "Ejércitos sin guardar", MessageBoxButtons.OK);
            }
            else
            {
				MessageBox.Show("No hay ejércitos sin guardar", "Ejércitos sin guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
