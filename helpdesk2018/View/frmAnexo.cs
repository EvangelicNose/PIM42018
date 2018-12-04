using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk2018.Controller;

namespace helpdesk2018.View
{
    public partial class frmAnexo : Form
    {
        public frmAnexo()
        {
            InitializeComponent();
        }

        private void frmAnexo_Load(object sender, EventArgs e)
        {
            ptbAnexo.Image = Image.FromFile(Application.StartupPath + @"\Anexo\OS" + mdlChamados.Chamado.OS.ToString() + ".jpg");
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
