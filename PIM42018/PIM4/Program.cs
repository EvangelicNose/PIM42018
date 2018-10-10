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

                // O Form2 é o meu Login, aqui no exemplo, então vou exibi-lo
                frmLogin f = new frmLogin();

                // Se o OK for pressionado, eu abro o aplicativo, senão eu saio
                if (f.ShowDialog() == DialogResult.OK)
                    Application.Run(new frmMenu());
            }
        }
    }
}
