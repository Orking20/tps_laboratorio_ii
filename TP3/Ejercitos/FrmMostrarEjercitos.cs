using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercitos;
using Entidades;

namespace Formularios
{
    public partial class FrmMostrarEjercitos : Form
    {
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmMostrarEjercitos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra todos los ejércitos importados en la lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMostrarEjercitos_Load(object sender, EventArgs e)
        {
            Ejercito<string, string> ejercito;

            if (FrmPrincipal.Ejercitos.Count > 0)
            {
                for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
                {
                    try
                    {
                        ejercito = FrmPrincipal.Ejercitos[i];

                        dgvEjercitos.Rows.Add(ejercito.Id, ejercito.Nombre, ejercito.Nacion, ejercito.Tipo, ejercito.Autonomia, ejercito.CantMaxEjercito);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
