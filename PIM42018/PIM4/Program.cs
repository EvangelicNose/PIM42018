using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM4
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                frmLogin _frmLogin = new frmLogin();
                Application.Run(_frmLogin);
                if (_frmLogin.DialogResult == DialogResult.OK)
                    Application.Run(new frmMenu());

            }
        }
    }
}
