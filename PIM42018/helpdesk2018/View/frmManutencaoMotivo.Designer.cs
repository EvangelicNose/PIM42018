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
            this.tbpManutencaoMotivo = new System.Windows.Forms.TabControl();
            this.tbpIncluir = new System.Windows.Forms.TabPage();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtIncluirMotivo = new System.Windows.Forms.TextBox();
            this.tbpAlterarMotivo = new System.Windows.Forms.TabPage();
            this.dtgAlteraResultado = new System.Windows.Forms.DataGridView();
            this.txtPesquisaMotivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ckbAlteraAtivo = new System.Windows.Forms.CheckBox();
            this.btnAlterarSair = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAlteraMotivo = new System.Windows.Forms.Button();
            this.txtAlteraMotivo = new System.Windows.Forms.TextBox();
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
            this.tbpManutencaoMotivo.Size = new System.Drawing.Size(345, 337);
            this.tbpManutencaoMotivo.TabIndex = 0;
            // 
            // tbpIncluir
            // 
            this.tbpIncluir.Controls.Add(this.ckbAtivo);
            this.tbpIncluir.Controls.Add(this.btnSair);
            this.tbpIncluir.Controls.Add(this.label1);
            this.tbpIncluir.Controls.Add(this.btnCadastrar);
            this.tbpIncluir.Controls.Add(this.txtIncluirMotivo);
            this.tbpIncluir.Location = new System.Drawing.Point(4, 22);
            this.tbpIncluir.Name = "tbpIncluir";
            this.tbpIncluir.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncluir.Size = new System.Drawing.Size(337, 311);
            this.tbpIncluir.TabIndex = 0;
            this.tbpIncluir.Text = "Incluir Motivo";
            this.tbpIncluir.UseVisualStyleBackColor = true;
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Checked = true;
            this.ckbAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAtivo.Location = new System.Drawing.Point(202, 107);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 9;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            this.ckbAtivo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(177, 139);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 28);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(82, 139);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 28);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtIncluirMotivo
            // 
            this.txtIncluirMotivo.Location = new System.Drawing.Point(82, 55);
            this.txtIncluirMotivo.Name = "txtIncluirMotivo";
            this.txtIncluirMotivo.Size = new System.Drawing.Size(170, 20);
            this.txtIncluirMotivo.TabIndex = 0;
            this.txtIncluirMotivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIncluirMotivo_KeyPress);
            // 
            // tbpAlterarMotivo
            // 
            this.tbpAlterarMotivo.Controls.Add(this.dtgAlteraResultado);
            this.tbpAlterarMotivo.Controls.Add(this.txtPesquisaMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.label3);
            this.tbpAlterarMotivo.Controls.Add(this.btnPesquisar);
            this.tbpAlterarMotivo.Controls.Add(this.ckbAlteraAtivo);
            this.tbpAlterarMotivo.Controls.Add(this.btnAlterarSair);
            this.tbpAlterarMotivo.Controls.Add(this.label2);
            this.tbpAlterarMotivo.Controls.Add(this.btnAlteraMotivo);
            this.tbpAlterarMotivo.Controls.Add(this.txtAlteraMotivo);
            this.tbpAlterarMotivo.Location = new System.Drawing.Point(4, 22);
            this.tbpAlterarMotivo.Name = "tbpAlterarMotivo";
            this.tbpAlterarMotivo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterarMotivo.Size = new System.Drawing.Size(337, 311);
            this.tbpAlterarMotivo.TabIndex = 1;
            this.tbpAlterarMotivo.Text = "Alterar Motivo";
            this.tbpAlterarMotivo.UseVisualStyleBackColor = true;
            this.tbpAlterarMotivo.Click += new System.EventHandler(this.tbpAlterarMotivo_Click);
            // 
            // dtgAlteraResultado
            // 
            this.dtgAlteraResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlteraResultado.Location = new System.Drawing.Point(6, 35);
            this.dtgAlteraResultado.Name = "dtgAlteraResultado";
            this.dtgAlteraResultado.Size = new System.Drawing.Size(321, 177);
            this.dtgAlteraResultado.TabIndex = 12;
            this.dtgAlteraResultado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAlteraResultado_CellClick);
            // 
            // txtPesquisaMotivo
            // 
            this.txtPesquisaMotivo.Location = new System.Drawing.Point(102, 8);
            this.txtPesquisaMotivo.Name = "txtPesquisaMotivo";
            this.txtPesquisaMotivo.Size = new System.Drawing.Size(144, 20);
            this.txtPesquisaMotivo.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pesquisar Motivo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(252, 6);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ckbAlteraAtivo
            // 
            this.ckbAlteraAtivo.AutoSize = true;
            this.ckbAlteraAtivo.Location = new System.Drawing.Point(130, 256);
            this.ckbAlteraAtivo.Name = "ckbAlteraAtivo";
            this.ckbAlteraAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAlteraAtivo.TabIndex = 8;
            this.ckbAlteraAtivo.Text = "Ativo";
            this.ckbAlteraAtivo.UseVisualStyleBackColor = true;
            // 
            // btnAlterarSair
            // 
            this.btnAlterarSair.Location = new System.Drawing.Point(250, 256);
            this.btnAlterarSair.Name = "btnAlterarSair";
            this.btnAlterarSair.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarSair.TabIndex = 7;
            this.btnAlterarSair.Text = "Sair";
            this.btnAlterarSair.UseVisualStyleBackColor = true;
            this.btnAlterarSair.Click += new System.EventHandler(this.btnAlterarSair_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Motivo:";
            // 
            // btnAlteraMotivo
            // 
            this.btnAlteraMotivo.Location = new System.Drawing.Point(6, 256);
            this.btnAlteraMotivo.Name = "btnAlteraMotivo";
            this.btnAlteraMotivo.Size = new System.Drawing.Size(75, 23);
            this.btnAlteraMotivo.TabIndex = 5;
            this.btnAlteraMotivo.Text = "Alterar";
            this.btnAlteraMotivo.UseVisualStyleBackColor = true;
            this.btnAlteraMotivo.Click += new System.EventHandler(this.btnAlteraMotivo_Click);
            // 
            // txtAlteraMotivo
            // 
            this.txtAlteraMotivo.Location = new System.Drawing.Point(85, 218);
            this.txtAlteraMotivo.Name = "txtAlteraMotivo";
            this.txtAlteraMotivo.Size = new System.Drawing.Size(170, 20);
            this.txtAlteraMotivo.TabIndex = 4;
            // 
            // frmManutencaoMotivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 337);
            this.ControlBox = false;
            this.Controls.Add(this.tbpManutencaoMotivo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtIncluirMotivo;
        private System.Windows.Forms.TabPage tbpAlterarMotivo;
        private System.Windows.Forms.Button btnAlterarSair;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAlteraMotivo;
        private System.Windows.Forms.TextBox txtAlteraMotivo;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.CheckBox ckbAlteraAtivo;
        private System.Windows.Forms.TextBox txtPesquisaMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dtgAlteraResultado;
    }
}