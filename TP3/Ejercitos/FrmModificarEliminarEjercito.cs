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

namespace Formularios
{
    public partial class FrmModificarEliminarEjercito : Form
    {
        public FrmModificarEliminarEjercito()
        {
            InitializeComponent();
        }
        private void FrmModificarEliminarEjercito_Load(object sender, EventArgs e)
        {
            try
            {
                this.cmbNacion.DataSource = Enum.GetValues(typeof(ENacion));
                this.cmbTipo.DataSource = Enum.GetValues(typeof(ETipo));
                this.cmbAutonomia.DataSource = Enum.GetValues(typeof(EAutonomia));
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Se ha pasado una referencia nula a un método que no la acepta como argumento válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Uno de los argumentos proporcionados a un método no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Uno de los argumentos proporcionados a un método no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Ejercito<string, string, string> ejercito;

            for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
            {
                ejercito = FrmPrincipal.Ejercitos[i];

                try
                {
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
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El valor de un argumento está fuera del rango permitido de valores definido por el método invocado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Ejercito<string, string, string> ejercito;

            for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
            {
                ejercito = FrmPrincipal.Ejercitos[i];

                try
                {
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
                        }
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El valor de un argumento está fuera del rango permitido de valores definido por el método invocado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Ejercito<string, string, string> ejercito;

            for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
            {
                ejercito = FrmPrincipal.Ejercitos[i];

                try
                {
                    if (this.nudId.Value == ejercito.Id)
                    {
                        Ejercito<string, string, string>.BajaEjercito(FrmPrincipal.Ejercitos, ejercito);
                        FrmPrincipal.FlagExportar = false;
                        break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("El valor de un argumento está fuera del rango permitido de valores definido por el método invocado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
