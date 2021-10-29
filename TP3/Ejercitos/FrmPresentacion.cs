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
        public FrmPresentacion()
        {
            InitializeComponent();
        }

        private void btnHermandad_Click(object sender, EventArgs e)
        {
            FrmHermandad frmHermandad = new FrmHermandad();

            frmHermandad.Show();
        }
    }
}
