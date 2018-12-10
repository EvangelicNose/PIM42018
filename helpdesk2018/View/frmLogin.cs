using System;
using System.Windows.Forms;
using System.Data.OleDb;
using helpdesk2018.Controller;
using helpdesk2018.Model;
using System.Drawing;

namespace helpdesk2018.View
{
    public partial class frmLogin : Form
    {
        bool dragging = false;
        int xOffset = 0;
        int yOffset = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        public static string UsuarioConectado;

        void Entrar()
        {
            Conexao conexao = new Conexao();
            conexao.abrir();

            OleDbCommand cmd = conexao.Comando("select * from tb_usuarios where usuario=@Usuario and senha=@Senha and ativo=@ativo");

            cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);
            bool ativo=true;
            cmd.Parameters.AddWithValue("@ativo", ativo);

            OleDbDataReader dr = cmd.ExecuteReader();
            int branco = 0;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = 1;
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = 1;
                txtSenha.Focus();
            }

            if (dr.Read() && branco == 0)
            {

                UsuarioConectado = txtUsuario.Text;
                conexao.Fechar();
                ctlLogin.GuardarDados(UsuarioConectado);
                using (frmMenu frmmenu = new frmMenu())
                {
                    this.Hide();
                    frmmenu.ShowDialog();
                    this.Close();
                }
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
            timer1.Interval = 15000;
            timer1.Start();
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            lblERRO.Visible = false;
            timer1.Stop();
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
                Entrar();
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;

            xOffset = Cursor.Position.X - this.Location.X;
            yOffset = Cursor.Position.Y - this.Location.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point(Cursor.Position.X - xOffset, Cursor.Position.Y - yOffset);
                this.Update();
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
