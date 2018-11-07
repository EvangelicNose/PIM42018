using System;
using System.Windows.Forms;
using System.Data.OleDb;
using CamadaDados;
using CamadaModelo;

namespace PIM4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        void label1_Click(object sender, EventArgs e)
        {

        }

        void btnLogin_Click(object sender, EventArgs e)
        {
                         
        }

        void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public static string UsuarioConectado;

        void Entrar()
        {
            // mdlUsuario _mdlusuario = new mdlUsuario();

            Conexao conexao = new Conexao();
            conexao.abrir();

            OleDbCommand cmd = conexao.Comando("select * from tb_usuarios where usuarios=@Usuarios and senhas=@Senha");

            cmd.Parameters.AddWithValue("@Usuarios", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

            OleDbDataReader dr = cmd.ExecuteReader();
            int branco = 0;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário não pode ficar em branco !");
                branco = 1;
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ficar em branco !");
                branco = 1;
                txtSenha.Focus();
            }

            if (dr.Read() && branco == 0)
            {
                UsuarioConectado = txtUsuario.Text;
                frmMenu _frmmenu = new frmMenu();
                _frmmenu.Show();
                this.DialogResult = DialogResult.OK;
                this.Close();
                conexao.Fechar();
                ctlLogin.GuardarDados(UsuarioConectado);

            }
            else if (branco == 0)
            {
                lblERRO.Visible = true;
                txtSenha.Text = "";
                txtSenha.Focus();
                Mexer();
                //  IniciaContagem();
            }
        }

        void btnEntrar2_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        void Mexer()
        {
            var original = lblERRO.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                lblERRO.Location = new System.Drawing.Point (original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            lblERRO.Location = original;
            IniciaContagem();
        }

        void IniciaContagem()
        {
            timer1.Interval = 5000;
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            lblERRO.Visible = false;
            timer1.Stop();
        }

        void lblERRO_Click(object sender, EventArgs e)
        {

        }

        private void btnEntrar2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Entrar();
            }

        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }
    }
}
