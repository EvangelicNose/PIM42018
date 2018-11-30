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
            txtDescricao.Text = mdlChamados.Chamado.Descricao;
            txtEmpresa.Text = mdlChamados.Chamado.Empresa;
            txtNome.Text = mdlChamados.Chamado.NomeUsuario;
            txtMotivo.Text = mdlChamados.Chamado.Motivo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ctlChamados.FecharChamado(txtResposta.Text) == true)
            {
                MessageBox.Show("Chamado fechado com sucesso!");
            }else
            {
                MessageBox.Show("Ocorreu um erro, tente novamente");
            }
        }
    }
}
