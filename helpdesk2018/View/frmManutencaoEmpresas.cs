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

         public void limpar()
        {
            txtPesquisarEmpresa.Text = "";
            txtNome.Text = "";
            txtEndereco.Text = "";
            mskTelefone.Text = "";

            txtAlteraEndereco.Text = "";
            txtAlteraNome.Text = "";
            mskAlteraTelefone.Text = "";
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
            if (mskTelefone.Text == "")
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
                    mskTelefone.Focus();
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
                else if (mskTelefone.Text=="")
                {
                    mskTelefone.Focus();
                }
                else
                {
                    txtEndereco.Focus();
                }
            }
            mdlManutencaoEmpresas _mdlManutencaoEmpresasVer = new mdlManutencaoEmpresas();
            string nome = txtNome.Text;
            _mdlManutencaoEmpresasVer.Nome = nome;
            bool duplicado = ctlManutencaoEmpresas.VerificarDuplicidade(nome);
            if (duplicado)
            {
                MessageBox.Show(" Essa Empresa já está cadastrada ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
                return;
            }

            if (branco == "0")
            {
                mdlManutencaoEmpresas _mdlManutencaoEmpresas = new mdlManutencaoEmpresas();
                _mdlManutencaoEmpresas.Nome = nome;
                _mdlManutencaoEmpresas.Telefone = mskTelefone.Text;
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


        public void PesquisarEmpresa()
        {
            mdlManutencaoEmpresas _mdlmanutencaoempresas = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresas.Nome = txtPesquisarEmpresa.Text;

            DataTable empresas = ctlManutencaoEmpresas.PesquisaEmpresaMDL(_mdlmanutencaoempresas);
            dtgAlteraResultado.DataSource = empresas;
            // empresas dtgAlteraResultado.DataSource = ctlManutencaoEmpresas.PesquisaEmpresaMDL(_mdlmanutencaoempresas);
            if (empresas.Rows.Count == 0)
            {
                MessageBox.Show(" Pesquisa não teve resultado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisarEmpresa.Focus();
            }

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
            dtgAlteraResultado.ClearSelection();
            btnAlterarOK.Enabled = false;
            txtAlteraNome.Text = "";
            txtAlteraEndereco.Text = "";
            mskAlteraTelefone.Text = "";
        }

        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            PesquisarEmpresa();
        }

        private void btnAlterarCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgAlterarResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraNome.Text = dtgAlteraResultado.CurrentRow.Cells["nome"].Value.ToString();
            mskAlteraTelefone.Text = dtgAlteraResultado.CurrentRow.Cells["telefone"].Value.ToString();
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
            if(mskAlteraTelefone.Text=="")
            {
                txtVermAltTelefone.Visible = true;
                MessageBox.Show(" Telefone não pode ficar em branco ");
                mskAlteraTelefone.Focus();
                return;
            }
            if (txtAlteraEndereco.Text == "")
            {
                txtVermAltEndereco.Visible = true;
                MessageBox.Show(" Endereço não pode ficar em branco ");
                txtAlteraEndereco.Focus();
                return;
            }
            string nome = txtAlteraNome.Text;
            int id = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idempresa"].Value.ToString());
            bool duplicado = ctlManutencaoEmpresas.VerificarDuplicidade(nome, id);
            if (duplicado)
            {
                MessageBox.Show(" Esse Nome de empresa já está cadastrada ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraNome.Focus();
                return;
            }

            mdlManutencaoEmpresas _mdlmanutencaoempresa = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresa.Nome = nome;
            _mdlmanutencaoempresa.Endereco = txtAlteraEndereco.Text;
            _mdlmanutencaoempresa.Telefone = mskAlteraTelefone.Text;
            _mdlmanutencaoempresa.Ativa = ckbAlteraAtiva.Checked;
            _mdlmanutencaoempresa.ID = id;
            dtgAlteraResultado.DataSource = ctlManutencaoEmpresas.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            btnAlterarOK.Enabled = false;

            bool retorno1 = ctlManutencaoEmpresas.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso");
                txtPesquisarEmpresa.Focus();
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
                mskTelefone.Focus();
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

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome.Focus();
            txtPesquisarEmpresa.Focus();
        }

        private void txtPesquisarEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PesquisarEmpresa();
            }

        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermErroTelefone.Visible = false;
            txtVermIncTelefone.Visible = false;
            if (e.KeyChar == 13)
            {
                mskTelefone.Focus();
            }
        }

        private void mskAlteraTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtVermAltTelefone.Visible = false;
        }
    }
}
