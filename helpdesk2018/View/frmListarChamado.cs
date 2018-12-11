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
            if (frmMenu.PCD == true)
            {
                btnAMaior.Visible = true;
                btnAMenor.Visible = true;
            }
            else
            {
                btnAMaior.Visible = false;
                btnAMenor.Visible = false;
            }

            dtgListaChamado.DataSource = Controller.ctlManutencaoOS.ListarOS();
            dtgListaChamado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader; ;
            dtgListaChamado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgListaChamado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dtgListaChamado.ClearSelection();
            btnSair.Select();
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

        public float tamanhoAtual = 8.25F;
        public void ItensPCD()
        {
            lblLista.Font = new Font(lblLista.Font.Name, tamanhoAtual);
            dtgListaChamado.Font = new Font(dtgListaChamado.Font.Name, tamanhoAtual);
            btnSair.Font = new Font(btnSair.Font.Name, tamanhoAtual);
        }
        private void btnIncluiAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                btnSair.Select();
            }
            if (tamanhoAtual > 12)
            {
                btnAMaior.Enabled = false;
            }
        }

        private void btnAMenor_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual < 14)
            {
                btnAMaior.Enabled = true;
                tamanhoAtual -= 2.0F;
                ItensPCD();
                btnSair.Select();
            }
            if (tamanhoAtual < 8)
            {
                btnAMenor.Enabled = false;
            }
        }
    }
}
