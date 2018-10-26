using System;
using System.Windows.Forms;
using CamadaDados;
using CamadaModelo;

namespace PIM4
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
            txtNome.Text = mdlUsuario.Logado.Nome;
            txtUsuario.Text = "";
            // txtUsuario.Text = _mdlusuario.Usuario;
            // txtEmpresa.Text = ctlChamados.ConsultaEmpresa(txtUsuario.Text);
            // txtNome.Text = ctlChamados.ConsultaUsuario(txtUsuario.Text);
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
            timer1.Stop();
            DateTime HoraAgora = DateTime.Now;
            lblHora.Text = HoraAgora.ToString("HH:mm:ss");
            timer1.Start();
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
