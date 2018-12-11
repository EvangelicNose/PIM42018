using System;
using System.Collections.Generic;
using System.Windows.Forms;
using helpdesk2018.Controller;
using helpdesk2018.Model;
using System.Data;
using System.IO;
using System.Drawing;

namespace helpdesk2018.View
{
    public partial class frmAberturaChamados : Form
    {
        OpenFileDialog anexo = new OpenFileDialog();

        public frmAberturaChamados()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void AberturaChamados_Load(object sender, EventArgs e)
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

            DateTime DataHoje = DateTime.Today;
            lblData.Text = DataHoje.ToString("dd/MM/yyyy");
            lbNome.Text = mdlUsuario.Logado.Nome;
            lbEmpresa.Text = mdlEmpresa.Logado.NomeEmpresa;
            lbUsuario.Text = mdlUsuario.Logado.Usuario;
            DataTable dadosmotivo = ctlMotivo.CarregaDados();
  
            DataRow nada = dadosmotivo.NewRow();
            nada["descricao"] = "Selecione o motivo...";
            nada["idmotivo"] = -1;
            dadosmotivo.Rows.InsertAt(nada, 0);

            cbbMotivo.DisplayMember = "descricao";
            cbbMotivo.ValueMember = "idmotivo";
            cbbMotivo.DataSource = dadosmotivo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            DateTime HoraAgora = DateTime.Now;
            lblHora.Text = HoraAgora.ToString("HH:mm:ss");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int motivo = Convert.ToInt16(cbbMotivo.SelectedValue);
            if (motivo == -1)
            {
                MessageBox.Show("Selecione um motivo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string descricao = txtDescricao.Text;
            if (descricao == "")
            {
                MessageBox.Show("Informe a descrição.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string retorno = ctlChamados.Abrirchamado(motivo, descricao);

            if (retorno == "")
            {
                MessageBox.Show("Ocorreu um erro ao abrir seu chamado. Por favor, tente novamente mais tarde", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Seu chamado foi cadastrado com sucesso!" + "\n" + "Sua ordem de serviço é : " + retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (mdlChamados.Chamado.Anexo != null)
            {
                if (File.Exists(Application.StartupPath + @"\Anexo\OS" + retorno + ".jpg"))
                {
                    File.Delete(Application.StartupPath + @"\Anexo\OS" + retorno + ".jpg");
                    File.Copy(mdlChamados.Chamado.Anexo, Application.StartupPath + @"\Anexo\OS" + retorno + ".jpg");
                    mdlChamados.Chamado.Anexo = null;
                }
                else
                {
                    File.Copy(mdlChamados.Chamado.Anexo, Application.StartupPath + @"\Anexo\OS" + retorno + ".jpg");
                    mdlChamados.Chamado.Anexo = null;
                } 
            }

            txtDescricao.Text = "";
            cbbMotivo.SelectedValue = -1;
            btnSair.Focus();
        }

        private void btnAnexo_Click(object sender, EventArgs e)
        {
            anexo.Filter = "Jpeg Files|*.jpg";
            if(anexo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Imagem carregada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mdlChamados.Chamado.Anexo = anexo.FileName;
            }
        }

        public float tamanhoAtual = 8.25F;
        public void ItensPCD()
        {
            lblAberturaChamados.Font = new Font(lblAberturaChamados.Font.Name, tamanhoAtual + 8);
            lblUsuario.Font = new Font(lblAberturaChamados.Font.Name, tamanhoAtual);
            lblNome.Font = new Font(lblNome.Font.Name, tamanhoAtual);
            lblEmpresa.Font = new Font(lblEmpresa.Font.Name, tamanhoAtual);
            lblMotivo.Font = new Font(lblMotivo.Font.Name, tamanhoAtual);
            lblDescricao.Font = new Font(lblAberturaChamados.Font.Name, tamanhoAtual);
            lbUsuario.Font = new Font(lbUsuario.Font.Name, tamanhoAtual + 2);
            lbNome.Font = new Font(lbNome.Font.Name, tamanhoAtual + 2);
            lbEmpresa.Font = new Font(lbEmpresa.Font.Name, tamanhoAtual + 2);
            cbbMotivo.Font = new Font(cbbMotivo.Font.Name, tamanhoAtual);
            txtDescricao.Font = new Font(txtDescricao.Font.Name, tamanhoAtual);
            btnEnviar.Font = new Font(btnEnviar.Font.Name, tamanhoAtual);
            btnSair.Font = new Font(btnSair.Font.Name, tamanhoAtual);
            lblData.Font = new Font(lblData.Font.Name, tamanhoAtual);
            lblHora.Font = new Font(lblHora.Font.Name, tamanhoAtual);

        }
        private void btnIncluiAMaior_Click(object sender, EventArgs e)
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
