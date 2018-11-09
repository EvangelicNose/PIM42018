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
using helpdesk2018.Model;

namespace helpdesk2018.View
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void abrirChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAberturaChamados"] == null)

            {
                frmAberturaChamados _frmaberturachamados = new frmAberturaChamados();
                _frmaberturachamados.MdiParent = this;
                _frmaberturachamados.Show();
            }
            else
            {
                if (MessageBox.Show("Finalize a sessão aberta para continuar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    return;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = "Menus Principal - Usuário: " + frmLogin.UsuarioConectado;
 
            //   frmLogin.UsuarioConectado;
            //   mdlUsuario.Logado.Nome;
            //   mdlUsuario.Logado.Nome;
            //   mdlEmpresa.Logado.NomeEmpresa +
            //   mdlUsuario.Logado.Usuario;
        }



        private void listarChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarChamado _frmListarChamado = new frmListarChamado();
            _frmListarChamado.MdiParent = this;
            _frmListarChamado.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoUsuario _frmUsuario = new frmManutencaoUsuario();
            _frmUsuario.MdiParent = this;
            _frmUsuario.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoEmpresas _frmEmpresas = new frmManutencaoEmpresas();
            _frmEmpresas.MdiParent = this;
            _frmEmpresas.Show();

        }

        private void finalizarSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fazerLogoffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}
