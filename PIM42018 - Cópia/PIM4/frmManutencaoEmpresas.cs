using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelo;

namespace PIM4
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
            gbDados.Visible = true;
            gbEscolha.Enabled = false;
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
                
                bool retorno1 = _ctlManutencaoEmpresas.InserirEmpresasMDL(_mdlManutencaoEmpresas);
                if (retorno1)
                {
                    MessageBox.Show("Empresa gravada com sucesso");
                    limpar();
                    gbEscolha.Enabled = true;
                    gbDados.Visible = false;
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!");
                }


            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbDados.Visible = false;
            gbEscolha.Enabled = true;
            limpar();
        }
    }
}
