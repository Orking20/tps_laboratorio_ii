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
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmAgregarEjercito()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga datos a los comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarEjercito_Load(object sender, EventArgs e)
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
        /// Agrega un ejército a la lista de ejércitos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            Ejercito<string, string> ejercitoNuevo;

            if (Validar.Nombre(this.txtNombre.Text) &&
                int.TryParse(this.nudNumero.Text, out cantMaxEjercito))
            {
                nombre = this.txtNombre.Text;
                nacion = (ENacion)this.cmbNacion.SelectedItem;
                tipo = (ETipo)this.cmbTipo.SelectedItem;
                autonomia = (EAutonomia)this.cmbAutonomia.SelectedItem;

                nacionStr = nacion.ToString();
                tipoStr = tipo.ToString();
                autonomiaStr = autonomia.ToString();

                ejercitoNuevo = Ejercito<string, string>.AltaEjercito(nombre, nacionStr, tipoStr, autonomiaStr, cantMaxEjercito);
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
