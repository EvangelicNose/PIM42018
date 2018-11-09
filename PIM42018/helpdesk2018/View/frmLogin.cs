using System;
using System.Windows.Forms;
using System.Data.OleDb;
using helpdesk2018.Controller;
using helpdesk2018.Model;

namespace helpdesk2018.View
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

            OleDbCommand cmd = conexao.Comando("select * from tb_usuarios where usuario=@Usuario and senha=@Senha");

            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
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
                conexao.Fechar();
                ctlLogin.GuardarDados(UsuarioConectado);
                frmMenu _frmmenu = new frmMenu();
                this.Hide();
                _frmmenu.ShowDialog();
                this.Close();
            }
            else if (branco == 0)
            {
                lblERRO.Visible = true;
                txtSenha.Text = "";
                txtSenha.Focus();
                Mexer();
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



        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSenha.Focus();
            }
        }
    }
}
