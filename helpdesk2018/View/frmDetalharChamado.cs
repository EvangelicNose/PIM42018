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

namespace helpdesk2018.View
{
    public partial class frmDetalharChamado : Form
    {
        public frmDetalharChamado()
        {
            InitializeComponent();
        }

        private void frmDetalharChamado_Load(object sender, EventArgs e)
        {
            if (mdlUsuario.Logado.Nivel == "0")
            {
                btnFecharChamado.Visible = false;
                txtResposta.Visible = false;
                lblResposta.Visible = false;
            }

            txtOS.Text = mdlChamados.Chamado.OS.ToString();
            txtDescricao.Text = mdlChamados.Chamado.Descricao;
            txtEmpresa.Text = mdlChamados.Chamado.Empresa;
            txtNome.Text = mdlChamados.Chamado.NomeUsuario;
            txtMotivo.Text = mdlChamados.Chamado.Motivo;

            if (mdlChamados.Chamado.Status == "2")
            {
                txtResposta.Text = mdlChamados.Chamado.Resposta;
                txtResposta.Enabled = false;
                btnFecharChamado.Enabled = false;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text == "")
            {
                MessageBox.Show(" Resposta não pode ficar em branco ");
                txtResposta.Focus();
                return;
            }
            if(ctlChamados.FecharChamado(txtResposta.Text) == true)
            {
                MessageBox.Show("Chamado fechado com sucesso!");
                txtResposta.Enabled = false;
                btnFecharChamado.Enabled = false;
            }else
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
