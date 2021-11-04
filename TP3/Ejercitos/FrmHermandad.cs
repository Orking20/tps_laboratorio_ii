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
using System.Diagnostics;

namespace Formularios
{
    public partial class FrmHermandad : Form
    {
        public FrmHermandad()
        {
            InitializeComponent();
        }

        private void llbFuente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.llbFuente.LinkVisited = true;
            string path;
            var p = new Process();

            try
            {
                path = Directory.GetCurrentDirectory();

                p.StartInfo = new ProcessStartInfo($"{path}\\Fuente.html")
                {
                    UseShellExecute = true
                };

                p.Start();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Usted no tiene autorización para acceder a esta ruta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PlatformNotSupportedException)
            {
                MessageBox.Show("Una característica no se ha podido ejecutar en su plataforma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ObjectDisposedException)
            {
                MessageBox.Show("Se ha realizado una operación en un objeto desechado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Win32Exception)
            {
                MessageBox.Show("Código de error Win32", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
