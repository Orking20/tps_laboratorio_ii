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
        public FrmMostrarEjercitos()
        {
            InitializeComponent();
        }

        private void FrmMostrarEjercitos_Load(object sender, EventArgs e)
        {
            Ejercito<string, string, string> ejercito;

            for (int i = 0; i < FrmPrincipal.Ejercitos.Count; i++)
            {
                ejercito = FrmPrincipal.Ejercitos[i];
                
                dgvEjercitos.Rows.Add(ejercito.Id, ejercito.Nombre, ejercito.Nacion, ejercito.Tipo, ejercito.Autonomia, ejercito.CantMaxEjercito);
            }
        }
    }
}
