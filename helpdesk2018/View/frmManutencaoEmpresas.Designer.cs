namespace helpdesk2018.View
{
    partial class frmManutencaoEmpresas
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
            this.components = new System.ComponentModel.Container();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblIncNome = new System.Windows.Forms.Label();
            this.lblIncTelefone = new System.Windows.Forms.Label();
            this.lblIncEndereco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.ckbIncluirAtiva = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpIncluirEmpresa = new System.Windows.Forms.TabPage();
            this.btnIncluiAMaior = new System.Windows.Forms.Button();
            this.btnIncluiAMenor = new System.Windows.Forms.Button();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.VermIncNome = new System.Windows.Forms.TextBox();
            this.VermIncTelefone = new System.Windows.Forms.TextBox();
            this.VermIncEndereco = new System.Windows.Forms.TextBox();
            this.lblVermErroTelefone = new System.Windows.Forms.Label();
            this.lblVermErro = new System.Windows.Forms.Label();
            this.lblVermEndereco = new System.Windows.Forms.Label();
            this.tbpAlterarEmpresa = new System.Windows.Forms.TabPage();
            this.btnAlteraAMaior = new System.Windows.Forms.Button();
            this.btnAlteraAMenor = new System.Windows.Forms.Button();
            this.btnAlterarSair = new System.Windows.Forms.Button();
            this.gpbConfirmaAlteracao = new System.Windows.Forms.GroupBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.mskAlteraTelefone = new System.Windows.Forms.MaskedTextBox();
            this.VermAltTelefone = new System.Windows.Forms.TextBox();
            this.ckbAlteraAtiva = new System.Windows.Forms.CheckBox();
            this.VermAltNome = new System.Windows.Forms.TextBox();
            this.txtAlteraEndereco = new System.Windows.Forms.TextBox();
            this.btnAlterarOK = new System.Windows.Forms.Button();
            this.lblAlteraTelefone = new System.Windows.Forms.Label();
            this.lblAlteraNome = new System.Windows.Forms.Label();
            this.lblAlteraEndereco = new System.Windows.Forms.Label();
            this.VermAltEndereco = new System.Windows.Forms.TextBox();
            this.dtgAlteraResultado = new System.Windows.Forms.DataGridView();
            this.idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnPesquisarEmpresa = new System.Windows.Forms.Button();
            this.lblAltPEsquisaEmpresa = new System.Windows.Forms.Label();
            this.txtPesquisarEmpresa = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tbpIncluirEmpresa.SuspendLayout();
            this.tbpAlterarEmpresa.SuspendLayout();
            this.gpbConfirmaAlteracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(255, 264);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 27);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btnSair, "Sair da manutenção empresa");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(128, 263);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(92, 28);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrar, "Cadastrar a empresa");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lblIncNome
            // 
            this.lblIncNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIncNome.AutoSize = true;
            this.lblIncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncNome.Location = new System.Drawing.Point(40, 125);
            this.lblIncNome.Name = "lblIncNome";
            this.lblIncNome.Size = new System.Drawing.Size(38, 13);
            this.lblIncNome.TabIndex = 5;
            this.lblIncNome.Text = "Nome:";
            this.lblIncNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncTelefone
            // 
            this.lblIncTelefone.AutoSize = true;
            this.lblIncTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncTelefone.Location = new System.Drawing.Point(40, 160);
            this.lblIncTelefone.Name = "lblIncTelefone";
            this.lblIncTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblIncTelefone.TabIndex = 6;
            this.lblIncTelefone.Text = "Telefone:";
            this.lblIncTelefone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIncEndereco
            // 
            this.lblIncEndereco.AutoSize = true;
            this.lblIncEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncEndereco.Location = new System.Drawing.Point(40, 196);
            this.lblIncEndereco.Name = "lblIncEndereco";
            this.lblIncEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblIncEndereco.TabIndex = 7;
            this.lblIncEndereco.Text = "Endereço:";
            this.lblIncEndereco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(129, 124);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNome, "Incluir nome da empresa");
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(129, 195);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 20);
            this.txtEndereco.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtEndereco, "Incluir endereço da empresa");
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // ckbIncluirAtiva
            // 
            this.ckbIncluirAtiva.AutoSize = true;
            this.ckbIncluirAtiva.Checked = true;
            this.ckbIncluirAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbIncluirAtiva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbIncluirAtiva.Location = new System.Drawing.Point(40, 229);
            this.ckbIncluirAtiva.Name = "ckbIncluirAtiva";
            this.ckbIncluirAtiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbIncluirAtiva.Size = new System.Drawing.Size(68, 17);
            this.ckbIncluirAtiva.TabIndex = 12;
            this.ckbIncluirAtiva.Text = "    : Ativa";
            this.ckbIncluirAtiva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckbIncluirAtiva.UseVisualStyleBackColor = true;
            this.ckbIncluirAtiva.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tbpIncluirEmpresa);
            this.tabControl1.Controls.Add(this.tbpAlterarEmpresa);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(426, 438);
            this.tabControl1.TabIndex = 12;
            this.toolTip1.SetToolTip(this.tabControl1, "Selecione");
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tbpIncluirEmpresa
            // 
            this.tbpIncluirEmpresa.Controls.Add(this.btnIncluiAMaior);
            this.tbpIncluirEmpresa.Controls.Add(this.btnIncluiAMenor);
            this.tbpIncluirEmpresa.Controls.Add(this.mskTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.ckbIncluirAtiva);
            this.tbpIncluirEmpresa.Controls.Add(this.btnSair);
            this.tbpIncluirEmpresa.Controls.Add(this.lblIncNome);
            this.tbpIncluirEmpresa.Controls.Add(this.txtNome);
            this.tbpIncluirEmpresa.Controls.Add(this.btnCadastrar);
            this.tbpIncluirEmpresa.Controls.Add(this.lblIncEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.txtEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.lblIncTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.VermIncNome);
            this.tbpIncluirEmpresa.Controls.Add(this.VermIncTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.VermIncEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermErroTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermErro);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermEndereco);
            this.tbpIncluirEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpIncluirEmpresa.Name = "tbpIncluirEmpresa";
            this.tbpIncluirEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncluirEmpresa.Size = new System.Drawing.Size(418, 409);
            this.tbpIncluirEmpresa.TabIndex = 0;
            this.tbpIncluirEmpresa.Text = "Incluir Empresa";
            this.tbpIncluirEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnIncluiAMaior
            // 
            this.btnIncluiAMaior.Location = new System.Drawing.Point(387, 3);
            this.btnIncluiAMaior.Name = "btnIncluiAMaior";
            this.btnIncluiAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnIncluiAMaior.TabIndex = 20;
            this.btnIncluiAMaior.Text = "A+";
            this.toolTip1.SetToolTip(this.btnIncluiAMaior, "Aumentar Fonte");
            this.btnIncluiAMaior.UseVisualStyleBackColor = true;
            this.btnIncluiAMaior.Click += new System.EventHandler(this.btnIncluiAMaior_Click);
            // 
            // btnIncluiAMenor
            // 
            this.btnIncluiAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluiAMenor.Location = new System.Drawing.Point(364, 3);
            this.btnIncluiAMenor.Name = "btnIncluiAMenor";
            this.btnIncluiAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnIncluiAMenor.TabIndex = 19;
            this.btnIncluiAMenor.Text = "A-";
            this.toolTip1.SetToolTip(this.btnIncluiAMenor, "Diminuir Fonte");
            this.btnIncluiAMenor.UseVisualStyleBackColor = true;
            this.btnIncluiAMenor.Click += new System.EventHandler(this.btnIncluiAMenor_Click);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mskTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(129, 159);
            this.mskTelefone.Mask = "(99) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(211, 20);
            this.mskTelefone.TabIndex = 2;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.mskTelefone, "Incluir telefone da empresa");
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefone_KeyPress);
            // 
            // VermIncNome
            // 
            this.VermIncNome.BackColor = System.Drawing.Color.Red;
            this.VermIncNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermIncNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermIncNome.Location = new System.Drawing.Point(128, 123);
            this.VermIncNome.Name = "VermIncNome";
            this.VermIncNome.Size = new System.Drawing.Size(214, 22);
            this.VermIncNome.TabIndex = 13;
            this.VermIncNome.TabStop = false;
            this.VermIncNome.Visible = false;
            // 
            // VermIncTelefone
            // 
            this.VermIncTelefone.BackColor = System.Drawing.Color.Red;
            this.VermIncTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermIncTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermIncTelefone.Location = new System.Drawing.Point(128, 158);
            this.VermIncTelefone.Name = "VermIncTelefone";
            this.VermIncTelefone.Size = new System.Drawing.Size(213, 22);
            this.VermIncTelefone.TabIndex = 14;
            this.VermIncTelefone.TabStop = false;
            this.VermIncTelefone.Visible = false;
            // 
            // VermIncEndereco
            // 
            this.VermIncEndereco.BackColor = System.Drawing.Color.Red;
            this.VermIncEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermIncEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermIncEndereco.Location = new System.Drawing.Point(128, 194);
            this.VermIncEndereco.Name = "VermIncEndereco";
            this.VermIncEndereco.Size = new System.Drawing.Size(214, 22);
            this.VermIncEndereco.TabIndex = 15;
            this.VermIncEndereco.TabStop = false;
            this.VermIncEndereco.Visible = false;
            // 
            // lblVermErroTelefone
            // 
            this.lblVermErroTelefone.AutoSize = true;
            this.lblVermErroTelefone.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVermErroTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermErroTelefone.ForeColor = System.Drawing.Color.Red;
            this.lblVermErroTelefone.Location = new System.Drawing.Point(11, 54);
            this.lblVermErroTelefone.Name = "lblVermErroTelefone";
            this.lblVermErroTelefone.Size = new System.Drawing.Size(233, 13);
            this.lblVermErroTelefone.TabIndex = 17;
            this.lblVermErroTelefone.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermErroTelefone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVermErroTelefone.Visible = false;
            // 
            // lblVermErro
            // 
            this.lblVermErro.AutoSize = true;
            this.lblVermErro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVermErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermErro.ForeColor = System.Drawing.Color.Red;
            this.lblVermErro.Location = new System.Drawing.Point(11, 54);
            this.lblVermErro.Name = "lblVermErro";
            this.lblVermErro.Size = new System.Drawing.Size(233, 13);
            this.lblVermErro.TabIndex = 16;
            this.lblVermErro.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermErro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVermErro.Visible = false;
            // 
            // lblVermEndereco
            // 
            this.lblVermEndereco.AutoSize = true;
            this.lblVermEndereco.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblVermEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVermEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblVermEndereco.Location = new System.Drawing.Point(11, 54);
            this.lblVermEndereco.Name = "lblVermEndereco";
            this.lblVermEndereco.Size = new System.Drawing.Size(233, 13);
            this.lblVermEndereco.TabIndex = 18;
            this.lblVermEndereco.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermEndereco.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblVermEndereco.Visible = false;
            // 
            // tbpAlterarEmpresa
            // 
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlteraAMaior);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlteraAMenor);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlterarSair);
            this.tbpAlterarEmpresa.Controls.Add(this.gpbConfirmaAlteracao);
            this.tbpAlterarEmpresa.Controls.Add(this.dtgAlteraResultado);
            this.tbpAlterarEmpresa.Controls.Add(this.btnPesquisarEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.lblAltPEsquisaEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.txtPesquisarEmpresa);
            this.tbpAlterarEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpAlterarEmpresa.Name = "tbpAlterarEmpresa";
            this.tbpAlterarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterarEmpresa.Size = new System.Drawing.Size(418, 409);
            this.tbpAlterarEmpresa.TabIndex = 1;
            this.tbpAlterarEmpresa.Text = "Alterar Empresa";
            this.tbpAlterarEmpresa.UseVisualStyleBackColor = true;
            // 
            // btnAlteraAMaior
            // 
            this.btnAlteraAMaior.Location = new System.Drawing.Point(387, 3);
            this.btnAlteraAMaior.Name = "btnAlteraAMaior";
            this.btnAlteraAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAlteraAMaior.TabIndex = 13;
            this.btnAlteraAMaior.Text = "A+";
            this.toolTip1.SetToolTip(this.btnAlteraAMaior, "Aumentar Fonte");
            this.btnAlteraAMaior.UseVisualStyleBackColor = true;
            this.btnAlteraAMaior.Click += new System.EventHandler(this.btnAlteraAMaior_Click);
            // 
            // btnAlteraAMenor
            // 
            this.btnAlteraAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraAMenor.Location = new System.Drawing.Point(364, 3);
            this.btnAlteraAMenor.Name = "btnAlteraAMenor";
            this.btnAlteraAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAlteraAMenor.TabIndex = 12;
            this.btnAlteraAMenor.Text = "A-";
            this.toolTip1.SetToolTip(this.btnAlteraAMenor, "Diminuir Fonte");
            this.btnAlteraAMenor.UseVisualStyleBackColor = true;
            this.btnAlteraAMenor.Click += new System.EventHandler(this.btnAlteraAMenor_Click);
            // 
            // btnAlterarSair
            // 
            this.btnAlterarSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSair.Location = new System.Drawing.Point(327, 367);
            this.btnAlterarSair.Name = "btnAlterarSair";
            this.btnAlterarSair.Size = new System.Drawing.Size(75, 26);
            this.btnAlterarSair.TabIndex = 8;
            this.btnAlterarSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btnAlterarSair, "Sair da manutenção empresas");
            this.btnAlterarSair.UseVisualStyleBackColor = true;
            this.btnAlterarSair.Click += new System.EventHandler(this.btnAlterarCancelar_Click);
            // 
            // gpbConfirmaAlteracao
            // 
            this.gpbConfirmaAlteracao.Controls.Add(this.txtAlteraNome);
            this.gpbConfirmaAlteracao.Controls.Add(this.mskAlteraTelefone);
            this.gpbConfirmaAlteracao.Controls.Add(this.VermAltTelefone);
            this.gpbConfirmaAlteracao.Controls.Add(this.ckbAlteraAtiva);
            this.gpbConfirmaAlteracao.Controls.Add(this.VermAltNome);
            this.gpbConfirmaAlteracao.Controls.Add(this.txtAlteraEndereco);
            this.gpbConfirmaAlteracao.Controls.Add(this.btnAlterarOK);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraTelefone);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraNome);
            this.gpbConfirmaAlteracao.Controls.Add(this.lblAlteraEndereco);
            this.gpbConfirmaAlteracao.Controls.Add(this.VermAltEndereco);
            this.gpbConfirmaAlteracao.Enabled = false;
            this.gpbConfirmaAlteracao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gpbConfirmaAlteracao.Location = new System.Drawing.Point(3, 257);
            this.gpbConfirmaAlteracao.Name = "gpbConfirmaAlteracao";
            this.gpbConfirmaAlteracao.Size = new System.Drawing.Size(409, 148);
            this.gpbConfirmaAlteracao.TabIndex = 4;
            this.gpbConfirmaAlteracao.TabStop = false;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlteraNome.Location = new System.Drawing.Point(120, 15);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(279, 20);
            this.txtAlteraNome.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtAlteraNome, "Nome da empresa que pode ser alterada");
            this.txtAlteraNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraNome_KeyPress);
            // 
            // mskAlteraTelefone
            // 
            this.mskAlteraTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAlteraTelefone.Location = new System.Drawing.Point(120, 47);
            this.mskAlteraTelefone.Mask = "(99) 00000-0000";
            this.mskAlteraTelefone.Name = "mskAlteraTelefone";
            this.mskAlteraTelefone.Size = new System.Drawing.Size(136, 20);
            this.mskAlteraTelefone.TabIndex = 5;
            this.mskAlteraTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.toolTip1.SetToolTip(this.mskAlteraTelefone, "Telefone da empresa que pode ser mudada");
            this.mskAlteraTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskAlteraTelefone_KeyPress);
            // 
            // VermAltTelefone
            // 
            this.VermAltTelefone.BackColor = System.Drawing.Color.Red;
            this.VermAltTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermAltTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermAltTelefone.Location = new System.Drawing.Point(119, 46);
            this.VermAltTelefone.Name = "VermAltTelefone";
            this.VermAltTelefone.Size = new System.Drawing.Size(138, 22);
            this.VermAltTelefone.TabIndex = 11;
            this.VermAltTelefone.TabStop = false;
            this.VermAltTelefone.Visible = false;
            // 
            // ckbAlteraAtiva
            // 
            this.ckbAlteraAtiva.AutoSize = true;
            this.ckbAlteraAtiva.Checked = true;
            this.ckbAlteraAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAlteraAtiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlteraAtiva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbAlteraAtiva.Location = new System.Drawing.Point(310, 49);
            this.ckbAlteraAtiva.Name = "ckbAlteraAtiva";
            this.ckbAlteraAtiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAlteraAtiva.Size = new System.Drawing.Size(68, 17);
            this.ckbAlteraAtiva.TabIndex = 7;
            this.ckbAlteraAtiva.Text = "    : Ativa";
            this.toolTip1.SetToolTip(this.ckbAlteraAtiva, "Selecione se está ativa ou não");
            this.ckbAlteraAtiva.UseVisualStyleBackColor = true;
            this.ckbAlteraAtiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ckbAlteraAtiva_KeyPress);
            // 
            // VermAltNome
            // 
            this.VermAltNome.BackColor = System.Drawing.Color.Red;
            this.VermAltNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermAltNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermAltNome.Location = new System.Drawing.Point(119, 14);
            this.VermAltNome.Name = "VermAltNome";
            this.VermAltNome.Size = new System.Drawing.Size(281, 22);
            this.VermAltNome.TabIndex = 10;
            this.VermAltNome.TabStop = false;
            this.VermAltNome.Visible = false;
            // 
            // txtAlteraEndereco
            // 
            this.txtAlteraEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlteraEndereco.Location = new System.Drawing.Point(121, 80);
            this.txtAlteraEndereco.Name = "txtAlteraEndereco";
            this.txtAlteraEndereco.Size = new System.Drawing.Size(276, 20);
            this.txtAlteraEndereco.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtAlteraEndereco, "Endereço da empresa que pode ser mudada");
            this.txtAlteraEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraEndereco_KeyPress);
            // 
            // btnAlterarOK
            // 
            this.btnAlterarOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarOK.Location = new System.Drawing.Point(10, 110);
            this.btnAlterarOK.Name = "btnAlterarOK";
            this.btnAlterarOK.Size = new System.Drawing.Size(75, 27);
            this.btnAlterarOK.TabIndex = 8;
            this.btnAlterarOK.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlterarOK, "Salvar as alterações");
            this.btnAlterarOK.UseVisualStyleBackColor = true;
            this.btnAlterarOK.Click += new System.EventHandler(this.btnAlterarOK_Click);
            // 
            // lblAlteraTelefone
            // 
            this.lblAlteraTelefone.AutoSize = true;
            this.lblAlteraTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraTelefone.Location = new System.Drawing.Point(7, 50);
            this.lblAlteraTelefone.Name = "lblAlteraTelefone";
            this.lblAlteraTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblAlteraTelefone.TabIndex = 6;
            this.lblAlteraTelefone.Text = "Telefone:";
            // 
            // lblAlteraNome
            // 
            this.lblAlteraNome.AutoSize = true;
            this.lblAlteraNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraNome.Location = new System.Drawing.Point(7, 18);
            this.lblAlteraNome.Name = "lblAlteraNome";
            this.lblAlteraNome.Size = new System.Drawing.Size(38, 13);
            this.lblAlteraNome.TabIndex = 5;
            this.lblAlteraNome.Text = "Nome:";
            // 
            // lblAlteraEndereco
            // 
            this.lblAlteraEndereco.AutoSize = true;
            this.lblAlteraEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraEndereco.Location = new System.Drawing.Point(7, 83);
            this.lblAlteraEndereco.Name = "lblAlteraEndereco";
            this.lblAlteraEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblAlteraEndereco.TabIndex = 7;
            this.lblAlteraEndereco.Text = "Endereço:";
            // 
            // VermAltEndereco
            // 
            this.VermAltEndereco.BackColor = System.Drawing.Color.Red;
            this.VermAltEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VermAltEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VermAltEndereco.Location = new System.Drawing.Point(120, 79);
            this.VermAltEndereco.Name = "VermAltEndereco";
            this.VermAltEndereco.Size = new System.Drawing.Size(278, 22);
            this.VermAltEndereco.TabIndex = 12;
            this.VermAltEndereco.Visible = false;
            // 
            // dtgAlteraResultado
            // 
            this.dtgAlteraResultado.AllowUserToAddRows = false;
            this.dtgAlteraResultado.AllowUserToDeleteRows = false;
            this.dtgAlteraResultado.AllowUserToResizeRows = false;
            this.dtgAlteraResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idempresa,
            this.nome,
            this.telefone,
            this.endereco,
            this.ativa});
            this.dtgAlteraResultado.Location = new System.Drawing.Point(8, 79);
            this.dtgAlteraResultado.MultiSelect = false;
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.ReadOnly = true;
            this.dtgAlteraResultado.RowHeadersVisible = false;
            this.dtgAlteraResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraResultado.Size = new System.Drawing.Size(403, 176);
            this.dtgAlteraResultado.TabIndex = 3;
            this.dtgAlteraResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlterarResultado_CellClick);
            // 
            // idempresa
            // 
            this.idempresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idempresa.DataPropertyName = "idempresa";
            this.idempresa.HeaderText = "idempresa";
            this.idempresa.Name = "idempresa";
            this.idempresa.ReadOnly = true;
            this.idempresa.Visible = false;
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
            // endereco
            // 
            this.endereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endereco.DataPropertyName = "endereco";
            this.endereco.HeaderText = "Endereço";
            this.endereco.Name = "endereco";
            this.endereco.ReadOnly = true;
            // 
            // ativa
            // 
            this.ativa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ativa.DataPropertyName = "ativa";
            this.ativa.HeaderText = "Ativa ?";
            this.ativa.Name = "ativa";
            this.ativa.ReadOnly = true;
            this.ativa.Width = 46;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(320, 32);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(91, 30);
            this.btnPesquisarEmpresa.TabIndex = 2;
            this.btnPesquisarEmpresa.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisarEmpresa, "Pesquisar empresa");
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = true;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // lblAltPEsquisaEmpresa
            // 
            this.lblAltPEsquisaEmpresa.AutoSize = true;
            this.lblAltPEsquisaEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltPEsquisaEmpresa.Location = new System.Drawing.Point(6, 12);
            this.lblAltPEsquisaEmpresa.Name = "lblAltPEsquisaEmpresa";
            this.lblAltPEsquisaEmpresa.Size = new System.Drawing.Size(100, 13);
            this.lblAltPEsquisaEmpresa.TabIndex = 8;
            this.lblAltPEsquisaEmpresa.Text = "Pesquisar Empresa:";
            // 
            // txtPesquisarEmpresa
            // 
            this.txtPesquisarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarEmpresa.Location = new System.Drawing.Point(6, 38);
            this.txtPesquisarEmpresa.Name = "txtPesquisarEmpresa";
            this.txtPesquisarEmpresa.Size = new System.Drawing.Size(308, 20);
            this.txtPesquisarEmpresa.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPesquisarEmpresa, "Nome da empresa a pesquisar");
            this.txtPesquisarEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarEmpresa_KeyPress);
            // 
            // frmManutencaoEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 462);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmManutencaoEmpresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Empresas";
            this.Load += new System.EventHandler(this.frmManutencaoEmpresas_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpIncluirEmpresa.ResumeLayout(false);
            this.tbpIncluirEmpresa.PerformLayout();
            this.tbpAlterarEmpresa.ResumeLayout(false);
            this.tbpAlterarEmpresa.PerformLayout();
            this.gpbConfirmaAlteracao.ResumeLayout(false);
            this.gpbConfirmaAlteracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblIncNome;
        private System.Windows.Forms.Label lblIncTelefone;
        private System.Windows.Forms.Label lblIncEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpIncluirEmpresa;
        private System.Windows.Forms.TabPage tbpAlterarEmpresa;
        private System.Windows.Forms.Button btnAlterarSair;
        private System.Windows.Forms.Label lblAlteraNome;
        private System.Windows.Forms.Button btnAlterarOK;
        private System.Windows.Forms.TextBox txtAlteraEndereco;
        private System.Windows.Forms.Label lblAlteraTelefone;
        private System.Windows.Forms.Label lblAlteraEndereco;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label lblAltPEsquisaEmpresa;
        private System.Windows.Forms.Button btnPesquisarEmpresa;
        private System.Windows.Forms.TextBox txtPesquisarEmpresa;
        private System.Windows.Forms.CheckBox ckbIncluirAtiva;
        private System.Windows.Forms.CheckBox ckbAlteraAtiva;
        private System.Windows.Forms.DataGridView dtgAlteraResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativa;
        private System.Windows.Forms.TextBox VermIncNome;
        private System.Windows.Forms.TextBox VermIncTelefone;
        private System.Windows.Forms.TextBox VermIncEndereco;
        private System.Windows.Forms.TextBox VermAltNome;
        private System.Windows.Forms.TextBox VermAltTelefone;
        private System.Windows.Forms.TextBox VermAltEndereco;
        private System.Windows.Forms.Label lblVermErro;
        private System.Windows.Forms.Label lblVermErroTelefone;
        private System.Windows.Forms.Label lblVermEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskAlteraTelefone;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gpbConfirmaAlteracao;
        private System.Windows.Forms.Button btnIncluiAMaior;
        private System.Windows.Forms.Button btnIncluiAMenor;
        private System.Windows.Forms.Button btnAlteraAMaior;
        private System.Windows.Forms.Button btnAlteraAMenor;
    }
}