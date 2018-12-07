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
using helpdesk2018.Controller;
using helpdesk2018.Model;

namespace helpdesk2018
{
    public partial class frmManutencaoUsuario : Form
    {
        public frmManutencaoUsuario()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            txtPesquisaNome.Text = "";
            txtUsuario.Text = "";
            txtNome.Text = "";
            txtSenha.Text = "";
            txtTelefone.Text = "";
            cbNivel.SelectedIndex = -1;
            cbEmpresas.SelectedIndex = -1;

            txtAlteraNome.Text = "";
            txtAlteraSenha.Text = "";
            txtAlteraTelefone.Text = "";
            txtAlteraUsuario.Text = "";
            cbbAlteraEmpresa.SelectedIndex = -1;
            cbbAlteraNivel.SelectedIndex = -1;
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
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Telfone não pode ficar em branco !");
                branco = "1";
                txtTelefone.Focus();
            }
            else if (cbNivel.Text == "")
            {
                MessageBox.Show("Nivel não pode ficar em branco !");
                branco = "1";
                cbNivel.Focus();
            }
            else if (cbEmpresas.Text == "")
            {
                MessageBox.Show("Empresa não pode ficar em branco !");
                branco = "1";
                cbEmpresas.Focus();
            }


            string nivel = "0";
            if (cbNivel.Text == "Usuário" && branco == "0")
            {
                nivel = "0";
            }
            else if (cbNivel.Text == "Técnico" && branco == "0")
            {
                nivel = "1";
            }
            else if (cbNivel.Text == "Administrador" && branco == "0")
            {
                nivel = "2";
            }

