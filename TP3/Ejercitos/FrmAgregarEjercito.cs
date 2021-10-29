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
    public partial class FrmAgregarEjercito : Form
    {
        public FrmAgregarEjercito()
        {
            InitializeComponent();
        }

        private void FrmAgregarEjercito_Load(object sender, EventArgs e)
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

            this.cmbNacion.Text = null;
            this.cmbTipo.Text = null;
            this.cmbAutonomia.Text = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre;
            ENacion nacion;
            ETipo tipo;
            EAutonomia autonomia;
            int cantMaxEjercito;
            string nacionStr;
            string tipoStr;
            string autonomiaStr;
            Ejercito<string, string, string> ejercitoNuevo;

            if (Ejercito<ENacion, ETipo, EAutonomia>.ValidarNombre(this.txtNombre.Text) &&
                int.TryParse(this.nudNumero.Text, out cantMaxEjercito))
            {
                nombre = this.txtNombre.Text;
                nacion = (ENacion)this.cmbNacion.SelectedItem;
                tipo = (ETipo)this.cmbTipo.SelectedItem;
                autonomia = (EAutonomia)this.cmbAutonomia.SelectedItem;

                nacionStr = nacion.ToString();
                tipoStr = tipo.ToString();
                autonomiaStr = autonomia.ToString();

                ejercitoNuevo = Ejercito<string, string, string>.AltaEjercito(nombre, nacionStr, tipoStr, autonomiaStr, cantMaxEjercito);
                FrmPrincipal.Ejercitos.Add(ejercitoNuevo);
                FrmPrincipal.FlagExportar = false;  

                MessageBox.Show($"Se ha creado el nuevo ejército: {nombre}", "Nuevo ejército creado exitosamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Uno o varios de los datos ingresados no son válidos\nRevise y corrija los datos por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
