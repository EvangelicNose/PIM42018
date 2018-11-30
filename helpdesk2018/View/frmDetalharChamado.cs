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
    }
}
