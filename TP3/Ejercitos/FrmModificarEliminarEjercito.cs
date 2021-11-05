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
    public partial class FrmModificarEliminarEjercito : Form
    {
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmModificarEliminarEjercito()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos a los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmModificarEliminarEjercito_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbNacion.DataSource = Enum.GetValues(typeof(ENacion));
                this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
                this.cmbAutonomia.DataSource = Enum.GetValues(typeof(EAutonomia));
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.cmbNacion.Text = null;
            this.cmbTipo.Text = null;
            this.cmbAutonomia.Text = null;
        }

        /// <summary>
        /// Muestra el ejército coincidente con el ID seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Ejercito<string, string> ejercito;

            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
                {
                    ejercito = FrmPrincipal.Ejercitos[i];

                    if (this.nudId.Value == ejercito.Id)
                    {
                        this.lblInfo.Visible = false;
                        this.txtNombre.Text = ejercito.Nombre;
                        this.cmbNacion.Text = ejercito.Nacion;
                        this.cmbTipo.Text = ejercito.Tipo;
                        this.cmbAutonomia.Text = ejercito.Autonomia;
                        this.nudNumero.Value = ejercito.CantMaxEjercito;
                        break;
                    }
                    else
                    {
                        this.lblInfo.Visible = true;
                        this.txtNombre.Text = null;
                        this.cmbNacion.Text = null;
                        this.cmbTipo.Text = null;
                        this.cmbAutonomia.Text = null;
                        this.nudNumero.Value = 0;
                    }
                }
            }
            else
            {
                this.lblInfo.Visible = true;
            }
        }

        /// <summary>
        /// Modifica un ejército ya existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ejercito<string, string> ejercito;

            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
                {
                    ejercito = FrmPrincipal.Ejercitos[i];

                    if (this.nudId.Value == ejercito.Id)
                    {
                        if (this.txtNombre.Text != null || this.cmbNacion.Text != null || this.cmbTipo.Text != null || this.cmbAutonomia.Text != null || this.nudNumero.Value != 0)
                        {
                            ejercito.Nombre = this.txtNombre.Text;
                            ejercito.Nacion = this.cmbNacion.Text;
                            ejercito.Tipo = this.cmbTipo.Text;
                            ejercito.Autonomia = this.cmbAutonomia.Text;
                            ejercito.CantMaxEjercito = (int)this.nudNumero.Value;
                            FrmPrincipal.FlagExportar = false;
                            ReproducirSonidoExito();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Elimina un ejército ya existente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ejercito<string, string> ejercito;

            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
                {
                    ejercito = FrmPrincipal.Ejercitos[i];

                    if (this.nudId.Value == ejercito.Id)
                    {
                        Ejercito<string, string>.BajaEjercito(FrmPrincipal.Ejercitos, ejercito);
                        FrmPrincipal.FlagExportar = false;
                        this.txtNombre.Text = null;
                        this.cmbNacion.Text = null;
                        this.cmbTipo.Text = null;
                        this.cmbAutonomia.Text = null;
                        this.nudNumero.Value = 0;
                        ReproducirSonidoExito();
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Reproduce un sonido indicando al usuario que se modificó correctamente
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
