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
        public FrmFiltro()
        {
            InitializeComponent();
        }

        private void btnDormenios_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.Dormenios(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "Dormenios.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnEridios_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.Eridios(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "Eridios.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnHarrasianos_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.Harrassianos(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "Harrassianos.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnGuneares_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.Guneares(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "Guneares.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnInfanteriaLigera_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.InfanteriaLigera(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "InfanteriaLigera.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnMayores5000_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.EjercitosMayoresA5000(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "EjercitosMayoresA5000.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnInfanteriaEntre1000Y5000_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.InfanteriaEntre1000Y5000(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "InfanteriaEntre1000Y5000.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnCaballeriaBuenaAutonomia_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.CaballeriaConBuenaAutonomia(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "CaballeriaConBuenaAutonomia.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

        private void btnAutonomiaCompleta_Click(object sender, EventArgs e)
        {
            List<Ejercito<string, string>> ejercitosFiltrados;
            string error;

            ejercitosFiltrados = Filtro.AutonomiaCompleta(FrmPrincipal.Ejercitos);

            Archivo.EscribirCsv(ejercitosFiltrados, "AutonomiaCompleta.csv", out error);

            if (error.Length != 0)
            {
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ReproducirSonidoExito();
            }
        }

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