            if (branco == "0")
            {

                mdlManutencaoUsuario _mdlManutencaoUsuarioVer = new mdlManutencaoUsuario();
                _mdlManutencaoUsuarioVer.Usuario = txtUsuario.Text;
                bool duplicado = ctlManutencaoUsuario.VerificarDuplicidade(_mdlManutencaoUsuarioVer);
                if (duplicado)
                {
                    MessageBox.Show(" Esse Usuário já está cadastrado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtUsuario.Focus();
                    return;
                }

                if (branco == "0")
                {
                    mdlManutencaoUsuario _mdlManutencaoUsuario = new mdlManutencaoUsuario();
                    _mdlManutencaoUsuario.Usuario = txtUsuario.Text;
                    _mdlManutencaoUsuario.Nome = txtNome.Text;
                    _mdlManutencaoUsuario.Senha = txtSenha.Text;
                    _mdlManutencaoUsuario.Telefone = txtTelefone.Text;
                    _mdlManutencaoUsuario.Nivel = nivel;
                    _mdlManutencaoUsuario.Empresa = Convert.ToInt16(cbEmpresas.SelectedValue.ToString());
                    _mdlManutencaoUsuario.Ativo = ckbAtivo.Checked;

                    bool retorno1 = ctlManutencaoUsuario.InserirUsuarioMDL(_mdlManutencaoUsuario);
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
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            gbDados.Visible = false;
            gbEscolha.Visible = true;
            gbEscolha.Enabled = true;
            btnVoltar.Focus();
            limpar();
        }

        private void frmManutencaoUsuario_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_empresas where ativa=true";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            OleDbDataAdapter popularIncluirEmpresa = new OleDbDataAdapter(Query, conexao.GetConexao());
            OleDbDataAdapter popularAlterarEmpresa = new OleDbDataAdapter(Query, conexao.GetConexao());
        
            DataTable resultadoInclui = new DataTable();
            DataTable resultadoAltera = new DataTable();

            popularIncluirEmpresa.Fill(resultadoInclui);
            popularAlterarEmpresa.Fill(resultadoAltera);

            cbEmpresas.DataSource = resultadoAltera;
            cbEmpresas.DisplayMember = "nome";
            cbEmpresas.ValueMember = "idempresa";

            cbbAlteraEmpresa.DataSource = resultadoAltera;
            cbbAlteraEmpresa.DisplayMember = "nome";
            cbbAlteraEmpresa.ValueMember = "idempresa";

            cbEmpresas.SelectedIndex = -1;
            cbbAlteraEmpresa.SelectedIndex = -1;
            conexao.Fechar();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            gbEscolha.Visible = false;
            gbDados.Visible = false;
            gpbAltera.Visible = true;
            txtPesquisaNome.Focus();
        }

        void Pesquisar()
        {
            mdlManutencaoUsuario _mdlmanutencaousuario = new mdlManutencaoUsuario();
            _mdlmanutencaousuario.Nome = txtPesquisaNome.Text;
            DataTable usuario = ctlManutencaoUsuario.PesquisaNomeMDL(_mdlmanutencaousuario);
            dtgAlteraResultado.DataSource = usuario;
            //dtgAlteraResultado.DataSource = ctlManutencaoUsuario.PesquisaNomeMDL(_mdlmanutencaousuario);
            if (dtgAlteraResultado.Rows.Count == 0)
            {
                MessageBox.Show(" Pesquisa não teve resultado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPesquisaNome.Focus();
            }

            dtgAlteraResultado.Columns[0].HeaderText = "idusuario";
            dtgAlteraResultado.Columns[0].Visible = false;
            dtgAlteraResultado.Columns[1].HeaderText = "fk_idempresa";
            dtgAlteraResultado.Columns[1].Visible = false;
            dtgAlteraResultado.Columns[2].HeaderText = "Usuário";
            dtgAlteraResultado.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[3].HeaderText = "Nome";
            dtgAlteraResultado.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[4].HeaderText = "Telefone";
            dtgAlteraResultado.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[5].HeaderText = "Senha";
            dtgAlteraResultado.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgAlteraResultado.Columns[6].HeaderText = "Nível Acesso";
            dtgAlteraResultado.Columns[6].Visible = false;
            dtgAlteraResultado.Columns[7].HeaderText = "Ativo ?";
            dtgAlteraResultado.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }

        private void btnAlteraPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnAlteraCancelar_Click(object sender, EventArgs e)
        {
            gpbAltera.Visible = false;
            gbEscolha.Enabled = true;
            gbEscolha.Visible = true;
            limpar();
            btnVoltar.Focus();
        }

        private void dtgAlteraResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraUsuario.Text = dtgAlteraResultado.CurrentRow.Cells["usuario"].Value.ToString();
            txtAlteraNome.Text = dtgAlteraResultado.CurrentRow.Cells["nome"].Value.ToString();
            txtAlteraSenha.Text = dtgAlteraResultado.CurrentRow.Cells["senha"].Value.ToString();
            txtAlteraTelefone.Text = dtgAlteraResultado.CurrentRow.Cells["telefone"].Value.ToString();
            cbbAlteraNivel.SelectedIndex = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["nivelAcesso"].Value.ToString());
            cbbAlteraEmpresa.SelectedValue = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["fk_idempresa"].Value.ToString());
            ckbAlteraAtivo.Checked = Convert.ToBoolean(dtgAlteraResultado.CurrentRow.Cells["ativo"].Value.ToString());
            btnAlteraOK.Enabled = true;
        }

        private void btnAlteraOK_Click(object sender, EventArgs e)
        {

            if (txtAlteraUsuario.Text == "")
            {
               // txtVermAltUsuario.Visible = true;
                MessageBox.Show(" Usuário não pode ficar em Branco ");
                txtAlteraUsuario.Focus();
                return;
            }
            if (txtAlteraNome.Text == "")
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Nome não pode ficar em Branco ");
                txtAlteraNome.Focus();
                return;
            }
            if (txtAlteraSenha.Text == "")
            {
               // txtVermAltNome.Visible = true;
                MessageBox.Show(" Senha não pode ficar em Branco ");
                txtAlteraSenha.Focus();
                return;
            }
            if (txtAlteraTelefone.Text == "")
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Telefone não pode ficar em Branco ");
                txtAlteraTelefone.Focus();
                return;
            }
            if (cbbAlteraNivel.SelectedIndex == -1)
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Selecione um Nível ");
                cbbAlteraNivel.Focus();
                return;
            }
            if (cbbAlteraEmpresa.SelectedIndex == -1)
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Selecione uma Empresa ");
                cbbAlteraEmpresa.Focus();
                return;
            }

            string Anivel = "0";
            if (cbbAlteraNivel.Text == "Usuário")
            {
                Anivel = "0";
            }
            else if (cbbAlteraNivel.Text == "Técnico")
            {
                Anivel = "1";
            }
            else if (cbbAlteraNivel.Text == "Administrador")
            {
                Anivel = "2";
            }

            mdlManutencaoUsuario _mdlManutencaoUsuarioVer = new mdlManutencaoUsuario();
            _mdlManutencaoUsuarioVer.Usuario = txtAlteraUsuario.Text;
            _mdlManutencaoUsuarioVer.IDUsuario = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idusuario"].Value.ToString());
            bool duplicado = ctlManutencaoUsuario.VerificarDuplicidade(_mdlManutencaoUsuarioVer);
            if (duplicado)
            {
                MessageBox.Show(" Esse Usuário já está cadastrado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraUsuario.Focus();
                return;
            }

            mdlManutencaoUsuario _mdlmanutencaousuario = new mdlManutencaoUsuario();
            _mdlmanutencaousuario.Usuario = txtAlteraUsuario.Text;
            _mdlmanutencaousuario.Nome = txtAlteraNome.Text;
            _mdlmanutencaousuario.Senha = txtAlteraSenha.Text;
            _mdlmanutencaousuario.Telefone = txtAlteraTelefone.Text;
            _mdlmanutencaousuario.Nivel = Anivel;
            _mdlmanutencaousuario.Empresa = Convert.ToInt16(cbbAlteraEmpresa.SelectedValue.ToString());
            //_mdlmanutencaousuario.Empresa = cbbAlteraEmpresa.SelectedIndex;
            _mdlmanutencaousuario.Ativo = ckbAlteraAtivo.Checked;
            _mdlmanutencaousuario.IDUsuario = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idusuario"].Value.ToString());
            dtgAlteraResultado.DataSource = ctlManutencaoUsuario.AlteraUsuarioMDL(_mdlmanutencaousuario);
            btnAlteraOK.Enabled = false;

            bool retorno1 = ctlManutencaoUsuario.AlteraUsuarioMDL(_mdlmanutencaousuario);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso");
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterar");
            }
        }

        private void txtPesquisaNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
