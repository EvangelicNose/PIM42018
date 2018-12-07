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
using helpdesk2018.Controller;

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
            dtgListaChamado.DataSource = Controller.ctlManutencaoOS.ListarOS();
            dtgListaChamado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; ;
            dtgListaChamado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgListaChamado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgListaChamado.ClearSelection();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgListaChamado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mdlChamados.Chamado.OS = Convert.ToInt16(dtgListaChamado.CurrentRow.Cells["OS"].Value.ToString());
            ctlChamados.getChamado();
            frmDetalharChamado _frmDetalharChamado = new frmDetalharChamado();
            _frmDetalharChamado.ShowDialog();
            dtgListaChamado.DataSource = Controller.ctlManutencaoOS.ListarOS();
        }
    }
}
