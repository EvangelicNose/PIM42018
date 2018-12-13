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
            txtAberto.Text = mdlChamados.Chamado.Aberto;
            txtFechado.Text = mdlChamados.Chamado.Fechado;
            
            if (mdlChamados.Chamado.Status == "2")
            {
                txtResposta.Text = mdlChamados.Chamado.Resposta;
                txtResposta.Enabled = false;
                btnFecharChamado.Enabled = false;
                txtFechado.Visible = true;
                lblFechado.Visible = true;
                txtFechado.Text = mdlChamados.Chamado.Fechado;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResposta.Text == "")
            {
                MessageBox.Show(" Resposta não pode ficar em branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtResposta.Focus();
                return;
            }
            if(ctlChamados.FecharChamado(txtResposta.Text) == true)
            {
                MessageBox.Show("Chamado fechado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtResposta.Enabled = false;
                btnFecharChamado.Enabled = false;
                ctlChamados.getChamado();
                txtFechado.Text = mdlChamados.Chamado.Fechado;
                btnVoltar.Select();
            }else
            {
                MessageBox.Show("Ocorreu um erro, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnexo_Click_1(object sender, EventArgs e)
        {
            frmAnexo _frmAnexo = new frmAnexo();
            _frmAnexo.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPrintChamados printChamados = new FrmPrintChamados(txtOS.Text, txtNome.Text, txtEmpresa.Text, txtMotivo.Text, txtDescricao.Text, txtAberto.Text, txtResposta.Text, txtFechado.Text);
            printChamados.ShowDialog();
        }

        public float tamanhoAtual = 8.25F;
        public void ItensPCD()
        {
            lblNome.Font = new Font(lblNome.Font.Name, tamanhoAtual);
            lblEmpresa.Font = new Font(lblEmpresa.Font.Name, tamanhoAtual);
            lblMotivo.Font = new Font(lblMotivo.Font.Name, tamanhoAtual);
            lblDescricao.Font = new Font(lblDescricao.Font.Name, tamanhoAtual);
            lblResposta.Font = new Font(lblResposta.Font.Name, tamanhoAtual);
            lblOS.Font = new Font(lblOS.Font.Name, tamanhoAtual);
            txtNome.Font = new Font(txtNome.Font.Name, tamanhoAtual);
            txtEmpresa.Font = new Font(txtEmpresa.Font.Name, tamanhoAtual);
            txtMotivo.Font = new Font(txtMotivo.Font.Name, tamanhoAtual);
            txtDescricao.Font = new Font(txtDescricao.Font.Name, tamanhoAtual);
            txtResposta.Font = new Font(txtResposta.Font.Name, tamanhoAtual);
            txtOS.Font = new Font(txtOS.Font.Name, tamanhoAtual);
            btnFecharChamado.Font = new Font(btnFecharChamado.Font.Name, tamanhoAtual);
            btnImprimir.Font = new Font(btnImprimir.Font.Name, tamanhoAtual);
            btnVoltar.Font = new Font(btnVoltar.Font.Name, tamanhoAtual);

        }
        private void btnAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                txtDescricao.Focus();
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
                txtDescricao.Focus();
            }
            if (tamanhoAtual < 8)
            {
                btnAMenor.Enabled = false;
            }
        }
    }
}
