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

namespace helpdesk2018.View
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
            mskTelefone.Text = "";
            cbNivel.SelectedIndex = -1;
            cbEmpresas.SelectedIndex = -1;

            txtAlteraNome.Text = "";
            txtAlteraSenha.Text = "";
            mskAlteraTelefone.Text = "";
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

        public void CadastrarUsusario()
        {
            string branco = "0";

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = "1";
                txtUsuario.Focus();
            }
            else if (txtNome.Text == "")
            {
                MessageBox.Show("Nome não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = "1";
                txtNome.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = "1";
                txtSenha.Focus();
            }
            else if (mskTelefone.Text == "")
            {
                MessageBox.Show("Telefone não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = "1";
                mskTelefone.Focus();
            }
            else if (cbNivel.Text == "")
            {
                MessageBox.Show("Nivel não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                branco = "1";
                cbNivel.Focus();
            }
            else if (cbEmpresas.Text == "")
            {
                MessageBox.Show("Empresa não pode ficar em branco !", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    MessageBox.Show(" Esse Usuário já está cadastrado ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Focus();
                    return;
                }

                if (branco == "0")
                {
                    mdlManutencaoUsuario _mdlManutencaoUsuario = new mdlManutencaoUsuario();
                    _mdlManutencaoUsuario.Usuario = txtUsuario.Text;
                    _mdlManutencaoUsuario.Nome = txtNome.Text;
                    _mdlManutencaoUsuario.Senha = txtSenha.Text;
                    _mdlManutencaoUsuario.Telefone = mskTelefone.Text;
                    _mdlManutencaoUsuario.Nivel = nivel;
                    _mdlManutencaoUsuario.Empresa = Convert.ToInt16(cbEmpresas.SelectedValue.ToString());
                    _mdlManutencaoUsuario.Ativo = ckbAtivo.Checked;

                    bool retorno1 = ctlManutencaoUsuario.InserirUsuarioMDL(_mdlManutencaoUsuario);
                    if (retorno1)
                    {
                        MessageBox.Show("Usuário gravado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpar();
                        gbEscolha.Enabled = true;
                        gbDados.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao Gravar !!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            CadastrarUsusario();
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
            if (frmMenu.PCD == true)
            {
                btnIncluirAMaior.Visible = true;
                btnIncluirAMenor.Visible = true;
                btnAlteraAMaior.Visible = true;
                btnAlteraAMenor.Visible = true;
            }
            else
            {
                btnIncluirAMaior.Visible = false;
                btnIncluirAMenor.Visible = false;
                btnAlteraAMaior.Visible = false;
                btnAlteraAMenor.Visible = false;
            }

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
                MessageBox.Show(" Pesquisa não teve resultado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            gpbConfirmaAlteracao.Enabled = false;
            limpar();
            btnVoltar.Focus();
        }

        private void dtgAlteraResultado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAlteraUsuario.Text = dtgAlteraResultado.CurrentRow.Cells["usuario"].Value.ToString();
            txtAlteraNome.Text = dtgAlteraResultado.CurrentRow.Cells["nome"].Value.ToString();
            txtAlteraSenha.Text = dtgAlteraResultado.CurrentRow.Cells["senha"].Value.ToString();
            mskAlteraTelefone.Text = dtgAlteraResultado.CurrentRow.Cells["telefone"].Value.ToString();
            cbbAlteraNivel.SelectedIndex = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["nivelAcesso"].Value.ToString());
            cbbAlteraEmpresa.SelectedValue = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["fk_idempresa"].Value.ToString());
            ckbAlteraAtivo.Checked = Convert.ToBoolean(dtgAlteraResultado.CurrentRow.Cells["ativo"].Value.ToString());
            gpbConfirmaAlteracao.Enabled = true;
        }

        public void AlteraUsuario()
        {
            if (txtAlteraUsuario.Text == "")
            {
                // txtVermAltUsuario.Visible = true;
                MessageBox.Show(" Usuário não pode ficar em Branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraUsuario.Focus();
                return;
            }
            if (txtAlteraNome.Text == "")
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Nome não pode ficar em Branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraNome.Focus();
                return;
            }
            if (txtAlteraSenha.Text == "")
            {
                // txtVermAltNome.Visible = true;
                MessageBox.Show(" Senha não pode ficar em Branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraSenha.Focus();
                return;
            }
            if (mskAlteraTelefone.Text == "")
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Telefone não pode ficar em Branco ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mskAlteraTelefone.Focus();
                return;
            }
            if (cbbAlteraNivel.SelectedIndex == -1)
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Selecione um Nível ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbbAlteraNivel.Focus();
                return;
            }
            if (cbbAlteraEmpresa.SelectedIndex == -1)
            {
                //txtVermAltNome.Visible = true;
                MessageBox.Show(" Selecione uma Empresa ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show(" Esse Usuário já está cadastrado ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAlteraUsuario.Focus();
                return;
            }

            mdlManutencaoUsuario _mdlmanutencaousuario = new mdlManutencaoUsuario();
            _mdlmanutencaousuario.Usuario = txtAlteraUsuario.Text;
            _mdlmanutencaousuario.Nome = txtAlteraNome.Text;
            _mdlmanutencaousuario.Senha = txtAlteraSenha.Text;
            _mdlmanutencaousuario.Telefone = mskAlteraTelefone.Text;
            _mdlmanutencaousuario.Nivel = Anivel;
            _mdlmanutencaousuario.Empresa = Convert.ToInt16(cbbAlteraEmpresa.SelectedValue.ToString());
            //_mdlmanutencaousuario.Empresa = cbbAlteraEmpresa.SelectedIndex;
            _mdlmanutencaousuario.Ativo = ckbAlteraAtivo.Checked;
            _mdlmanutencaousuario.IDUsuario = Convert.ToInt16(dtgAlteraResultado.CurrentRow.Cells["idusuario"].Value.ToString());
            dtgAlteraResultado.DataSource = ctlManutencaoUsuario.AlteraUsuarioMDL(_mdlmanutencaousuario);
            gpbConfirmaAlteracao.Enabled = false;

            bool retorno1 = ctlManutencaoUsuario.AlteraUsuarioMDL(_mdlmanutencaousuario);
            if (retorno1)
            {
                MessageBox.Show("Dados alterados com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAlteraOK_Click(object sender, EventArgs e)
        {
            AlteraUsuario();   
        }

        private void txtPesquisaNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== 13)
            {
                Pesquisar();
            }
        }

        private void txtAlteraUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtAlteraNome.Focus();
            }
        }

        private void txtAlteraNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar== 13)
            {
                txtAlteraSenha.Focus();
            }
        }

        private void txtAlteraSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                mskAlteraTelefone.Focus();
            }
        }

        private void cbbAlteraNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbbAlteraEmpresa.Focus();
            }
        }

        private void mskAlteraTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbbAlteraNivel.Focus();
            }
        }

        private void cbbAlteraEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                ckbAlteraAtivo.Focus();
            }
        }

        private void ckbAlteraAtivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AlteraUsuario();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Focus();
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
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
                mskTelefone.Focus();
            }
        }

        private void mskTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbNivel.Focus();
            }
        }

        private void cbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbEmpresas.Focus();
            }
        }

        private void cbEmpresas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CadastrarUsusario();
            }
        }

        public float tamanhoAtual = 8.25F;
        public void ItensPCD()
        {
            gbEscolha.Font = new Font(gbEscolha.Font.Name, tamanhoAtual);
            btnIncluir.Font = new Font(btnIncluir.Font.Name, tamanhoAtual);
            btnAlterar.Font = new Font(btnAlterar.Font.Name, tamanhoAtual);
            btnVoltar.Font = new Font(btnVoltar.Font.Name, tamanhoAtual);

            gbDados.Font = new Font(gbDados.Font.Name, tamanhoAtual);
            lblIncluirUsuario.Font = new Font(lblIncluirUsuario.Font.Name, tamanhoAtual);
            lblIncluirNome.Font = new Font(lblIncluirNome.Font.Name, tamanhoAtual);
            lblIncluirSenha.Font = new Font(lblIncluirSenha.Font.Name, tamanhoAtual);
            lblIncluirTelefone.Font = new Font(lblIncluirTelefone.Font.Name, tamanhoAtual);
            lblIncluirNivel.Font = new Font(lblIncluirNivel.Font.Name, tamanhoAtual);
            lblIncluirEmpresa.Font = new Font(lblIncluirEmpresa.Font.Name, tamanhoAtual);
            txtUsuario.Font = new Font(txtUsuario.Font.Name, tamanhoAtual);
            txtNome.Font = new Font(txtNome.Font.Name, tamanhoAtual);
            txtSenha.Font = new Font(txtSenha.Font.Name, tamanhoAtual);
            mskTelefone.Font = new Font(mskTelefone.Font.Name, tamanhoAtual);
            cbNivel.Font = new Font(cbNivel.Font.Name, tamanhoAtual);
            cbEmpresas.Font = new Font(cbEmpresas.Font.Name, tamanhoAtual);
            btnCadastrar.Font = new Font(btnCadastrar.Font.Name, tamanhoAtual);
            btnIncluirVoltar.Font = new Font(btnIncluirVoltar.Font.Name, tamanhoAtual);

            gpbAltera.Font = new Font(gpbAltera.Font.Name, tamanhoAtual);
            lblPesquisaNome.Font = new Font(lblPesquisaNome.Font.Name, tamanhoAtual);
            txtPesquisaNome.Font = new Font(txtPesquisaNome.Font.Name, tamanhoAtual);
            btnAlteraPesquisa.Font = new Font(btnAlteraPesquisa.Font.Name, tamanhoAtual);
            dtgAlteraResultado.Font = new Font(dtgAlteraResultado.Font.Name, tamanhoAtual);
            lblAlteraUsuario.Font = new Font(lblAlteraUsuario.Font.Name, tamanhoAtual);
            txtAlteraUsuario.Font = new Font(txtAlteraUsuario.Font.Name, tamanhoAtual);
            lblAlteraNome.Font = new Font(lblAlteraNome.Font.Name, tamanhoAtual);
            txtAlteraNome.Font = new Font(txtAlteraNome.Font.Name, tamanhoAtual);
            lblAlteraSenha.Font = new Font(lblAlteraSenha.Font.Name, tamanhoAtual);
            txtAlteraSenha.Font = new Font(txtAlteraSenha.Font.Name, tamanhoAtual);
            lblAlteraTelefone.Font = new Font(lblAlteraTelefone.Font.Name, tamanhoAtual);
            mskAlteraTelefone.Font = new Font(mskAlteraTelefone.Font.Name, tamanhoAtual);
            lblAlteraNivel.Font = new Font(lblAlteraNivel.Font.Name, tamanhoAtual);
            cbbAlteraNivel.Font = new Font(cbbAlteraNivel.Font.Name, tamanhoAtual);
            lblAlteraEmpresa.Font = new Font(lblAlteraEmpresa.Font.Name, tamanhoAtual);
            cbbAlteraEmpresa.Font = new Font(cbbAlteraEmpresa.Font.Name, tamanhoAtual);
            ckbAtivo.Font = new Font(ckbAtivo.Font.Name, tamanhoAtual);
            btnAlteraOK.Font = new Font(btnAlteraOK.Font.Name, tamanhoAtual);
            btnAlteraCancelar.Font = new Font(btnAlteraCancelar.Font.Name, tamanhoAtual);
        }
        private void btnAlteraAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnAlteraAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                txtPesquisaNome.Focus();
            }
            if (tamanhoAtual > 12)
            {
                btnAlteraAMaior.Enabled = false;
            }
        }

        private void btnIncluirAMaior_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual > 6)
            {
                btnIncluirAMenor.Enabled = true;
                tamanhoAtual += 2.0F;
                ItensPCD();
                txtUsuario.Focus();
            }
            if (tamanhoAtual > 12)
            {
                btnIncluirAMaior.Enabled = false;
            }
        }

        private void btnIncluirAMenor_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual < 14)
            {
                btnIncluirAMaior.Enabled = true;
                tamanhoAtual -= 2.0F;
                ItensPCD();
                txtUsuario.Focus();
            }
            if (tamanhoAtual < 8)
            {
                btnIncluirAMenor.Enabled = false;
            }
        }

        private void btnAlteraAMenor_Click(object sender, EventArgs e)
        {
            if (tamanhoAtual < 14)
            {
                btnAlteraAMaior.Enabled = true;
                tamanhoAtual -= 2.0F;
                ItensPCD();
                txtPesquisaNome.Focus();
            }
            if (tamanhoAtual < 8)
            {
                btnAlteraAMenor.Enabled = false;
            }
        }
    }
}
