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
            txtPesquisaMotivo.Focus();
            txtPesquisaMotivo.Select();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarMotivo();
        }

        public void limpar()
        {
            txtPesquisaMotivo.Text = "";
            txtAlteraMotivo.Text = "";
            txtIncluirMotivo.Text = "";
            txtPesquisaMotivo.Text = "";
        }

    
        void CadastrarMotivo()
        {
            string branco = "0";

            if (txtIncluirMotivo.Text == "")
            {
                txtVermelho.Visible = true;
                MessageBox.Show("Motivo não pode ficar em branco !");
                branco = "1";
                txtIncluirMotivo.Focus();
            }

            if (branco == "0")
            {
                mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
               // ctlManutencaoMotivo _ctlmanutencaomotivo = new ctlManutencaoMotivo();
                _mdlmanutencaomotivo.Descricao = txtIncluirMotivo.Text;
                _mdlmanutencaomotivo.Ativo = ckbAtivo.Checked;
                

                bool retorno1 = ctlManutencaoMotivo.InserirMotivoMDL(_mdlmanutencaomotivo);
                if (retorno1)
                {
                    MessageBox.Show("Motivo gravado com sucesso");
                    limpar();
                }
                
                else
                {
                    MessageBox.Show("  Erro ao Gravar !!!  "+ "\n" + "   Dado Duplicado   ");
                }

            }


        }

        private void txtIncluirMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVermelho.Visible = false;
            if (e.KeyChar == 13)
            {
                CadastrarMotivo();
            }
        }

        private void btnAlterarSair_Click(object sender, EventArgs e)
        {
            limpar();
            Close();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            limpar();
            Close();
        }

        private void btnAlteraMotivo_Click(object sender, EventArgs e)
        {

            if (txtAlteraMotivo.Text == "")
            {
                txtAlteraVermelho.Visible = true;
                MessageBox.Show(" Selecione uma opção ");
                txtAlteraMotivo.Focus();
                return;
            }

            mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
            _mdlmanutencaomotivo.Descricao = txtAlteraMotivo.Text;
            _mdlmanutencaomotivo.Ativo = ckbAlteraAtivo.Checked;
            _mdlmanutencaomotivo.IDMotivo = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idmotivo"].Value.ToString());
            dtgAlteraResultado.DataSource = ctlManutencaoMotivo.AlteraMotivoMDL(_mdlmanutencaomotivo);

            bool retorno1 = ctlManutencaoMotivo.AlteraMotivoMDL(_mdlmanutencaomotivo);
            if (retorno1)
            {
                limpar();
                MessageBox.Show("Dados alterados com sucesso");

            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            mdlManutencaoMotivo _mdlmanutencaomotivo = new mdlManutencaoMotivo();
            _mdlmanutencaomotivo.Descricao = txtPesquisaMotivo.Text;
            dtgAlteraResultado.DataSource = ctlManutencaoMotivo.PesquisaMotivoMDL(_mdlmanutencaomotivo);

        }

        private void dtgAlteraResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraMotivo.Text = dtgAlteraResultado.CurrentRow.Cells["descricao"].Value.ToString();
            ckbAlteraAtivo.Checked = Convert.ToBoolean(dtgAlteraResultado.CurrentRow.Cells["ativo"].Value.ToString());
            btnAlteraMotivo.Enabled = true;
        }

        private void frmManutencaoMotivo_Load_1(object sender, EventArgs e)
        {
            txtIncluirMotivo.Select();

        }

         private void tbpManutencaoMotivo_MouseClick(object sender, MouseEventArgs e)
        {
            txtPesquisaMotivo.Focus();
            txtIncluirMotivo.Focus();
        }

        int tamInc = 8;
        int tamAlt = 8;
        string font = "'Microsoft Sans Serif'";

        private void btnAMenor_Click(object sender, EventArgs e)
        {
            float tamanhoAtual;
            if (tamInc > 6)
            {
                btnAMaior.Enabled = true;
                tamanhoAtual = txtIncluirMotivo.Font.Size;
                tamInc -= 2;
                tamanhoAtual -= 2.0F;
                lblMotivo.Font = new Font(lblMotivo.Font.Name, tamanhoAtual);
                txtIncluirMotivo.Font = new Font(txtIncluirMotivo.Font.Name, tamanhoAtual);
                btnCadastrar.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
                btnSair.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
            }
            if (tamInc == 6)
            {
                btnAMenor.Enabled = false;
            }

        }
        
        private void btnAMaior_Click(object sender, EventArgs e)
        {

            float tamanhoAtual;
            if (tamInc < 12)
            {
                btnAMenor.Enabled = true;
                tamanhoAtual = txtIncluirMotivo.Font.Size;
                tamInc += 2;
                tamanhoAtual += 2.0F;
                lblMotivo.Font = new Font(lblMotivo.Font.Name, tamanhoAtual);
                txtIncluirMotivo.Font = new Font(txtIncluirMotivo.Font.Name, tamanhoAtual);
                btnCadastrar.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
                btnSair.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
            }
            if (tamInc == 12)
            {
                btnAMaior.Enabled = false;
            }
           
        }

        private void btnAlterarAMaior_Click(object sender, EventArgs e)
        {
            
            float tamanhoAtual;
            if (tamAlt < 12)
            {
                btnAlterarAMenor.Enabled = true;
                tamanhoAtual = txtPesquisaMotivo.Font.Size;
                tamAlt += 2;
                tamanhoAtual += 2.0F;

                lblAlteraPesquisarMotivo.Font = new Font(lblAlteraPesquisarMotivo.Font.Name, tamanhoAtual);
                txtPesquisaMotivo.Font = new Font(txtPesquisaMotivo.Font.Name, tamanhoAtual);
                btnPesquisar.Font = new Font(btnPesquisar.Font.Name, tamanhoAtual);
                lblAlteraMotivo.Font = new Font(lblAlteraMotivo.Font.Name, tamanhoAtual);
                txtAlteraMotivo.Font = new Font(txtAlteraMotivo.Font.Name, tamanhoAtual);
                btnAlteraMotivo.Font = new Font(btnAlteraMotivo.Font.Name, tamanhoAtual);
                ckbAlteraAtivo.Font = new Font(ckbAlteraAtivo.Font.Name, tamanhoAtual);
                btnAlterarSair.Font = new Font(btnAlterarSair.Font.Name, tamanhoAtual);
            }
            if (tamAlt == 12)
            {
                btnAlterarAMaior.Enabled = false;
            }
        }

        private void btnAlterarAMenor_Click(object sender, EventArgs e)
        {
            float tamanhoAtual;
            if (tamAlt > 6)
            {
                btnAlterarAMaior.Enabled = true;
                tamanhoAtual = txtPesquisaMotivo.Font.Size;
                tamAlt -= 2;
                tamanhoAtual -= 2.0F;

                lblAlteraPesquisarMotivo.Font = new Font(lblAlteraPesquisarMotivo.Font.Name, tamanhoAtual);
                txtPesquisaMotivo.Font = new Font(txtPesquisaMotivo.Font.Name, tamanhoAtual);
                btnPesquisar.Font = new Font(btnPesquisar.Font.Name, tamanhoAtual);
                lblAlteraMotivo.Font = new Font(lblAlteraMotivo.Font.Name, tamanhoAtual);
                txtAlteraMotivo.Font = new Font(txtAlteraMotivo.Font.Name, tamanhoAtual);
                btnAlteraMotivo.Font = new Font(btnAlteraMotivo.Font.Name, tamanhoAtual);
                ckbAlteraAtivo.Font = new Font(ckbAlteraAtivo.Font.Name, tamanhoAtual);
                btnAlterarSair.Font = new Font(btnAlterarSair.Font.Name, tamanhoAtual);
            }
            if (tamAlt == 6)
            {
                btnAlterarAMenor.Enabled = false;
            }

        }

        private void txtAlteraMotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtAlteraVermelho.Visible = false;
        }
    }
}
