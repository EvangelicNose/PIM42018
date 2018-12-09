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
using System.IO;

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
            if (File.Exists(Application.StartupPath + @"\Anexo\OS" + mdlChamados.Chamado.OS.ToString() + ".jpg"))
            {
                btnAnexo.Enabled = true;
            }

            if (mdlUsuario.Logado.Nivel == "0")
            {
                btnFecharChamado.Visible = false;
                txtResposta.Enabled = false;
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

        private void btnAnexo_Click(object sender, EventArgs e)
        {
        }

        private void btnAnexo_Click_1(object sender, EventArgs e)
        {
            frmAnexo _frmAnexo = new frmAnexo();
            _frmAnexo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPrintChamados printChamados = new FrmPrintChamados(txtOS.Text, txtNome.Text, txtEmpresa.Text, txtMotivo.Text, txtDescricao.Text, txtResposta.Text);
            printChamados.ShowDialog();
        }
    }
}
