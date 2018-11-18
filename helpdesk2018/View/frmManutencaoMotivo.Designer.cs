namespace helpdesk2018.View
{
    partial class frmManutencaoMotivo
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
            this.tbpManutencaoMotivo = new System.Windows.Forms.TabControl();
            this.tbpIncluir = new System.Windows.Forms.TabPage();
            this.btnAMaior = new System.Windows.Forms.Button();
            this.btnAMenor = new System.Windows.Forms.Button();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtIncluirMotivo = new System.Windows.Forms.TextBox();
            this.tbpAlterarMotivo = new System.Windows.Forms.TabPage();
            this.btnAlterarAMaior = new System.Windows.Forms.Button();
            this.btnAlterarAMenor = new System.Windows.Forms.Button();
            this.dtgAlteraResultado = new System.Windows.Forms.DataGridView();
            this.idmotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtPesquisaMotivo = new System.Windows.Forms.TextBox();
            this.lblAlteraPesquisarMotivo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ckbAlteraAtivo = new System.Windows.Forms.CheckBox();
            this.btnAlterarSair = new System.Windows.Forms.Button();
            this.lblAlteraMotivo = new System.Windows.Forms.Label();
            this.btnAlteraMotivo = new System.Windows.Forms.Button();
            this.txtAlteraMotivo = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbpManutencaoMotivo.SuspendLayout();
            this.tbpIncluir.SuspendLayout();
            this.tbpAlterarMotivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tbpManutencaoMotivo
            // 
            this.tbpManutencaoMotivo.Controls.Add(this.tbpIncluir);
            this.tbpManutencaoMotivo.Controls.Add(this.tbpAlterarMotivo);
            this.tbpManutencaoMotivo.Location = new System.Drawing.Point(0, 0);
            this.tbpManutencaoMotivo.Name = "tbpManutencaoMotivo";
            this.tbpManutencaoMotivo.SelectedIndex = 0;
            this.tbpManutencaoMotivo.Size = new System.Drawing.Size(395, 386);
            this.tbpManutencaoMotivo.TabIndex = 0;
            this.tbpManutencaoMotivo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbpManutencaoMotivo_MouseClick);
            // 
            // tbpIncluir
            // 
            this.tbpIncluir.Controls.Add(this.btnAMaior);
            this.tbpIncluir.Controls.Add(this.btnAMenor);
            this.tbpIncluir.Controls.Add(this.ckbAtivo);
            this.tbpIncluir.Controls.Add(this.btnSair);
            this.tbpIncluir.Controls.Add(this.lblMotivo);
            this.tbpIncluir.Controls.Add(this.btnCadastrar);
            this.tbpIncluir.Controls.Add(this.txtIncluirMotivo);
            this.tbpIncluir.Location = new System.Drawing.Point(4, 22);
            this.tbpIncluir.Name = "tbpIncluir";
            this.tbpIncluir.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncluir.Size = new System.Drawing.Size(387, 360);
            this.tbpIncluir.TabIndex = 0;
            this.tbpIncluir.Text = "Incluir Motivo";
            this.tbpIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAMaior
            // 
            this.btnAMaior.Location = new System.Drawing.Point(356, 6);
            this.btnAMaior.Name = "btnAMaior";
            this.btnAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAMaior.TabIndex = 11;
            this.btnAMaior.Text = "A+";
            this.toolTip1.SetToolTip(this.btnAMaior, "Aumentar Fonte");
            this.btnAMaior.UseVisualStyleBackColor = true;
            this.btnAMaior.Click += new System.EventHandler(this.btnAMaior_Click);
            // 
            // btnAMenor
            // 
            this.btnAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMenor.Location = new System.Drawing.Point(333, 6);
            this.btnAMenor.Name = "btnAMenor";
            this.btnAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAMenor.TabIndex = 10;
            this.btnAMenor.Text = "A-";
            this.toolTip1.SetToolTip(this.btnAMenor, "Diminuir Fonte");
            this.btnAMenor.UseVisualStyleBackColor = true;
            this.btnAMenor.Click += new System.EventHandler(this.btnAMenor_Click);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Checked = true;
            this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivo.Location = new System.Drawing.Point(227, 144);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 9;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            this.ckbAtivo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(218, 167);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btnSair, "Saor da tela de Mantenção Motivo");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.Location = new System.Drawing.Point(23, 86);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 2;
            this.lblMotivo.Text = "Motivo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(82, 167);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 28);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.toolTip1.SetToolTip(this.btnCadastrar, "Cadastrar Motivo");
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtIncluirMotivo
            // 
            this.txtIncluirMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncluirMotivo.Location = new System.Drawing.Point(82, 83);
            this.txtIncluirMotivo.Name = "txtIncluirMotivo";
            this.txtIncluirMotivo.Size = new System.Drawing.Size(211, 20);
            this.txtIncluirMotivo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtIncluirMotivo, "Digitar o nome do motivo");
            this.txtIncluirMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncluirMotivo_KeyPress);
            // 
            // tbpAlterarMotivo
            // 
            this.tbpAlterarMotivo.Controls.Add(this.btnAlterarAMaior);
            this.tbpAlterarMotivo.Controls.Add(this.btnAlterarAMenor);
            this.tbpAlterarMotivo.Controls.Add(this.dtgAlteraResultado);
            this.tbpAlterarMotivo.Controls.Add(this.txtPesquisaMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.lblAlteraPesquisarMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.btnPesquisar);
            this.tbpAlterarMotivo.Controls.Add(this.ckbAlteraAtivo);
            this.tbpAlterarMotivo.Controls.Add(this.btnAlterarSair);
            this.tbpAlterarMotivo.Controls.Add(this.lblAlteraMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.btnAlteraMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.txtAlteraMotivo);
            this.tbpAlterarMotivo.Location = new System.Drawing.Point(4, 22);
            this.tbpAlterarMotivo.Name = "tbpAlterarMotivo";
            this.tbpAlterarMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterarMotivo.Size = new System.Drawing.Size(387, 360);
            this.tbpAlterarMotivo.TabIndex = 1;
            this.tbpAlterarMotivo.Text = "Alterar Motivo";
            this.tbpAlterarMotivo.UseVisualStyleBackColor = true;
            this.tbpAlterarMotivo.Click += new System.EventHandler(this.tbpAlterarMotivo_Click);
            // 
            // btnAlterarAMaior
            // 
            this.btnAlterarAMaior.AccessibleDescription = "";
            this.btnAlterarAMaior.AccessibleName = "Aumentar a Fonte";
            this.btnAlterarAMaior.Location = new System.Drawing.Point(356, 6);
            this.btnAlterarAMaior.Name = "btnAlterarAMaior";
            this.btnAlterarAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAlterarAMaior.TabIndex = 13;
            this.btnAlterarAMaior.Text = "A+";
            this.toolTip1.SetToolTip(this.btnAlterarAMaior, "Aumentar Fonte");
            this.btnAlterarAMaior.UseVisualStyleBackColor = true;
            this.btnAlterarAMaior.Click += new System.EventHandler(this.btnAlterarAMaior_Click);
            // 
            // btnAlterarAMenor
            // 
            this.btnAlterarAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarAMenor.Location = new System.Drawing.Point(333, 6);
            this.btnAlterarAMenor.Name = "btnAlterarAMenor";
            this.btnAlterarAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAlterarAMenor.TabIndex = 12;
            this.btnAlterarAMenor.Text = "A-";
            this.toolTip1.SetToolTip(this.btnAlterarAMenor, "Diminuir Fonte");
            this.btnAlterarAMenor.UseVisualStyleBackColor = true;
            this.btnAlterarAMenor.Click += new System.EventHandler(this.btnAlterarAMenor_Click);
            // 
            // dtgAlteraResultado
            // 
            this.dtgAlteraResultado.AllowUserToAddRows = false;
            this.dtgAlteraResultado.AllowUserToResizeRows = false;
            this.dtgAlteraResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmotivo,
            this.descricao,
            this.ativo});
            this.dtgAlteraResultado.Location = new System.Drawing.Point(6, 76);
            this.dtgAlteraResultado.MultiSelect = false;
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.RowHeadersVisible = false;
            this.dtgAlteraResultado.Size = new System.Drawing.Size(373, 177);
            this.dtgAlteraResultado.TabIndex = 3;
            this.dtgAlteraResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlteraResultado_CellClick);
            // 
            // idmotivo
            // 
            this.idmotivo.DataPropertyName = "idmotivo";
            this.idmotivo.HeaderText = "idmotivo";
            this.idmotivo.Name = "idmotivo";
            this.idmotivo.Visible = false;
            // 
            // descricao
            // 
            this.descricao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // ativo
            // 
            this.ativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "Ativo ?";
            this.ativo.Name = "ativo";
            this.ativo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ativo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ativo.Width = 65;
            // 
            // txtPesquisaMotivo
            // 
            this.txtPesquisaMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaMotivo.Location = new System.Drawing.Point(138, 46);
            this.txtPesquisaMotivo.Name = "txtPesquisaMotivo";
            this.txtPesquisaMotivo.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisaMotivo.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtPesquisaMotivo, "Digitar o nome do morivo para pesquisar");
            // 
            // lblAlteraPesquisarMotivo
            // 
            this.lblAlteraPesquisarMotivo.AutoSize = true;
            this.lblAlteraPesquisarMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraPesquisarMotivo.Location = new System.Drawing.Point(8, 49);
            this.lblAlteraPesquisarMotivo.Name = "lblAlteraPesquisarMotivo";
            this.lblAlteraPesquisarMotivo.Size = new System.Drawing.Size(88, 13);
            this.lblAlteraPesquisarMotivo.TabIndex = 10;
            this.lblAlteraPesquisarMotivo.Text = "Pesquisar Motivo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(288, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(91, 28);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.toolTip1.SetToolTip(this.btnPesquisar, "Pesquisar motivo");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ckbAlteraAtivo
            // 
            this.ckbAlteraAtivo.AutoSize = true;
            this.ckbAlteraAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbAlteraAtivo.Location = new System.Drawing.Point(162, 294);
            this.ckbAlteraAtivo.Name = "ckbAlteraAtivo";
            this.ckbAlteraAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAlteraAtivo.TabIndex = 5;
            this.ckbAlteraAtivo.Text = "Ativo";
            this.toolTip1.SetToolTip(this.ckbAlteraAtivo, "Selecionar se est[a ativo o motivo");
            this.ckbAlteraAtivo.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSair
            // 
            this.btnAlterarSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarSair.Location = new System.Drawing.Point(304, 291);
            this.btnAlterarSair.Name = "btnAlterarSair";
            this.btnAlterarSair.Size = new System.Drawing.Size(75, 28);
            this.btnAlterarSair.TabIndex = 7;
            this.btnAlterarSair.Text = "Sair";
            this.toolTip1.SetToolTip(this.btnAlterarSair, "Sair da tela de Manutenção Motivo");
            this.btnAlterarSair.UseVisualStyleBackColor = true;
            this.btnAlterarSair.Click += new System.EventHandler(this.btnAlterarSair_Click);
            // 
            // lblAlteraMotivo
            // 
            this.lblAlteraMotivo.AutoSize = true;
            this.lblAlteraMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraMotivo.Location = new System.Drawing.Point(3, 259);
            this.lblAlteraMotivo.Name = "lblAlteraMotivo";
            this.lblAlteraMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblAlteraMotivo.TabIndex = 6;
            this.lblAlteraMotivo.Text = "Motivo:";
            // 
            // btnAlteraMotivo
            // 
            this.btnAlteraMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlteraMotivo.Location = new System.Drawing.Point(7, 292);
            this.btnAlteraMotivo.Name = "btnAlteraMotivo";
            this.btnAlteraMotivo.Size = new System.Drawing.Size(75, 27);
            this.btnAlteraMotivo.TabIndex = 6;
            this.btnAlteraMotivo.Text = "Alterar";
            this.toolTip1.SetToolTip(this.btnAlteraMotivo, "Confirmar alteração");
            this.btnAlteraMotivo.UseVisualStyleBackColor = true;
            this.btnAlteraMotivo.Click += new System.EventHandler(this.btnAlteraMotivo_Click);
            // 
            // txtAlteraMotivo
            // 
            this.txtAlteraMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlteraMotivo.Location = new System.Drawing.Point(62, 256);
            this.txtAlteraMotivo.Name = "txtAlteraMotivo";
            this.txtAlteraMotivo.Size = new System.Drawing.Size(317, 20);
            this.txtAlteraMotivo.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtAlteraMotivo, "Digitar a alterção do motivo");
            // 
            // frmManutencaoMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 382);
            this.Controls.Add(this.tbpManutencaoMotivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmManutencaoMotivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção Motivo";
            this.Load += new System.EventHandler(this.frmManutencaoMotivo_Load_1);
            this.tbpManutencaoMotivo.ResumeLayout(false);
            this.tbpIncluir.ResumeLayout(false);
            this.tbpIncluir.PerformLayout();
            this.tbpAlterarMotivo.ResumeLayout(false);
            this.tbpAlterarMotivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlteraResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbpManutencaoMotivo;
        private System.Windows.Forms.TabPage tbpIncluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtIncluirMotivo;
        private System.Windows.Forms.TabPage tbpAlterarMotivo;
        private System.Windows.Forms.Button btnAlterarSair;
        private System.Windows.Forms.Label lblAlteraMotivo;
        private System.Windows.Forms.Button btnAlteraMotivo;
        private System.Windows.Forms.TextBox txtAlteraMotivo;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbAlteraAtivo;
        private System.Windows.Forms.TextBox txtPesquisaMotivo;
        private System.Windows.Forms.Label lblAlteraPesquisarMotivo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgAlteraResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativo;
        private System.Windows.Forms.Button btnAMaior;
        private System.Windows.Forms.Button btnAMenor;
        private System.Windows.Forms.Button btnAlterarAMaior;
        private System.Windows.Forms.Button btnAlterarAMenor;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}