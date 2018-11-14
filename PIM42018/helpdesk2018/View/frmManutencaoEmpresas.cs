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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbDados_Enter(object sender, EventArgs e)
        {

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
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
        }

        private void btOK_Click(object sender, EventArgs e)
        {

            string branco = "0";

            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não pode ficar em branco !");
                branco = "1";
                txtNome.Focus();
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Telefone não pode ficar em branco !");
                branco = "1";
                txtTelefone.Focus();
            }
            else if (txtEndereco.Text == "")
            {
                MessageBox.Show("Endereço não pode ficar em branco !");
                branco = "1";
                txtEndereco.Focus();
            }


            if (branco == "0")
            {
                ctlManutencaoEmpresas _ctlManutencaoEmpresas = new ctlManutencaoEmpresas();
                mdlManutencaoEmpresas _mdlManutencaoEmpresas = new mdlManutencaoEmpresas();
                _mdlManutencaoEmpresas.Nome = txtNome.Text;
                _mdlManutencaoEmpresas.Telefone = txtTelefone.Text;
                _mdlManutencaoEmpresas.Endereco = txtEndereco.Text;
                _mdlManutencaoEmpresas.Ativa = ckbIncluirAtiva.Checked;


                bool retorno1 = _ctlManutencaoEmpresas.InserirEmpresasMDL(_mdlManutencaoEmpresas);
                if (retorno1)
                {
                    MessageBox.Show("Empresa gravada com sucesso");
                    limpar();
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!");
                }


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmManutencaoEmpresas_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            ctlManutencaoEmpresas _ctlmanutencaoempresas = new ctlManutencaoEmpresas();
            mdlManutencaoEmpresas _mdlmanutencaoempresas = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresas.Nome = txtPesquisarEmpresa.Text;
            dtgAlteraResultado.DataSource = _ctlmanutencaoempresas.PesquisaEmpresaMDL(_mdlmanutencaoempresas);

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
        }

        private void btnAlterarOK_Click(object sender, EventArgs e)
        {
            ctlManutencaoEmpresas _ctlmanutencaoempresa = new ctlManutencaoEmpresas();
            mdlManutencaoEmpresas _mdlmanutencaoempresa = new mdlManutencaoEmpresas();
            _mdlmanutencaoempresa.Nome = txtAlteraNome.Text;
            _mdlmanutencaoempresa.Endereco = txtAlteraEndereco.Text;
            _mdlmanutencaoempresa.Telefone = txtAlteraTelefone.Text;
            _mdlmanutencaoempresa.Ativa = ckbAlteraAtiva.Checked;
            _mdlmanutencaoempresa.ID = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idempresa"].Value.ToString());
            dtgAlteraResultado.DataSource = _ctlmanutencaoempresa.AlteraEmpresaMDL(_mdlmanutencaoempresa);

            bool retorno1 = _ctlmanutencaoempresa.AlteraEmpresaMDL(_mdlmanutencaoempresa);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso");

            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }
        }
    }
}
