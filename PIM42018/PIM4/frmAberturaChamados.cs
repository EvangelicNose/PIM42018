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
using System.Data.OleDb;

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
            lblData.Text = DataHoje.ToString("dd/MM/yyy");
            txtUsuario.Text= frmLogin.UsuarioConectado;
            txtEmpresa.Text = ctlLogin.RetornarDados(2, txtUsuario.Text);
            txtNome.Text = ctlLogin.RetornarDados(1, txtUsuario.Text);
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
            Conexao conexao = new Conexao();

            OleDbCommand cmd = conexao.Comando(@"
                insert into tb_chamados
                (idusuarios, nome, idempresas, idmotivos, obs) values
                (@idusuario, @nome, @idempresa, @idmotivo, @obs)
            ");

            // cmd.Parameters.AddWithValue("@idusuario", );
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
