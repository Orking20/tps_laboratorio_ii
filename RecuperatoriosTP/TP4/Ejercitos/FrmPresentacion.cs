using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmPresentacion : Form
    {
        /// <summary>
        /// Carga los componentes gráficos
        /// </summary>
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abre una ventana con un link a la fuente de donde se sacaron los datos y la inspiración para esta aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHermandad_Click(object sender, EventArgs e)
        {
            FrmHermandad frmHermandad = new FrmHermandad();

            frmHermandad.Show();
        }

        /// <summary>
        /// Muestra una mensaje informando la ruta donde se guardarán todos los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRuta_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Todos los datos se guardarán en la siguiente ruta:\n{Directory.GetCurrentDirectory()}", "Ruta de guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
