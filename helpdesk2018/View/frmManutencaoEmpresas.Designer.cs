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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.ckbIncluirAtiva = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpIncluirEmpresa = new System.Windows.Forms.TabPage();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtVermIncNome = new System.Windows.Forms.TextBox();
            this.txtVermIncTelefone = new System.Windows.Forms.TextBox();
            this.txtVermIncEndereco = new System.Windows.Forms.TextBox();
            this.lblVermErroTelefone = new System.Windows.Forms.Label();
            this.lblVermErro = new System.Windows.Forms.Label();
            this.lblVermEndereco = new System.Windows.Forms.Label();
            this.tbpAlterarEmpresa = new System.Windows.Forms.TabPage();
            this.mskAlteraTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtgAlteraResultado = new System.Windows.Forms.DataGridView();
            this.idempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativa = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckbAlteraAtiva = new System.Windows.Forms.CheckBox();
            this.btnPesquisarEmpresa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPesquisarEmpresa = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterarCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterarOK = new System.Windows.Forms.Button();
            this.txtAlteraEndereco = new System.Windows.Forms.TextBox();
            this.txtVermAltNome = new System.Windows.Forms.TextBox();
            this.txtVermAltTelefone = new System.Windows.Forms.TextBox();
            this.txtVermAltEndereco = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbpIncluirEmpresa.SuspendLayout();
            this.tbpAlterarEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Sair";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(44, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Cadastrar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(102, 81);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(212, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 146);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 20);
            this.txtEndereco.TabIndex = 3;
            this.txtEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEndereco_KeyPress);
            // 
            // ckbIncluirAtiva
            // 
            this.ckbIncluirAtiva.AutoSize = true;
            this.ckbIncluirAtiva.Checked = true;
            this.ckbIncluirAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbIncluirAtiva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbIncluirAtiva.Location = new System.Drawing.Point(47, 176);
            this.ckbIncluirAtiva.Name = "ckbIncluirAtiva";
            this.ckbIncluirAtiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbIncluirAtiva.Size = new System.Drawing.Size(68, 17);
            this.ckbIncluirAtiva.TabIndex = 12;
            this.ckbIncluirAtiva.Text = "    : Ativa";
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
            this.tabControl1.Size = new System.Drawing.Size(362, 374);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tbpIncluirEmpresa
            // 
            this.tbpIncluirEmpresa.Controls.Add(this.mskTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.ckbIncluirAtiva);
            this.tbpIncluirEmpresa.Controls.Add(this.btnCancelar);
            this.tbpIncluirEmpresa.Controls.Add(this.label1);
            this.tbpIncluirEmpresa.Controls.Add(this.txtNome);
            this.tbpIncluirEmpresa.Controls.Add(this.btnOK);
            this.tbpIncluirEmpresa.Controls.Add(this.label3);
            this.tbpIncluirEmpresa.Controls.Add(this.txtEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.label2);
            this.tbpIncluirEmpresa.Controls.Add(this.txtVermIncNome);
            this.tbpIncluirEmpresa.Controls.Add(this.txtVermIncTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.txtVermIncEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermErroTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermErro);
            this.tbpIncluirEmpresa.Controls.Add(this.lblVermEndereco);
            this.tbpIncluirEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpIncluirEmpresa.Name = "tbpIncluirEmpresa";
            this.tbpIncluirEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncluirEmpresa.Size = new System.Drawing.Size(354, 345);
            this.tbpIncluirEmpresa.TabIndex = 0;
            this.tbpIncluirEmpresa.Text = "Incluir Empresa";
            this.tbpIncluirEmpresa.UseVisualStyleBackColor = true;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(102, 113);
            this.mskTelefone.Mask = "(99) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 19;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskTelefone_KeyPress);
            // 
            // txtVermIncNome
            // 
            this.txtVermIncNome.BackColor = System.Drawing.Color.Red;
            this.txtVermIncNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermIncNome.Location = new System.Drawing.Point(101, 80);
            this.txtVermIncNome.Multiline = true;
            this.txtVermIncNome.Name = "txtVermIncNome";
            this.txtVermIncNome.Size = new System.Drawing.Size(214, 22);
            this.txtVermIncNome.TabIndex = 13;
            this.txtVermIncNome.TabStop = false;
            this.txtVermIncNome.Visible = false;
            // 
            // txtVermIncTelefone
            // 
            this.txtVermIncTelefone.BackColor = System.Drawing.Color.Red;
            this.txtVermIncTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermIncTelefone.Location = new System.Drawing.Point(101, 112);
            this.txtVermIncTelefone.Multiline = true;
            this.txtVermIncTelefone.Name = "txtVermIncTelefone";
            this.txtVermIncTelefone.Size = new System.Drawing.Size(102, 22);
            this.txtVermIncTelefone.TabIndex = 14;
            this.txtVermIncTelefone.TabStop = false;
            this.txtVermIncTelefone.Visible = false;
            // 
            // txtVermIncEndereco
            // 
            this.txtVermIncEndereco.BackColor = System.Drawing.Color.Red;
            this.txtVermIncEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermIncEndereco.Location = new System.Drawing.Point(101, 145);
            this.txtVermIncEndereco.Multiline = true;
            this.txtVermIncEndereco.Name = "txtVermIncEndereco";
            this.txtVermIncEndereco.Size = new System.Drawing.Size(214, 22);
            this.txtVermIncEndereco.TabIndex = 15;
            this.txtVermIncEndereco.TabStop = false;
            this.txtVermIncEndereco.Visible = false;
            // 
            // lblVermErroTelefone
            // 
            this.lblVermErroTelefone.AutoSize = true;
            this.lblVermErroTelefone.ForeColor = System.Drawing.Color.Red;
            this.lblVermErroTelefone.Location = new System.Drawing.Point(80, 38);
            this.lblVermErroTelefone.Name = "lblVermErroTelefone";
            this.lblVermErroTelefone.Size = new System.Drawing.Size(233, 13);
            this.lblVermErroTelefone.TabIndex = 17;
            this.lblVermErroTelefone.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermErroTelefone.Visible = false;
            // 
            // lblVermErro
            // 
            this.lblVermErro.AutoSize = true;
            this.lblVermErro.ForeColor = System.Drawing.Color.Red;
            this.lblVermErro.Location = new System.Drawing.Point(80, 38);
            this.lblVermErro.Name = "lblVermErro";
            this.lblVermErro.Size = new System.Drawing.Size(233, 13);
            this.lblVermErro.TabIndex = 16;
            this.lblVermErro.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermErro.Visible = false;
            // 
            // lblVermEndereco
            // 
            this.lblVermEndereco.AutoSize = true;
            this.lblVermEndereco.ForeColor = System.Drawing.Color.Red;
            this.lblVermEndereco.Location = new System.Drawing.Point(80, 38);
            this.lblVermEndereco.Name = "lblVermEndereco";
            this.lblVermEndereco.Size = new System.Drawing.Size(233, 13);
            this.lblVermEndereco.TabIndex = 18;
            this.lblVermEndereco.Text = "Campo em vermelho, não pode ficar em branco ";
            this.lblVermEndereco.Visible = false;
            // 
            // tbpAlterarEmpresa
            // 
            this.tbpAlterarEmpresa.Controls.Add(this.mskAlteraTelefone);
            this.tbpAlterarEmpresa.Controls.Add(this.dtgAlteraResultado);
            this.tbpAlterarEmpresa.Controls.Add(this.ckbAlteraAtiva);
            this.tbpAlterarEmpresa.Controls.Add(this.btnPesquisarEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.label7);
            this.tbpAlterarEmpresa.Controls.Add(this.txtPesquisarEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.txtAlteraNome);
            this.tbpAlterarEmpresa.Controls.Add(this.label6);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlterarCancelar);
            this.tbpAlterarEmpresa.Controls.Add(this.label4);
            this.tbpAlterarEmpresa.Controls.Add(this.label5);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlterarOK);
            this.tbpAlterarEmpresa.Controls.Add(this.txtAlteraEndereco);
            this.tbpAlterarEmpresa.Controls.Add(this.txtVermAltNome);
            this.tbpAlterarEmpresa.Controls.Add(this.txtVermAltTelefone);
            this.tbpAlterarEmpresa.Controls.Add(this.txtVermAltEndereco);
            this.tbpAlterarEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpAlterarEmpresa.Name = "tbpAlterarEmpresa";
            this.tbpAlterarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterarEmpresa.Size = new System.Drawing.Size(354, 345);
            this.tbpAlterarEmpresa.TabIndex = 1;
            this.tbpAlterarEmpresa.Text = "Alterar Empresa";
            this.tbpAlterarEmpresa.UseVisualStyleBackColor = true;
            // 
            // mskAlteraTelefone
            // 
            this.mskAlteraTelefone.Location = new System.Drawing.Point(64, 253);
            this.mskAlteraTelefone.Mask = "(99) 00000-0000";
            this.mskAlteraTelefone.Name = "mskAlteraTelefone";
            this.mskAlteraTelefone.Size = new System.Drawing.Size(97, 20);
            this.mskAlteraTelefone.TabIndex = 13;
            this.mskAlteraTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskAlteraTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskAlteraTelefone_KeyPress);
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
            this.dtgAlteraResultado.Location = new System.Drawing.Point(9, 38);
            this.dtgAlteraResultado.MultiSelect = false;
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.ReadOnly = true;
            this.dtgAlteraResultado.RowHeadersVisible = false;
            this.dtgAlteraResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgAlteraResultado.Size = new System.Drawing.Size(339, 176);
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
            // ckbAlteraAtiva
            // 
            this.ckbAlteraAtiva.AutoSize = true;
            this.ckbAlteraAtiva.Checked = true;
            this.ckbAlteraAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAlteraAtiva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbAlteraAtiva.Location = new System.Drawing.Point(273, 255);
            this.ckbAlteraAtiva.Name = "ckbAlteraAtiva";
            this.ckbAlteraAtiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAlteraAtiva.Size = new System.Drawing.Size(68, 17);
            this.ckbAlteraAtiva.TabIndex = 7;
            this.ckbAlteraAtiva.Text = "    : Ativa";
            this.ckbAlteraAtiva.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(282, 10);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(66, 23);
            this.btnPesquisarEmpresa.TabIndex = 2;
            this.btnPesquisarEmpresa.Text = "Pesquisar";
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = true;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pesquisar Empresa:";
            // 
            // txtPesquisarEmpresa
            // 
            this.txtPesquisarEmpresa.Location = new System.Drawing.Point(108, 12);
            this.txtPesquisarEmpresa.Name = "txtPesquisarEmpresa";
            this.txtPesquisarEmpresa.Size = new System.Drawing.Size(168, 20);
            this.txtPesquisarEmpresa.TabIndex = 1;
            this.txtPesquisarEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisarEmpresa_KeyPress);
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(64, 221);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(284, 20);
            this.txtAlteraNome.TabIndex = 4;
            this.txtAlteraNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraNome_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço:";
            // 
            // btnAlterarCancelar
            // 
            this.btnAlterarCancelar.Location = new System.Drawing.Point(273, 316);
            this.btnAlterarCancelar.Name = "btnAlterarCancelar";
            this.btnAlterarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCancelar.TabIndex = 9;
            this.btnAlterarCancelar.Text = "Sair";
            this.btnAlterarCancelar.UseVisualStyleBackColor = true;
            this.btnAlterarCancelar.Click += new System.EventHandler(this.btnAlterarCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone:";
            // 
            // btnAlterarOK
            // 
            this.btnAlterarOK.Enabled = false;
            this.btnAlterarOK.Location = new System.Drawing.Point(6, 316);
            this.btnAlterarOK.Name = "btnAlterarOK";
            this.btnAlterarOK.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarOK.TabIndex = 8;
            this.btnAlterarOK.Text = "Alterar";
            this.btnAlterarOK.UseVisualStyleBackColor = true;
            this.btnAlterarOK.Click += new System.EventHandler(this.btnAlterarOK_Click);
            // 
            // txtAlteraEndereco
            // 
            this.txtAlteraEndereco.Location = new System.Drawing.Point(66, 286);
            this.txtAlteraEndereco.Name = "txtAlteraEndereco";
            this.txtAlteraEndereco.Size = new System.Drawing.Size(281, 20);
            this.txtAlteraEndereco.TabIndex = 6;
            this.txtAlteraEndereco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlteraEndereco_KeyPress);
            // 
            // txtVermAltNome
            // 
            this.txtVermAltNome.BackColor = System.Drawing.Color.Red;
            this.txtVermAltNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermAltNome.Location = new System.Drawing.Point(63, 220);
            this.txtVermAltNome.Multiline = true;
            this.txtVermAltNome.Name = "txtVermAltNome";
            this.txtVermAltNome.Size = new System.Drawing.Size(286, 22);
            this.txtVermAltNome.TabIndex = 10;
            this.txtVermAltNome.TabStop = false;
            this.txtVermAltNome.Visible = false;
            // 
            // txtVermAltTelefone
            // 
            this.txtVermAltTelefone.BackColor = System.Drawing.Color.Red;
            this.txtVermAltTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermAltTelefone.Location = new System.Drawing.Point(63, 252);
            this.txtVermAltTelefone.Multiline = true;
            this.txtVermAltTelefone.Name = "txtVermAltTelefone";
            this.txtVermAltTelefone.Size = new System.Drawing.Size(99, 22);
            this.txtVermAltTelefone.TabIndex = 11;
            this.txtVermAltTelefone.TabStop = false;
            this.txtVermAltTelefone.Visible = false;
            // 
            // txtVermAltEndereco
            // 
            this.txtVermAltEndereco.BackColor = System.Drawing.Color.Red;
            this.txtVermAltEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVermAltEndereco.Location = new System.Drawing.Point(65, 285);
            this.txtVermAltEndereco.Multiline = true;
            this.txtVermAltEndereco.Name = "txtVermAltEndereco";
            this.txtVermAltEndereco.Size = new System.Drawing.Size(283, 22);
            this.txtVermAltEndereco.TabIndex = 12;
            this.txtVermAltEndereco.Visible = false;
            // 
            // frmManutencaoEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpIncluirEmpresa;
        private System.Windows.Forms.TabPage tbpAlterarEmpresa;
        private System.Windows.Forms.Button btnAlterarCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterarOK;
        private System.Windows.Forms.TextBox txtAlteraEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.TextBox txtVermIncNome;
        private System.Windows.Forms.TextBox txtVermIncTelefone;
        private System.Windows.Forms.TextBox txtVermIncEndereco;
        private System.Windows.Forms.TextBox txtVermAltNome;
        private System.Windows.Forms.TextBox txtVermAltTelefone;
        private System.Windows.Forms.TextBox txtVermAltEndereco;
        private System.Windows.Forms.Label lblVermErro;
        private System.Windows.Forms.Label lblVermErroTelefone;
        private System.Windows.Forms.Label lblVermEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.MaskedTextBox mskAlteraTelefone;
    }
}