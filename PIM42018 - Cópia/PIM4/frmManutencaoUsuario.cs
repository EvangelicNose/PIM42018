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
using CamadaDados;
using CamadaModelo;

namespace PIM4
{
    public partial class frmManutencaoUsuario : Form
    {
        public frmManutencaoUsuario()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            txtUsuario.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            cbNivel.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbDados.Visible = true;
            gbEscolha.Enabled = false;
            txtUsuario.Focus();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string branco = "0";

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário não pode ficar em branco !");
                branco = "1";
                txtUsuario.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não pode ficar em branco !");
                branco = "1";
                txtNome.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ficar em branco !");
                branco = "1";
                txtSenha.Focus();
            }
            else if (cbNivel.Text == "")
            {
                MessageBox.Show("Nivel não pode ficar em branco !");
                branco = "1";
                cbNivel.Focus();
            }


            string nivel = "0";
            if (cbNivel.Text == "Usuário" && branco == "0")
            {
                nivel = "1";
            }
            else if (cbNivel.Text == "Técnico" && branco == "0")
            {
                nivel = "2";
            }
            else if (cbNivel.Text == "Administrador" && branco == "0")
            {
                nivel = "3";
            }

            if (branco == "0")
            {
                ctlManutencaoUsuario _ctlManutencaoUsuario = new ctlManutencaoUsuario();
                mdlManutencaoUsuario _mdlManutencaoUsuario = new mdlManutencaoUsuario();
                _mdlManutencaoUsuario.Usuario = txtUsuario.Text;
                _mdlManutencaoUsuario.Nome = txtNome.Text;
                _mdlManutencaoUsuario.Senha = txtSenha.Text;
                _mdlManutencaoUsuario.Nivel = nivel;
                _mdlManutencaoUsuario.Empresa = idd;

                bool retorno1 = _ctlManutencaoUsuario.InserirUsuarioMDL(_mdlManutencaoUsuario);
                if (retorno1)
                {
                    MessageBox.Show("Usuário gravado com sucesso");
                    limpar();
                    gbEscolha.Enabled = true;
                    gbDados.Visible = false;
                }
                else
                {
                    MessageBox.Show("Erro ao Gravar !!!");
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbDados.Visible = false;
            gbEscolha.Enabled = true;
            limpar();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        string idd = "";

        private void frmManutencaoUsuario_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_empresas";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            OleDbDataReader ler = cmd.ExecuteReader();

            while (ler.Read())
            {
                
                cbEmpresas.Items.Add(ler["nomes"].ToString());
                idd = (ler["id"].ToString());

            }
            conexao.Fechar();

        }

        private void cbEmpresas_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cbEmpresas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
