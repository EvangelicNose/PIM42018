using System;
using System.Collections.Generic;
using System.Windows.Forms;
using helpdesk2018.Controller;
using helpdesk2018.Model;
using System.Data;

namespace helpdesk2018.View
{
    public partial class frmAberturaChamados : Form
    {
        public frmAberturaChamados()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void AberturaChamados_Load(object sender, EventArgs e)
        {
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

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
           // timer1.Stop();
            DateTime HoraAgora = DateTime.Now;
            lblHora.Text = HoraAgora.ToString("HH:mm:ss");
            // timer1.Start();
            timer1.Stop();

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int motivo = Convert.ToInt16(cbbMotivo.SelectedValue);
            if (motivo == -1)
            {
                MessageBox.Show("Selecione um motivo.");
                return;
            }
            string descricao = txtDescricao.Text;
            if (descricao == "")
            {
                MessageBox.Show("Informe a descrição.");
                return;
            }
            string retorno = ctlChamados.Abrirchamado(motivo, descricao);

            if (retorno == "")
            {
                MessageBox.Show("Ocorreu um erro ao abrir seu chamado. Por favor, tente novamente mais tarde");
                return;
            }

            MessageBox.Show("Seu chamado foi cadastrado com sucesso!" + "\n" + "Sua ordem de serviço é : " + retorno);
            txtDescricao.Text = "";
            cbbMotivo.SelectedValue = -1;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbbMotivo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
