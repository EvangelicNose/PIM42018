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
using helpdesk2018.Model;

namespace helpdesk2018.View
{
    public partial class frmManutencaoMotivo : Form
    {
        public frmManutencaoMotivo()
        {
            InitializeComponent();
        }

        private void tbpAlterarMotivo_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarMotivo();            
        }


        void CadastrarMotivo()
        {
            string branco = "0";

            if (txtIncluirMotivo.Text == "")
            {
                MessageBox.Show("Motivo não pode ficar em branco !");
                branco = "1";
                txtIncluirMotivo.Focus();
            }

            if (branco == "0")
            {
                ctlManutencaoMotivo _ctlmanutencaomotivo = new ctlManutencaoMotivo();
                mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
                _mdlmanutencaomotivo.Descricao = txtIncluirMotivo.Text;
                _mdlmanutencaomotivo.Ativo = ckbAtivo.Checked;


                bool retorno1 = _ctlmanutencaomotivo.InserirMotivoMDL(_mdlmanutencaomotivo);
                if (retorno1)
                {
                    MessageBox.Show("Motivo gravado com sucesso");
                    txtIncluirMotivo.Text = "";
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!");
                }
                
            }


        }

        private void txtIncluirMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CadastrarMotivo();
            }
        }

        private void btnAlterarSair_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAlteraMotivo_Click(object sender, EventArgs e)
        {
    
            ctlManutencaoMotivo _ctlmanutencaomotivo = new ctlManutencaoMotivo();
            mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
            _mdlmanutencaomotivo.Descricao = txtAlteraMotivo.Text;
            _mdlmanutencaomotivo.Ativo = ckbAlteraAtivo.Checked;
            dtgAlteraResultado.DataSource = _ctlmanutencaomotivo.AlteraMotivoMDL(_mdlmanutencaomotivo);

            bool retorno1 = _ctlmanutencaomotivo.AlteraMotivoMDL(_mdlmanutencaomotivo);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso");

            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            ctlManutencaoMotivo _ctlmanutencaomotivo = new ctlManutencaoMotivo();
            mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
            _mdlmanutencaomotivo.Descricao = txtPesquisaMotivo.Text;
            dtgAlteraResultado.DataSource = _ctlmanutencaomotivo.PesquisaMotivoMDL(_mdlmanutencaomotivo);

        }

        private void dtgAlteraResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraMotivo.Text = dtgAlteraResultado.CurrentRow.Cells["descricao"].Value.ToString();
            ckbAlteraAtivo.Checked = Convert.ToBoolean(dtgAlteraResultado.CurrentRow.Cells["ativo"].Value.ToString());

        }
    }
}
