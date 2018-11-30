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
    public partial class frmManutencaoEmpresas : Form
    {
        public frmManutencaoEmpresas()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtNome.Focus();
        }
        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void limpar()
        {
            txtPesquisarEmpresa.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";

            txtAlteraEndereco.Text = "";
            txtAlteraNome.Text = "";
            txtAlteraTelefone.Text = "";
        }
        void CadastrarEmpresa()
        {
            string branco = "0";
            if (txtNome.Text == "")
            {
                lblVermErro.Visible = true;
                txtVermIncNome.Visible = true;
               // MessageBox.Show("Nome não pode ficar em branco !");
                branco = "1";
                txtNome.Focus();
            }
            //else
            if (txtTelefone.Text == "")
            {
                lblVermErroTelefone.Visible = true;
                txtVermIncTelefone.Visible = true;
              //  MessageBox.Show("Telefone não pode ficar em branco !");
                branco = "1";
                if (txtNome.Text == "")
                {
                    txtNome.Focus();
                }
                else
                {
                    txtTelefone.Focus();
                }
            }
           // else 
            if (txtEndereco.Text == "")
            {
                lblVermEndereco.Visible = true;
                txtVermIncEndereco.Visible = true;
               // MessageBox.Show("Endereço não pode ficar em branco !");
                branco = "1";
                if (txtNome.Text == "")
                {
                    txtNome.Focus();
                }
                else if (txtTelefone.Text=="")
                {
                    txtTelefone.Focus();
                }
                else
                {
                    txtEndereco.Focus();
                }
            }
            if (branco == "0")
            {
                mdlManutencaoEmpresas _mdlManutencaoEmpresas = new mdlManutencaoEmpresas();
                _mdlManutencaoEmpresas.Nome = txtNome.Text;
                _mdlManutencaoEmpresas.Telefone = txtTelefone.Text;
                _mdlManutencaoEmpresas.Endereco = txtEndereco.Text;
                _mdlManutencaoEmpresas.Ativa = ckbIncluirAtiva.Checked;


                bool retorno1 = ctlManutencaoEmpresas.InserirEmpresasMDL(_mdlManutencaoEmpresas);
                if (retorno1)
                {
                    MessageBox.Show("Empresa gravada com sucesso");
                    limpar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!");
                }


            }



        }



        private void btOK_Click(object sender, EventArgs e)
        {
            CadastrarEmpresa();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmManutencaoEmpresas_Load(object sender, EventArgs e)
        {
             txtNome.Select();
        }

        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            mdlManutencaoEmpresas _mdlmanutencaoempresas = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresas.Nome = txtPesquisarEmpresa.Text;
            dtgAlteraResultado.DataSource = ctlManutencaoEmpresas.PesquisaEmpresaMDL(_mdlmanutencaoempresas);

            dtgAlteraResultado.Columns[0].HeaderText = "idempresa";
            dtgAlteraResultado.Columns[0].Visible = false;
            dtgAlteraResultado.Columns[1].HeaderText = "Nome";
            dtgAlteraResultado.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[2].HeaderText = "Telefone";
            dtgAlteraResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[3].HeaderText = "Endereço";
            dtgAlteraResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[4].HeaderText = "Ativa ?";
            dtgAlteraResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnAlterarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgAlterarResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraNome.Text = dtgAlteraResultado.CurrentRow.Cells["nome"].Value.ToString();
            txtAlteraTelefone.Text = dtgAlteraResultado.CurrentRow.Cells["telefone"].Value.ToString();
            txtAlteraEndereco.Text = dtgAlteraResultado.CurrentRow.Cells["endereco"].Value.ToString();
            ckbAlteraAtiva.Checked = Convert.ToBoolean(dtgAlteraResultado.CurrentRow.Cells["ativa"].Value.ToString());
            btnAlterarOK.Enabled = true;
        }

        private void btnAlterarOK_Click(object sender, EventArgs e)
        {
            if (txtAlteraNome.Text=="")
            {
                txtVermAltNome.Visible = true;
                MessageBox.Show(" Nome não pode ficar em Branco ");
                txtAlteraNome.Focus();
                return;
            }
            if(txtAlteraTelefone.Text=="")
            {
                txtVermAltTelefone.Visible = true;
                MessageBox.Show(" Telefone não pode ficar em branco ");
                txtAlteraTelefone.Focus();
                return;
            }
            if (txtAlteraEndereco.Text == "")
            {
                txtVermAltEndereco.Visible = true;
                MessageBox.Show(" Endereço não pode ficar em branco ");
                txtAlteraEndereco.Focus();
                return;
            }

            mdlManutencaoEmpresas _mdlmanutencaoempresa = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresa.Nome = txtAlteraNome.Text;
            _mdlmanutencaoempresa.Endereco = txtAlteraEndereco.Text;
            _mdlmanutencaoempresa.Telefone = txtAlteraTelefone.Text;
            _mdlmanutencaoempresa.Ativa = ckbAlteraAtiva.Checked;
            _mdlmanutencaoempresa.ID = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idempresa"].Value.ToString());
            dtgAlteraResultado.DataSource = ctlManutencaoEmpresas.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            btnAlterarOK.Enabled = false;

            bool retorno1 = ctlManutencaoEmpresas.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermErro.Visible = false;
            txtVermIncNome.Visible = false;
                if (e.KeyChar == 13)
                {
                txtTelefone.Focus();
                }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermErroTelefone.Visible = false;
            txtVermIncTelefone.Visible = false;
            if (e.KeyChar==13)
            {
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermEndereco.Visible = false;
            txtVermIncEndereco.Visible = false;
            if (e.KeyChar == 13)
            {
                CadastrarEmpresa();
            }
        }

        private void txtAlteraNome_KeyPress(object sender, KeyPressEventArgs e)
        { 
            txtVermAltNome.Visible = false;
        }

        private void txtAlteraTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVermAltTelefone.Visible = false;
        }

        private void txtAlteraEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVermAltEndereco.Visible = false;
        }
    }
}
