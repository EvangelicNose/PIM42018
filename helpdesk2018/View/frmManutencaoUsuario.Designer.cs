namespace helpdesk2018.View
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
            this.btnIncluirVoltar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblIncluirUsuario = new System.Windows.Forms.Label();
            this.lblIncluirNome = new System.Windows.Forms.Label();
            this.lblIncluirSenha = new System.Windows.Forms.Label();
            this.lblIncluirNivel = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.btnIncluirAMaior = new System.Windows.Forms.Button();
            this.btnIncluirAMenor = new System.Windows.Forms.Button();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.lblIncluirTelefone = new System.Windows.Forms.Label();
            this.lblIncluirEmpresa = new System.Windows.Forms.Label();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.gpbAltera = new System.Windows.Forms.GroupBox();
            this.btnAlteraAMaior = new System.Windows.Forms.Button();
            this.btnAlteraAMenor = new System.Windows.Forms.Button();
            this.btnAlteraCancelar = new System.Windows.Forms.Button();
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
            this.lblPesquisaNome = new System.Windows.Forms.Label();
            this.gpbConfirmaAlteracao = new System.Windows.Forms.GroupBox();
            this.txtAlteraUsuario = new System.Windows.Forms.TextBox();
            this.mskAlteraTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblAlteraNivel = new System.Windows.Forms.Label();
            this.lblAlteraSenha = new System.Windows.Forms.Label();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.lblAlteraNome = new System.Windows.Forms.Label();
            this.txtAlteraSenha = new System.Windows.Forms.TextBox();
            this.ckbAlteraAtivo = new System.Windows.Forms.CheckBox();
            this.lblAlteraUsuario = new System.Windows.Forms.Label();
            this.lblAlteraTelefone = new System.Windows.Forms.Label();
            this.cbbAlteraNivel = new System.Windows.Forms.ComboBox();
            this.lblAlteraEmpresa = new System.Windows.Forms.Label();
            this.btnAlteraOK = new System.Windows.Forms.Button();
            this.cbbAlteraEmpresa = new System.Windows.Forms.ComboBox();
            this.gbEscolha.SuspendLayout();
            this.gbDados.SuspendLayout();
            this.gpbAltera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).BeginInit();
            this.gpbConfirmaAlteracao.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEscolha
            // 
            this.gbEscolha.Controls.Add(this.btnVoltar);
            this.gbEscolha.Controls.Add(this.btnAlterar);
            this.gbEscolha.Controls.Add(this.btnIncluir);
            this.gbEscolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEscolha.Location = new System.Drawing.Point(421, 12);
            this.gbEscolha.Name = "gbEscolha";
            this.gbEscolha.Size = new System.Drawing.Size(110, 437);
            this.gbEscolha.TabIndex = 5;
            this.gbEscolha.TabStop = false;
            this.gbEscolha.Text = "Escolha: ";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(18, 387);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 28);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "&Sair";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(18, 99);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 28);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Location = new System.Drawing.Point(18, 38);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 28);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIncluirVoltar
            // 
            this.btnIncluirVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirVoltar.Location = new System.Drawing.Point(268, 387);
            this.btnIncluirVoltar.Name = "btnIncluirVoltar";
            this.btnIncluirVoltar.Size = new System.Drawing.Size(90, 28);
            this.btnIncluirVoltar.TabIndex = 8;
            this.btnIncluirVoltar.Text = "&Voltar";
            this.btnIncluirVoltar.UseVisualStyleBackColor = true;
            this.btnIncluirVoltar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(38, 387);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(90, 28);
            this.btnCadastrar.TabIndex = 7;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblIncluirUsuario
            // 
            this.lblIncluirUsuario.AutoSize = true;
            this.lblIncluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirUsuario.Location = new System.Drawing.Point(24, 65);
            this.lblIncluirUsuario.Name = "lblIncluirUsuario";
            this.lblIncluirUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblIncluirUsuario.TabIndex = 2;
            this.lblIncluirUsuario.Text = "Usuário:";
            // 
            // lblIncluirNome
            // 
            this.lblIncluirNome.AutoSize = true;
            this.lblIncluirNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirNome.Location = new System.Drawing.Point(24, 103);
            this.lblIncluirNome.Name = "lblIncluirNome";
            this.lblIncluirNome.Size = new System.Drawing.Size(38, 13);
            this.lblIncluirNome.TabIndex = 3;
            this.lblIncluirNome.Text = "Nome:";
            // 
            // lblIncluirSenha
            // 
            this.lblIncluirSenha.AutoSize = true;
            this.lblIncluirSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirSenha.Location = new System.Drawing.Point(24, 141);
            this.lblIncluirSenha.Name = "lblIncluirSenha";
            this.lblIncluirSenha.Size = new System.Drawing.Size(41, 13);
            this.lblIncluirSenha.TabIndex = 4;
            this.lblIncluirSenha.Text = "Senha:";
            // 
            // lblIncluirNivel
            // 
            this.lblIncluirNivel.AutoSize = true;
            this.lblIncluirNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirNivel.Location = new System.Drawing.Point(24, 217);
            this.lblIncluirNivel.Name = "lblIncluirNivel";
            this.lblIncluirNivel.Size = new System.Drawing.Size(36, 13);
            this.lblIncluirNivel.TabIndex = 5;
            this.lblIncluirNivel.Text = "Nível:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(108, 62);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(108, 100);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(251, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(108, 138);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(251, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Usuário",
            "Técnico",
            "Administrador"});
            this.cbNivel.Location = new System.Drawing.Point(108, 214);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(135, 21);
            this.cbNivel.TabIndex = 4;
            this.cbNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbNivel_KeyPress);
            // 
            // gbDados
            // 
            this.gbDados.Controls.Add(this.btnIncluirAMaior);
            this.gbDados.Controls.Add(this.btnIncluirAMenor);
            this.gbDados.Controls.Add(this.mskTelefone);
            this.gbDados.Controls.Add(this.ckbAtivo);
            this.gbDados.Controls.Add(this.lblIncluirTelefone);
            this.gbDados.Controls.Add(this.lblIncluirEmpresa);
            this.gbDados.Controls.Add(this.cbEmpresas);
            this.gbDados.Controls.Add(this.btnIncluirVoltar);
            this.gbDados.Controls.Add(this.txtUsuario);
            this.gbDados.Controls.Add(this.btnCadastrar);
            this.gbDados.Controls.Add(this.cbNivel);
            this.gbDados.Controls.Add(this.lblIncluirUsuario);
            this.gbDados.Controls.Add(this.txtSenha);
            this.gbDados.Controls.Add(this.lblIncluirNome);
            this.gbDados.Controls.Add(this.txtNome);
            this.gbDados.Controls.Add(this.lblIncluirSenha);
            this.gbDados.Controls.Add(this.lblIncluirNivel);
            this.gbDados.Location = new System.Drawing.Point(12, 12);
            this.gbDados.Name = "gbDados";
            this.gbDados.Size = new System.Drawing.Size(393, 437);
            this.gbDados.TabIndex = 4;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Incluir:";
            this.gbDados.Visible = false;
            // 
            // btnIncluirAMaior
            // 
            this.btnIncluirAMaior.Location = new System.Drawing.Point(359, 11);
            this.btnIncluirAMaior.Name = "btnIncluirAMaior";
            this.btnIncluirAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnIncluirAMaior.TabIndex = 22;
            this.btnIncluirAMaior.Text = "A+";
            this.btnIncluirAMaior.UseVisualStyleBackColor = true;
            this.btnIncluirAMaior.Click += new System.EventHandler(this.btnIncluirAMaior_Click);
            // 
            // btnIncluirAMenor
            // 
            this.btnIncluirAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluirAMenor.Location = new System.Drawing.Point(336, 11);
            this.btnIncluirAMenor.Name = "btnIncluirAMenor";
            this.btnIncluirAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnIncluirAMenor.TabIndex = 21;
            this.btnIncluirAMenor.Text = "A-";
            this.btnIncluirAMenor.UseVisualStyleBackColor = true;
            this.btnIncluirAMenor.Click += new System.EventHandler(this.btnIncluirAMenor_Click);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(108, 176);
            this.mskTelefone.Mask = "(99) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(135, 20);
            this.mskTelefone.TabIndex = 3;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefone_KeyPress);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Checked = true;
            this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAtivo.Location = new System.Drawing.Point(24, 306);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAtivo.Size = new System.Drawing.Size(68, 17);
            this.ckbAtivo.TabIndex = 6;
            this.ckbAtivo.Text = "  : Ativo  ";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            this.ckbAtivo.Visible = false;
            // 
            // lblIncluirTelefone
            // 
            this.lblIncluirTelefone.AutoSize = true;
            this.lblIncluirTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirTelefone.Location = new System.Drawing.Point(24, 179);
            this.lblIncluirTelefone.Name = "lblIncluirTelefone";
            this.lblIncluirTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblIncluirTelefone.TabIndex = 7;
            this.lblIncluirTelefone.Text = "Telefone:";
            // 
            // lblIncluirEmpresa
            // 
            this.lblIncluirEmpresa.AutoSize = true;
            this.lblIncluirEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirEmpresa.Location = new System.Drawing.Point(24, 257);
            this.lblIncluirEmpresa.Name = "lblIncluirEmpresa";
            this.lblIncluirEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblIncluirEmpresa.TabIndex = 5;
            this.lblIncluirEmpresa.Text = "Empresa:";
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(108, 254);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(251, 21);
            this.cbEmpresas.TabIndex = 5;
            this.cbEmpresas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbEmpresas_KeyPress);
            // 
            // gpbAltera
            // 
            this.gpbAltera.Controls.Add(this.btnAlteraAMaior);
            this.gpbAltera.Controls.Add(this.btnAlteraAMenor);
            this.gpbAltera.Controls.Add(this.btnAlteraCancelar);
            this.gpbAltera.Controls.Add(this.dtgAlteraResultado);
            this.gpbAltera.Controls.Add(this.btnAlteraPesquisa);
            this.gpbAltera.Controls.Add(this.txtPesquisaNome);
            this.gpbAltera.Controls.Add(this.lblPesquisaNome);
            this.gpbAltera.Controls.Add(this.gpbConfirmaAlteracao);
            this.gpbAltera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAltera.Location = new System.Drawing.Point(12, 11);
            this.gpbAltera.Name = "gpbAltera";
            this.gpbAltera.Size = new System.Drawing.Size(519, 438);
            this.gpbAltera.TabIndex = 0;
            this.gpbAltera.TabStop = false;
            this.gpbAltera.Text = "Alterar dados: ";
            this.gpbAltera.Visible = false;
            // 
            // btnAlteraAMaior
            // 
            this.btnAlteraAMaior.Location = new System.Drawing.Point(487, 12);
            this.btnAlteraAMaior.Name = "btnAlteraAMaior";
            this.btnAlteraAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAlteraAMaior.TabIndex = 22;
            this.btnAlteraAMaior.Text = "A+";
            this.btnAlteraAMaior.UseVisualStyleBackColor = true;
            this.btnAlteraAMaior.Click += new System.EventHandler(this.btnAlteraAMaior_Click);
            // 
            // btnAlteraAMenor
            // 
            this.btnAlteraAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraAMenor.Location = new System.Drawing.Point(464, 12);
            this.btnAlteraAMenor.Name = "btnAlteraAMenor";
            this.btnAlteraAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAlteraAMenor.TabIndex = 21;
            this.btnAlteraAMenor.Text = "A-";
            this.btnAlteraAMenor.UseVisualStyleBackColor = true;
            this.btnAlteraAMenor.Click += new System.EventHandler(this.btnAlteraAMenor_Click);
            // 
            // btnAlteraCancelar
            // 
            this.btnAlteraCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraCancelar.Location = new System.Drawing.Point(428, 393);
            this.btnAlteraCancelar.Name = "btnAlteraCancelar";
            this.btnAlteraCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnAlteraCancelar.TabIndex = 11;
            this.btnAlteraCancelar.Text = "&Voltar";
            this.btnAlteraCancelar.UseVisualStyleBackColor = true;
            this.btnAlteraCancelar.Click += new System.EventHandler(this.btnAlteraCancelar_Click);
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
            this.dtgAlteraResultado.Location = new System.Drawing.Point(14, 87);
            this.dtgAlteraResultado.MultiSelect = false;
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.ReadOnly = true;
            this.dtgAlteraResultado.RowHeadersVisible = false;
            this.dtgAlteraResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraResultado.Size = new System.Drawing.Size(488, 193);
            this.dtgAlteraResultado.TabIndex = 2;
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
            this.btnAlteraPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraPesquisa.Location = new System.Drawing.Point(409, 54);
            this.btnAlteraPesquisa.Name = "btnAlteraPesquisa";
            this.btnAlteraPesquisa.Size = new System.Drawing.Size(93, 27);
            this.btnAlteraPesquisa.TabIndex = 1;
            this.btnAlteraPesquisa.Text = "&Pesquisar";
            this.btnAlteraPesquisa.UseVisualStyleBackColor = true;
            this.btnAlteraPesquisa.Click += new System.EventHandler(this.btnAlteraPesquisa_Click);
            // 
            // txtPesquisaNome
            // 
            this.txtPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaNome.Location = new System.Drawing.Point(14, 54);
            this.txtPesquisaNome.Name = "txtPesquisaNome";
            this.txtPesquisaNome.Size = new System.Drawing.Size(376, 20);
            this.txtPesquisaNome.TabIndex = 0;
            this.txtPesquisaNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisaNome_KeyPress);
            // 
            // lblPesquisaNome
            // 
            this.lblPesquisaNome.AutoSize = true;
            this.lblPesquisaNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisaNome.Location = new System.Drawing.Point(9, 27);
            this.lblPesquisaNome.Name = "lblPesquisaNome";
            this.lblPesquisaNome.Size = new System.Drawing.Size(87, 13);
            this.lblPesquisaNome.TabIndex = 15;
            this.lblPesquisaNome.Text = "Pesquisar Nome:";
            // 
            // gpbConfirmaAlteracao
            // 
            this.gpbConfirmaAlteracao.Controls.Add(this.txtAlteraUsuario);
            this.gpbConfirmaAlteracao.Controls.Add(this.mskAlteraTelefone);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraNivel);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraSenha);
            this.gpbConfirmaAlteracao.Controls.Add(this.txtAlteraNome);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraNome);
            this.gpbConfirmaAlteracao.Controls.Add(this.txtAlteraSenha);
            this.gpbConfirmaAlteracao.Controls.Add(this.ckbAlteraAtivo);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraUsuario);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraTelefone);
            this.gpbConfirmaAlteracao.Controls.Add(this.cbbAlteraNivel);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraEmpresa);
            this.gpbConfirmaAlteracao.Controls.Add(this.btnAlteraOK);
            this.gpbConfirmaAlteracao.Controls.Add(this.cbbAlteraEmpresa);
            this.gpbConfirmaAlteracao.Enabled = false;
            this.gpbConfirmaAlteracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbConfirmaAlteracao.Location = new System.Drawing.Point(6, 277);
            this.gpbConfirmaAlteracao.Name = "gpbConfirmaAlteracao";
            this.gpbConfirmaAlteracao.Size = new System.Drawing.Size(507, 152);
            this.gpbConfirmaAlteracao.TabIndex = 6;
            this.gpbConfirmaAlteracao.TabStop = false;
            // 
            // txtAlteraUsuario
            // 
            this.txtAlteraUsuario.Location = new System.Drawing.Point(72, 15);
            this.txtAlteraUsuario.Name = "txtAlteraUsuario";
            this.txtAlteraUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtAlteraUsuario.TabIndex = 3;
            this.txtAlteraUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraUsuario_KeyPress);
            // 
            // mskAlteraTelefone
            // 
            this.mskAlteraTelefone.Location = new System.Drawing.Point(335, 44);
            this.mskAlteraTelefone.Mask = "(99) 00000-0000";
            this.mskAlteraTelefone.Name = "mskAlteraTelefone";
            this.mskAlteraTelefone.Size = new System.Drawing.Size(166, 20);
            this.mskAlteraTelefone.TabIndex = 6;
            this.mskAlteraTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAlteraTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskAlteraTelefone_KeyPress);
            // 
            // lblAlteraNivel
            // 
            this.lblAlteraNivel.AutoSize = true;
            this.lblAlteraNivel.Location = new System.Drawing.Point(8, 76);
            this.lblAlteraNivel.Name = "lblAlteraNivel";
            this.lblAlteraNivel.Size = new System.Drawing.Size(36, 13);
            this.lblAlteraNivel.TabIndex = 20;
            this.lblAlteraNivel.Text = "Nível:";
            // 
            // lblAlteraSenha
            // 
            this.lblAlteraSenha.AutoSize = true;
            this.lblAlteraSenha.Location = new System.Drawing.Point(8, 47);
            this.lblAlteraSenha.Name = "lblAlteraSenha";
            this.lblAlteraSenha.Size = new System.Drawing.Size(41, 13);
            this.lblAlteraSenha.TabIndex = 17;
            this.lblAlteraSenha.Text = "Senha:";
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(335, 15);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(166, 20);
            this.txtAlteraNome.TabIndex = 4;
            this.txtAlteraNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraNome_KeyPress);
            // 
            // lblAlteraNome
            // 
            this.lblAlteraNome.AutoSize = true;
            this.lblAlteraNome.Location = new System.Drawing.Point(246, 18);
            this.lblAlteraNome.Name = "lblAlteraNome";
            this.lblAlteraNome.Size = new System.Drawing.Size(38, 13);
            this.lblAlteraNome.TabIndex = 15;
            this.lblAlteraNome.Text = "Nome:";
            // 
            // txtAlteraSenha
            // 
            this.txtAlteraSenha.Location = new System.Drawing.Point(72, 44);
            this.txtAlteraSenha.Name = "txtAlteraSenha";
            this.txtAlteraSenha.Size = new System.Drawing.Size(169, 20);
            this.txtAlteraSenha.TabIndex = 5;
            this.txtAlteraSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraSenha_KeyPress);
            // 
            // ckbAlteraAtivo
            // 
            this.ckbAlteraAtivo.AutoSize = true;
            this.ckbAlteraAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlteraAtivo.Location = new System.Drawing.Point(8, 120);
            this.ckbAlteraAtivo.Name = "ckbAlteraAtivo";
            this.ckbAlteraAtivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAlteraAtivo.Size = new System.Drawing.Size(68, 17);
            this.ckbAlteraAtivo.TabIndex = 9;
            this.ckbAlteraAtivo.Text = "  : Ativo  ";
            this.ckbAlteraAtivo.UseVisualStyleBackColor = true;
            this.ckbAlteraAtivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbAlteraAtivo_KeyPress);
            // 
            // lblAlteraUsuario
            // 
            this.lblAlteraUsuario.AutoSize = true;
            this.lblAlteraUsuario.Location = new System.Drawing.Point(8, 18);
            this.lblAlteraUsuario.Name = "lblAlteraUsuario";
            this.lblAlteraUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblAlteraUsuario.TabIndex = 12;
            this.lblAlteraUsuario.Text = "Usuário:";
            // 
            // lblAlteraTelefone
            // 
            this.lblAlteraTelefone.AutoSize = true;
            this.lblAlteraTelefone.Location = new System.Drawing.Point(246, 47);
            this.lblAlteraTelefone.Name = "lblAlteraTelefone";
            this.lblAlteraTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblAlteraTelefone.TabIndex = 22;
            this.lblAlteraTelefone.Text = "Telefone:";
            // 
            // cbbAlteraNivel
            // 
            this.cbbAlteraNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlteraNivel.FormattingEnabled = true;
            this.cbbAlteraNivel.Items.AddRange(new object[] {
            "Usuário",
            "Técnico",
            "Administrador"});
            this.cbbAlteraNivel.Location = new System.Drawing.Point(72, 73);
            this.cbbAlteraNivel.Name = "cbbAlteraNivel";
            this.cbbAlteraNivel.Size = new System.Drawing.Size(169, 21);
            this.cbbAlteraNivel.TabIndex = 7;
            this.cbbAlteraNivel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbAlteraNivel_KeyPress);
            // 
            // lblAlteraEmpresa
            // 
            this.lblAlteraEmpresa.AutoSize = true;
            this.lblAlteraEmpresa.Location = new System.Drawing.Point(246, 75);
            this.lblAlteraEmpresa.Name = "lblAlteraEmpresa";
            this.lblAlteraEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblAlteraEmpresa.TabIndex = 18;
            this.lblAlteraEmpresa.Text = "Empresa:";
            // 
            // btnAlteraOK
            // 
            this.btnAlteraOK.Location = new System.Drawing.Point(250, 116);
            this.btnAlteraOK.Name = "btnAlteraOK";
            this.btnAlteraOK.Size = new System.Drawing.Size(80, 30);
            this.btnAlteraOK.TabIndex = 10;
            this.btnAlteraOK.Text = "&Alterar";
            this.btnAlteraOK.UseVisualStyleBackColor = true;
            this.btnAlteraOK.Click += new System.EventHandler(this.btnAlteraOK_Click);
            // 
            // cbbAlteraEmpresa
            // 
            this.cbbAlteraEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAlteraEmpresa.FormattingEnabled = true;
            this.cbbAlteraEmpresa.Location = new System.Drawing.Point(335, 73);
            this.cbbAlteraEmpresa.Name = "cbbAlteraEmpresa";
            this.cbbAlteraEmpresa.Size = new System.Drawing.Size(166, 21);
            this.cbbAlteraEmpresa.TabIndex = 8;
            this.cbbAlteraEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbAlteraEmpresa_KeyPress);
            // 
            // frmManutencaoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 461);
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
            this.gpbConfirmaAlteracao.ResumeLayout(false);
            this.gpbConfirmaAlteracao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEscolha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnIncluirVoltar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblIncluirUsuario;
        private System.Windows.Forms.Label lblIncluirNome;
        private System.Windows.Forms.Label lblIncluirSenha;
        private System.Windows.Forms.Label lblIncluirNivel;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.Label lblIncluirEmpresa;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.Label lblIncluirTelefone;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbAlteraAtivo;
        private System.Windows.Forms.Label lblAlteraTelefone;
        private System.Windows.Forms.Label lblAlteraEmpresa;
        private System.Windows.Forms.ComboBox cbbAlteraEmpresa;
        private System.Windows.Forms.Button btnAlteraCancelar;
        private System.Windows.Forms.TextBox txtAlteraUsuario;
        private System.Windows.Forms.Button btnAlteraOK;
        private System.Windows.Forms.ComboBox cbbAlteraNivel;
        private System.Windows.Forms.Label lblAlteraUsuario;
        private System.Windows.Forms.TextBox txtAlteraSenha;
        private System.Windows.Forms.Label lblAlteraNome;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label lblAlteraSenha;
        private System.Windows.Forms.Label lblAlteraNivel;
        private System.Windows.Forms.GroupBox gpbAltera;
        private System.Windows.Forms.Label lblPesquisaNome;
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
        private System.Windows.Forms.MaskedTextBox mskAlteraTelefone;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.GroupBox gpbConfirmaAlteracao;
        private System.Windows.Forms.Button btnAlteraAMaior;
        private System.Windows.Forms.Button btnAlteraAMenor;
        private System.Windows.Forms.Button btnIncluirAMaior;
        private System.Windows.Forms.Button btnIncluirAMenor;
    }
}