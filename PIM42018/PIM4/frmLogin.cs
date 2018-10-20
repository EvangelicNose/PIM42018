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

namespace PIM4
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            timer1.Interval = 3000;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Query = "select * from tb_usuarios where usuario=@Nome and senha=@Senha";
            Conexao conexaoDB = new Conexao();
            conexaoDB.conectar();

            OleDbCommand cmd = new OleDbCommand(Query, conexaoDB.cn);

            var pmtnome = cmd.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = txtUsuario.Text;
            cmd.Parameters.Add(pmtnome);

            var pmtsenha = cmd.CreateParameter();
            pmtsenha.ParameterName = "@senha";
            pmtsenha.DbType = DbType.String;
            pmtsenha.Value = txtSenha.Text;
            cmd.Parameters.Add(pmtsenha);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                frmMenu _frmmenu = new frmMenu();
                _frmmenu.Show();
                this.DialogResult = DialogResult.OK;
                this.Close();
                mdlUsuario _mdlUsuario = new mdlUsuario();
                _mdlUsuario.Usuario = txtUsuario.Text;


            }
            else
            {
                lblERRO.Visible = true;
                txtSenha.Text = "";
                txtSenha.Focus();
                conexaoDB.cn.Close();
                timer1.Start();
            }



        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblERRO.Visible = false;
        }
    }
}
