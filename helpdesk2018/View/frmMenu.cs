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
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void abrirChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frmAberturaChamados"] == null)

            {
                frmAberturaChamados _frmaberturachamados = new frmAberturaChamados();
               // _frmaberturachamados.MdiParent = this;
                _frmaberturachamados.ShowDialog();
            }
            else
            {
                if (MessageBox.Show("Finalize a sessão aberta para continuar!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    return;
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            string NivelUser = "";
            if (mdlUsuario.Logado.Nivel == "0")
            {
                NivelUser = "Usuário";
            }
            if (mdlUsuario.Logado.Nivel == "1")
            {
                NivelUser = "Técnico";
            }
            if (mdlUsuario.Logado.Nivel == "2")
            {
                NivelUser = "Administrador";
            }

            this.Text = "Menus Principal - Usuário: " + frmLogin.UsuarioConectado + " | Nivel: " + NivelUser;


            if (mdlUsuario.Logado.Nivel== "0" || mdlUsuario.Logado.Nivel == "1")
            {
                manutençãoToolStripMenuItem.Visible = false;
            }

            //   frmLogin.UsuarioConectado;
            //   mdlUsuario.Logado.Nome;
            //   mdlUsuario.Logado.Nome;
            //   mdlEmpresa.Logado.NomeEmpresa +
            //   mdlUsuario.Logado.Usuario;
        }

        private void listarChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarChamado _frmListarChamado = new frmListarChamado();
            // _frmListarChamado.MdiParent = this;
            _frmListarChamado.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoUsuario _frmUsuario = new frmManutencaoUsuario();
            _frmUsuario.ShowDialog();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencaoEmpresas _frmEmpresas = new frmManutencaoEmpresas();
            _frmEmpresas.ShowDialog();
        }

        private void fazerLogoffToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            using (frmLogin frmLogin = new frmLogin())
            {
                this.Hide();
                frmLogin.ShowDialog();
                Close();
            }
            

        }

        private void motivosToolStripMenuItem_Click(object sender, EventArgs e)
        {


        /* teste de verificar se está aberto
            if (Application.OpenForms.OfType<FrmNomeDoForm>().Count() > 0)
            {
                Application.OpenForms.OfType<FrmNomeDoForm>().First().Focus();
            }
            else
            {
                FrmNomeDoForm frmNomeDoForm = new FrmNomeDoForm();
                frmNomeDoForm.Show();
            }
        */

            frmManutencaoMotivo _frmmanutencaomotivo = new frmManutencaoMotivo();
            _frmmanutencaomotivo.ShowDialog();

        }

        private void finalizarSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (msgFechar() == 0) { Application.Exit(); }

        }
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {



        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre _frmSobre = new frmSobre();
            _frmSobre.ShowDialog();
        }

        int msgFechar()
        {
            if (MessageBox.Show("Deseja realmente sair ?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {

                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
