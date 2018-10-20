using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
/* using CamadaDados;
using CamadaModelo; */

namespace PIM4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                         
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }


        private void btnEntrar2_Click(object sender, EventArgs e)
        {
  
            string Query = "select * from tb_usuarios where nomes=@Nome and senhas=@Senha";
            Conexao conexaoDB = new Conexao();
            conexaoDB.conectar();

            OleDbCommand cmd = new OleDbCommand(Query, conexaoDB.cn);

            cmd.Parameters.AddWithValue("@Nome", txtUsuario.Text);
            cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

            OleDbDataReader dr = cmd.ExecuteReader();
            int branco = 0;

            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Usuário não pode ficar em branco !");
                branco = 1;
                txtUsuario.Focus();
            }
            else if (txtSenha.Text=="")
            {
                MessageBox.Show("Senha não pode ficar em branco !");
                branco = 1;
                txtSenha.Focus();
            }

            if (dr.Read() && branco ==0)
            {
                frmMenu _frmmenu = new frmMenu();
                _frmmenu.Show();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else if (branco ==0)
            {
                lblERRO.Visible = true;
                txtSenha.Text = "";
                txtSenha.Focus();

            }
            

        }
    }
}
