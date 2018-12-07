namespace helpdesk2018
{
    partial class frmManutencaoUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbEscolha = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.gpbAltera = new System.Windows.Forms.GroupBox();
            this.dtgAlteraResultado = new System.Windows.Forms.DataGridView();
            this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fk_idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivelAcesso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnAlteraPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisaNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ckbAlteraAtivo = new System.Windows.Forms.CheckBox();
            this.txtAlteraTelefone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbAlteraEmpresa = new System.Windows.Forms.ComboBox();
            this.btnAlteraCancelar = new System.Windows.Forms.Button();
            this.txtAlteraUsuario = new System.Windows.Forms.TextBox();
            this.btnAlteraOK = new System.Windows.Forms.Button();
            this.cbbAlteraNivel = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAlteraSenha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbEscolha.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.gpbAltera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEscolha
            // 
            this.gbEscolha.Controls.Add(this.btnVoltar);
            this.gbEscolha.Controls.Add(this.btnAlterar);
            this.gbEscolha.Controls.Add(this.btnIncluir);
            this.gbEscolha.Location = new System.Drawing.Point(350, 12);
            this.gbEscolha.Name = "gbEscolha";
            this.gbEscolha.Size = new System.Drawing.Size(90, 362);
            this.gbEscolha.TabIndex = 5;
            this.gbEscolha.TabStop = false;
            this.gbEscolha.Text = "Escolha: ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(6, 328);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "&Sair";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(6, 72);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(6, 28);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(155, 318);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "&Voltar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(51, 318);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "&Cadastrar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nível:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(96, 35);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(133, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(96, 111);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(133, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Usuário",
            "Técnico",
            "Administrador"});
            this.cbNivel.Location = new System.Drawing.Point(96, 187);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(133, 21);
            this.cbNivel.TabIndex = 4;
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.ckbAtivo);
            this.gbDados.Controls.Add(this.txtTelefone);
            this.gbDados.Controls.Add(this.label6);
            this.gbDados.Controls.Add(this.label5);
            this.gbDados.Controls.Add(this.cbEmpresas);
            this.gbDados.Controls.Add(this.btnCancelar);
            this.gbDados.Controls.Add(this.txtUsuario);
            this.gbDados.Controls.Add(this.btnOK);
            this.gbDados.Controls.Add(this.cbNivel);
            this.gbDados.Controls.Add(this.label1);
            this.gbDados.Controls.Add(this.txtSenha);
            this.gbDados.Controls.Add(this.label2);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.label3);
            this.gbDados.Controls.Add(this.label4);
            this.gbDados.Location = new System.Drawing.Point(19, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(307, 362);
            this.gbDados.TabIndex = 4;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Incluir:";
            this.gbDados.Visible = false;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Checked = true;
            this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivo.Location = new System.Drawing.Point(42, 274);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAtivo.Size = new System.Drawing.Size(68, 17);
            this.ckbAtivo.TabIndex = 6;
            this.ckbAtivo.Text = "  : Ativo  ";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            this.ckbAtivo.Visible = false;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(96, 149);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(133, 20);
            this.txtTelefone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Telefone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Empresa: ";
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(96, 226);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(133, 21);
            this.cbEmpresas.TabIndex = 5;
            // 
            // gpbAltera
            // 
            this.gpbAltera.Controls.Add(this.dtgAlteraResultado);
            this.gpbAltera.Controls.Add(this.btnAlteraPesquisa);
            this.gpbAltera.Controls.Add(this.txtPesquisaNome);
            this.gpbAltera.Controls.Add(this.label13);
            this.gpbAltera.Controls.Add(this.ckbAlteraAtivo);
            this.gpbAltera.Controls.Add(this.txtAlteraTelefone);
            this.gpbAltera.Controls.Add(this.label7);
            this.gpbAltera.Controls.Add(this.label8);
            this.gpbAltera.Controls.Add(this.cbbAlteraEmpresa);
            this.gpbAltera.Controls.Add(this.btnAlteraCancelar);
            this.gpbAltera.Controls.Add(this.txtAlteraUsuario);
            this.gpbAltera.Controls.Add(this.btnAlteraOK);
            this.gpbAltera.Controls.Add(this.cbbAlteraNivel);
            this.gpbAltera.Controls.Add(this.label9);
            this.gpbAltera.Controls.Add(this.txtAlteraSenha);
            this.gpbAltera.Controls.Add(this.label10);
            this.gpbAltera.Controls.Add(this.txtAlteraNome);
            this.gpbAltera.Controls.Add(this.label11);
            this.gpbAltera.Controls.Add(this.label12);
            this.gpbAltera.Location = new System.Drawing.Point(12, 11);
            this.gpbAltera.Name = "gpbAltera";
            this.gpbAltera.Size = new System.Drawing.Size(428, 357);
            this.gpbAltera.TabIndex = 0;
            this.gpbAltera.TabStop = false;
            this.gpbAltera.Text = "Alterar dados: ";
            this.gpbAltera.Visible = false;
            // 
            // dtgAlteraResultado
            // 
            this.dtgAlteraResultado.AllowUserToAddRows = false;
            this.dtgAlteraResultado.AllowUserToDeleteRows = false;
            this.dtgAlteraResultado.AllowUserToResizeRows = false;
            this.dtgAlteraResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuario,
            this.fk_idempresa,
            this.usuario,
            this.nome,
            this.telefone,
            this.senha,
            this.nivelAcesso,
            this.ativo});
            this.dtgAlteraResultado.Location = new System.Drawing.Point(17, 59);
            this.dtgAlteraResultado.MultiSelect = false;
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.ReadOnly = true;
            this.dtgAlteraResultado.RowHeadersVisible = false;
            this.dtgAlteraResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraResultado.Size = new System.Drawing.Size(396, 150);
            this.dtgAlteraResultado.TabIndex = 27;
            this.dtgAlteraResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlteraResultado_CellClick);
            // 
            // idusuario
            // 
            this.idusuario.DataPropertyName = "idusuario";
            this.idusuario.HeaderText = "idusuario";
            this.idusuario.Name = "idusuario";
            this.idusuario.ReadOnly = true;
            this.idusuario.Visible = false;
            // 
            // fk_idempresa
            // 
            this.fk_idempresa.DataPropertyName = "fk_idempresa";
            this.fk_idempresa.HeaderText = "fk_idempresa";
            this.fk_idempresa.Name = "fk_idempresa";
            this.fk_idempresa.ReadOnly = true;
            this.fk_idempresa.Visible = false;
            // 
            // usuario
            // 
            this.usuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "Usuário";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // nivelAcesso
            // 
            this.nivelAcesso.DataPropertyName = "nivelAcesso";
            this.nivelAcesso.HeaderText = "Nível de Acesso";
            this.nivelAcesso.Name = "nivelAcesso";
            this.nivelAcesso.ReadOnly = true;
            this.nivelAcesso.Visible = false;
            // 
            // ativo
            // 
            this.ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo ?";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Width = 46;
            // 
            // btnAlteraPesquisa
            // 
            this.btnAlteraPesquisa.Location = new System.Drawing.Point(338, 24);
            this.btnAlteraPesquisa.Name = "btnAlteraPesquisa";
            this.btnAlteraPesquisa.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraPesquisa.TabIndex = 1;
            this.btnAlteraPesquisa.Text = "&Pesquisar";
            this.btnAlteraPesquisa.UseVisualStyleBackColor = true;
            this.btnAlteraPesquisa.Click += new System.EventHandler(this.btnAlteraPesquisa_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Location = new System.Drawing.Point(99, 26);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(215, 20);
            this.txtPesquisaNome.TabIndex = 0;
            this.txtPesquisaNome.TextChanged += new System.EventHandler(this.txtPesquisaNome_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Pesquisar Nome:";
            // 
            // ckbAlteraAtivo
            // 
            this.ckbAlteraAtivo.AutoSize = true;
            this.ckbAlteraAtivo.Location = new System.Drawing.Point(14, 325);
            this.ckbAlteraAtivo.Name = "ckbAlteraAtivo";
            this.ckbAlteraAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAlteraAtivo.Size = new System.Drawing.Size(68, 17);
            this.ckbAlteraAtivo.TabIndex = 8;
            this.ckbAlteraAtivo.Text = "  : Ativo  ";
            this.ckbAlteraAtivo.UseVisualStyleBackColor = true;
            // 
            // txtAlteraTelefone
            // 
            this.txtAlteraTelefone.Location = new System.Drawing.Point(280, 260);
            this.txtAlteraTelefone.Name = "txtAlteraTelefone";
            this.txtAlteraTelefone.Size = new System.Drawing.Size(133, 20);
            this.txtAlteraTelefone.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(223, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Empresa: ";
            // 
            // cbbAlteraEmpresa
            // 
            this.cbbAlteraEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlteraEmpresa.FormattingEnabled = true;
            this.cbbAlteraEmpresa.Location = new System.Drawing.Point(280, 286);
            this.cbbAlteraEmpresa.Name = "cbbAlteraEmpresa";
            this.cbbAlteraEmpresa.Size = new System.Drawing.Size(133, 21);
            this.cbbAlteraEmpresa.TabIndex = 7;
            // 
            // btnAlteraCancelar
            // 
            this.btnAlteraCancelar.Location = new System.Drawing.Point(344, 323);
            this.btnAlteraCancelar.Name = "btnAlteraCancelar";
            this.btnAlteraCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraCancelar.TabIndex = 10;
            this.btnAlteraCancelar.Text = "&Voltar";
            this.btnAlteraCancelar.UseVisualStyleBackColor = true;
            this.btnAlteraCancelar.Click += new System.EventHandler(this.btnAlteraCancelar_Click);
            // 
            // txtAlteraUsuario
            // 
            this.txtAlteraUsuario.Location = new System.Drawing.Point(71, 234);
            this.txtAlteraUsuario.Name = "txtAlteraUsuario";
            this.txtAlteraUsuario.Size = new System.Drawing.Size(133, 20);
            this.txtAlteraUsuario.TabIndex = 2;
            // 
            // btnAlteraOK
            // 
            this.btnAlteraOK.Enabled = false;
            this.btnAlteraOK.Location = new System.Drawing.Point(226, 323);
            this.btnAlteraOK.Name = "btnAlteraOK";
            this.btnAlteraOK.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraOK.TabIndex = 9;
            this.btnAlteraOK.Text = "&Alterar";
            this.btnAlteraOK.UseVisualStyleBackColor = true;
            this.btnAlteraOK.Click += new System.EventHandler(this.btnAlteraOK_Click);
            // 
            // cbbAlteraNivel
            // 
            this.cbbAlteraNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlteraNivel.FormattingEnabled = true;
            this.cbbAlteraNivel.Items.AddRange(new object[] {
            "Usuário",
            "Técnico",
            "Administrador"});
            this.cbbAlteraNivel.Location = new System.Drawing.Point(71, 286);
            this.cbbAlteraNivel.Name = "cbbAlteraNivel";
            this.cbbAlteraNivel.Size = new System.Drawing.Size(133, 21);
            this.cbbAlteraNivel.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Usuário:";
            // 
            // txtAlteraSenha
            // 
            this.txtAlteraSenha.Location = new System.Drawing.Point(71, 260);
            this.txtAlteraSenha.Name = "txtAlteraSenha";
            this.txtAlteraSenha.Size = new System.Drawing.Size(133, 20);
            this.txtAlteraSenha.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(223, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Nome:";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(280, 234);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(133, 20);
            this.txtAlteraNome.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 263);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Senha:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nível:";
            // 
            // frmManutencaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 386);
            this.Controls.Add(this.gpbAltera);
            this.Controls.Add(this.gbEscolha);
            this.Controls.Add(this.gbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManutencaoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Usuário";
            this.Load += new System.EventHandler(this.frmManutencaoUsuario_Load);
            this.gbEscolha.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            this.gpbAltera.ResumeLayout(false);
            this.gpbAltera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEscolha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbAlteraAtivo;
        private System.Windows.Forms.TextBox txtAlteraTelefone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbAlteraEmpresa;
        private System.Windows.Forms.Button btnAlteraCancelar;
        private System.Windows.Forms.TextBox txtAlteraUsuario;
        private System.Windows.Forms.Button btnAlteraOK;
        private System.Windows.Forms.ComboBox cbbAlteraNivel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAlteraSenha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gpbAltera;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dtgAlteraResultado;
        private System.Windows.Forms.Button btnAlteraPesquisa;
        private System.Windows.Forms.TextBox txtPesquisaNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn fk_idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivelAcesso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativo;
    }
}