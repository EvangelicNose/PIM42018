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
        public void CadastrarEmpresa()
        {
            string branco = "0";
            if (txtNome.Text == "")
            {
                lblVermErro.Visible = true;
                VermIncNome.Visible = true;
               // MessageBox.Show("Nome não pode ficar em branco !");
                branco = "1";
                txtNome.Focus();
            }
            //else
            if (mskTelefone.Text == "")
            {
                lblVermErroTelefone.Visible = true;
                VermIncTelefone.Visible = true;
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
                VermIncEndereco.Visible = true;
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
                MessageBox.Show(" Essa Empresa já está cadastrada ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show("Empresa gravada com sucesso", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpar();
                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gpbConfirmaAlteracao.Enabled = false;
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
            gpbConfirmaAlteracao.Enabled = true;
        }

        public void AlterarEmpresa()
        {
            if (txtAlteraNome.Text == "")
            {
                VermAltNome.Visible = true;
                MessageBox.Show(" Nome não pode ficar em Branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraNome.Focus();
                return;
            }
            if (mskAlteraTelefone.Text == "")
            {
                VermAltTelefone.Visible = true;
                MessageBox.Show(" Telefone não pode ficar em branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskAlteraTelefone.Focus();
                return;
            }
            if (txtAlteraEndereco.Text == "")
            {
                VermAltEndereco.Visible = true;
                MessageBox.Show(" Endereço não pode ficar em branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraEndereco.Focus();
                return;
            }
            string nome = txtAlteraNome.Text;
            int id = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idempresa"].Value.ToString());
            bool duplicado = ctlManutencaoEmpresas.VerificarDuplicidade(nome, id);
            if (duplicado)
            {
                MessageBox.Show(" Esse Nome de empresa já está cadastrada ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gpbConfirmaAlteracao.Enabled = false;

            bool retorno1 = ctlManutencaoEmpresas.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                txtPesquisarEmpresa.Focus();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterarOK_Click(object sender, EventArgs e)
        {
            AlterarEmpresa();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermErro.Visible = false;
            VermIncNome.Visible = false;
            if (e.KeyChar == 13)
            {
                mskTelefone.Focus();
            }
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermErroTelefone.Visible = false;
            VermIncTelefone.Visible = false;
            if (e.KeyChar==13)
            {
                txtEndereco.Focus();
            }
        }

        private void txtEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblVermEndereco.Visible = false;
            VermIncEndereco.Visible = false;
            if (e.KeyChar == 13)
            {
                CadastrarEmpresa();
            }
        }

        private void txtAlteraNome_KeyPress(object sender, KeyPressEventArgs e)
        { 
            VermAltNome.Visible = false;
            if (e.KeyChar == 13)
            {
                mskAlteraTelefone.Focus();
            }
        }

        private void txtAlteraTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VermAltTelefone.Visible = false;
        }

        private void txtAlteraEndereco_KeyPress(object sender, KeyPressEventArgs e)
        {
            VermAltEndereco.Visible = false;
            if (e.KeyChar == 13)
            {
                ckbAlteraAtiva.Focus();
            }
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
            VermIncTelefone.Visible = false;
            if (e.KeyChar == 13)
            {
                txtEndereco.Focus();
            }
        }

        private void mskAlteraTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VermAltTelefone.Visible = false;
            if (e.KeyChar == 13)
            {
                txtAlteraEndereco.Focus();
            }
        }

        private void ckbAlteraAtiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AlterarEmpresa();
            }
        }
        public float tamanhoAtual = 8.25F;
        public void ItensPCD()
        {
            lblVermErro.Font = new Font(lblVermErro.Font.Name, tamanhoAtual);
            lblVermEndereco.Font = new Font(lblVermEndereco.Font.Name, tamanhoAtual);
            lblVermErroTelefone.Font = new Font(lblVermErroTelefone.Font.Name, tamanhoAtual);
            lblIncNome.Font = new Font(lblIncNome.Font.Name, tamanhoAtual);
            lblIncTelefone.Font = new Font(lblIncTelefone.Font.Name, tamanhoAtual);
            lblIncEndereco.Font = new Font(lblIncEndereco.Font.Name, tamanhoAtual);
            txtNome.Font = new Font(txtNome.Font.Name, tamanhoAtual);
            txtEndereco.Font = new Font(txtEndereco.Font.Name, tamanhoAtual);
            mskTelefone.Font = new Font(mskTelefone.Font.Name, tamanhoAtual);
            VermIncNome.Font = new Font(VermIncNome.Font.Name, tamanhoAtual+6);
            VermIncEndereco.Font = new Font(VermIncEndereco.Font.Name, tamanhoAtual+6);
            VermIncTelefone.Font = new Font(VermIncTelefone.Font.Name, tamanhoAtual+6);
            btnCadastrar.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
            btnSair.Font = new Font(btnSair.Font.Name, tamanhoAtual);

            lblAltPEsquisaEmpresa.Font = new Font(lblAltPEsquisaEmpresa.Font.Name, tamanhoAtual);
            txtPesquisarEmpresa.Font = new Font(txtPesquisarEmpresa.Font.Name, tamanhoAtual);
            btnPesquisarEmpresa.Font = new Font(btnPesquisarEmpresa.Font.Name, tamanhoAtual);
            dtgAlteraResultado.Font = new Font(dtgAlteraResultado.Font.Name, tamanhoAtual);
            lblAlteraNome.Font = new Font(lblAlteraNome.Font.Name, tamanhoAtual);
            VermAltNome.Font = new Font(VermAltNome.Font.Name, tamanhoAtual);
            txtAlteraNome.Font = new Font(txtAlteraNome.Font.Name, tamanhoAtual);
            lblAlteraTelefone.Font = new Font(lblAlteraTelefone.Font.Name, tamanhoAtual);
            VermAltTelefone.Font = new Font(VermAltTelefone.Font.Name, tamanhoAtual);
            mskAlteraTelefone.Font = new Font(mskAlteraTelefone.Font.Name, tamanhoAtual);
            ckbAlteraAtiva.Font = new Font(ckbAlteraAtiva.Font.Name, tamanhoAtual);
            lblAlteraEndereco.Font = new Font(lblAlteraEndereco.Font.Name, tamanhoAtual);
            VermAltEndereco.Font = new Font(VermAltEndereco.Font.Name, tamanhoAtual);
            txtAlteraEndereco.Font = new Font(txtAlteraEndereco.Font.Name, tamanhoAtual);
            btnAlterarOK.Font = new Font(btnAlterarOK.Font.Name, tamanhoAtual);
            btnAlterarSair.Font = new Font(btnAlterarSair.Font.Name, tamanhoAtual);
        }

        private void btnIncluiAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnIncluiAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                txtNome.Focus();
            }
            if (tamanhoAtual > 12)
            {
                btnIncluiAMaior.Enabled = false;
            }
        }

        private void btnIncluiAMenor_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual < 14)
            {
                btnIncluiAMaior.Enabled = true;
                tamanhoAtual -= 2.0F;
                ItensPCD();
                txtNome.Focus();
            }
            if (tamanhoAtual < 8)
            {
                btnIncluiAMenor.Enabled = false;
            }
        }

        private void btnAlteraAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnAlteraAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                txtPesquisarEmpresa.Focus();
            }
            if (tamanhoAtual > 12)
            {
                btnAlteraAMaior.Enabled = false;
            }
        }

        private void btnAlteraAMenor_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual < 14)
            {
                btnAlteraAMaior.Enabled = true;
                tamanhoAtual -= 2.0F;
                ItensPCD();
                txtPesquisarEmpresa.Focus();
            }
            if (tamanhoAtual < 8)
            {
                btnAlteraAMenor.Enabled = false;
            }
        }
    }
}
