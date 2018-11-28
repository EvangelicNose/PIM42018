using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using helpdesk2018.View;

namespace helpdesk2018
{
    public partial class frmListarChamado : Form
    {
        public frmListarChamado()
        {
            InitializeComponent();
        }

        private void frmListarChamado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Controller.ctlManutencaoOS.ListarOS();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetalharChamado _frmDetalharChamado = new frmDetalharChamado();
            _frmDetalharChamado.ShowDialog();
            
        }
    }
}
