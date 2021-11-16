using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercitos
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FrmPrincipal());
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Uno de los argumentos proporcionados a un método no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
