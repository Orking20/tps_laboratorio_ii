using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
