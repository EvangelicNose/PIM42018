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
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.ckbIncluirAtiva = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpIncluirEmpresa = new System.Windows.Forms.TabPage();
            this.tbpAlterarEmpresa = new System.Windows.Forms.TabPage();
            this.dtgAlterarResultado = new System.Windows.Forms.DataGridView();
            this.ckbAlterarAtiva = new System.Windows.Forms.CheckBox();
            this.btnPesquisarEmpresa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPesquisarEmpresa = new System.Windows.Forms.TextBox();
            this.txtAlteraNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAlterarCancelar = new System.Windows.Forms.Button();
            this.txtAlterarTelefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAlterarOK = new System.Windows.Forms.Button();
            this.txtAlteraEndereco = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tbpIncluirEmpresa.SuspendLayout();
            this.tbpAlterarEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlterarResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(142, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(44, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.txtNome.TabIndex = 0;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(102, 113);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(102, 146);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(212, 20);
            this.txtEndereco.TabIndex = 3;
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
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tbpIncluirEmpresa);
            this.tabControl1.Controls.Add(this.tbpAlterarEmpresa);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 326);
            this.tabControl1.TabIndex = 12;
            // 
            // tbpIncluirEmpresa
            // 
            this.tbpIncluirEmpresa.Controls.Add(this.ckbIncluirAtiva);
            this.tbpIncluirEmpresa.Controls.Add(this.btnCancelar);
            this.tbpIncluirEmpresa.Controls.Add(this.label1);
            this.tbpIncluirEmpresa.Controls.Add(this.txtNome);
            this.tbpIncluirEmpresa.Controls.Add(this.btnOK);
            this.tbpIncluirEmpresa.Controls.Add(this.label3);
            this.tbpIncluirEmpresa.Controls.Add(this.txtEndereco);
            this.tbpIncluirEmpresa.Controls.Add(this.txtTelefone);
            this.tbpIncluirEmpresa.Controls.Add(this.label2);
            this.tbpIncluirEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpIncluirEmpresa.Name = "tbpIncluirEmpresa";
            this.tbpIncluirEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIncluirEmpresa.Size = new System.Drawing.Size(354, 297);
            this.tbpIncluirEmpresa.TabIndex = 0;
            this.tbpIncluirEmpresa.Text = "Incluir Empresa";
            this.tbpIncluirEmpresa.UseVisualStyleBackColor = true;
            this.tbpIncluirEmpresa.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tbpAlterarEmpresa
            // 
            this.tbpAlterarEmpresa.Controls.Add(this.dtgAlterarResultado);
            this.tbpAlterarEmpresa.Controls.Add(this.ckbAlterarAtiva);
            this.tbpAlterarEmpresa.Controls.Add(this.btnPesquisarEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.label7);
            this.tbpAlterarEmpresa.Controls.Add(this.txtPesquisarEmpresa);
            this.tbpAlterarEmpresa.Controls.Add(this.txtAlteraNome);
            this.tbpAlterarEmpresa.Controls.Add(this.label6);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlterarCancelar);
            this.tbpAlterarEmpresa.Controls.Add(this.txtAlterarTelefone);
            this.tbpAlterarEmpresa.Controls.Add(this.label4);
            this.tbpAlterarEmpresa.Controls.Add(this.label5);
            this.tbpAlterarEmpresa.Controls.Add(this.btnAlterarOK);
            this.tbpAlterarEmpresa.Controls.Add(this.txtAlteraEndereco);
            this.tbpAlterarEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tbpAlterarEmpresa.Name = "tbpAlterarEmpresa";
            this.tbpAlterarEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlterarEmpresa.Size = new System.Drawing.Size(354, 297);
            this.tbpAlterarEmpresa.TabIndex = 1;
            this.tbpAlterarEmpresa.Text = "Alterar Empresa";
            this.tbpAlterarEmpresa.UseVisualStyleBackColor = true;
            // 
            // dtgAlterarResultado
            // 
            this.dtgAlterarResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlterarResultado.Location = new System.Drawing.Point(9, 38);
            this.dtgAlterarResultado.Name = "dtgAlterarResultado";
            this.dtgAlterarResultado.Size = new System.Drawing.Size(339, 129);
            this.dtgAlterarResultado.TabIndex = 14;
            // 
            // ckbAlterarAtiva
            // 
            this.ckbAlterarAtiva.AutoSize = true;
            this.ckbAlterarAtiva.Checked = true;
            this.ckbAlterarAtiva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAlterarAtiva.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbAlterarAtiva.Location = new System.Drawing.Point(273, 207);
            this.ckbAlterarAtiva.Name = "ckbAlterarAtiva";
            this.ckbAlterarAtiva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckbAlterarAtiva.Size = new System.Drawing.Size(68, 17);
            this.ckbAlterarAtiva.TabIndex = 13;
            this.ckbAlterarAtiva.Text = "    : Ativa";
            this.ckbAlterarAtiva.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(282, 10);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(66, 23);
            this.btnPesquisarEmpresa.TabIndex = 10;
            this.btnPesquisarEmpresa.Text = "Pesquisar";
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = true;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pesquisar Empresa: ";
            // 
            // txtPesquisarEmpresa
            // 
            this.txtPesquisarEmpresa.Location = new System.Drawing.Point(108, 12);
            this.txtPesquisarEmpresa.Name = "txtPesquisarEmpresa";
            this.txtPesquisarEmpresa.Size = new System.Drawing.Size(168, 20);
            this.txtPesquisarEmpresa.TabIndex = 9;
            // 
            // txtAlteraNome
            // 
            this.txtAlteraNome.Location = new System.Drawing.Point(64, 173);
            this.txtAlteraNome.Name = "txtAlteraNome";
            this.txtAlteraNome.Size = new System.Drawing.Size(284, 20);
            this.txtAlteraNome.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Endereço: ";
            // 
            // btnAlterarCancelar
            // 
            this.btnAlterarCancelar.Location = new System.Drawing.Point(273, 268);
            this.btnAlterarCancelar.Name = "btnAlterarCancelar";
            this.btnAlterarCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarCancelar.TabIndex = 5;
            this.btnAlterarCancelar.Text = "Cancelar";
            this.btnAlterarCancelar.UseVisualStyleBackColor = true;
            // 
            // txtAlterarTelefone
            // 
            this.txtAlterarTelefone.Location = new System.Drawing.Point(64, 205);
            this.txtAlterarTelefone.Name = "txtAlterarTelefone";
            this.txtAlterarTelefone.Size = new System.Drawing.Size(129, 20);
            this.txtAlterarTelefone.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone: ";
            // 
            // btnAlterarOK
            // 
            this.btnAlterarOK.Location = new System.Drawing.Point(6, 268);
            this.btnAlterarOK.Name = "btnAlterarOK";
            this.btnAlterarOK.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarOK.TabIndex = 4;
            this.btnAlterarOK.Text = "OK";
            this.btnAlterarOK.UseVisualStyleBackColor = true;
            // 
            // txtAlteraEndereco
            // 
            this.txtAlteraEndereco.Location = new System.Drawing.Point(64, 238);
            this.txtAlteraEndereco.Name = "txtAlteraEndereco";
            this.txtAlteraEndereco.Size = new System.Drawing.Size(284, 20);
            this.txtAlteraEndereco.TabIndex = 3;
            // 
            // frmManutencaoEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlterarResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpIncluirEmpresa;
        private System.Windows.Forms.TabPage tbpAlterarEmpresa;
        private System.Windows.Forms.Button btnAlterarCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAlterarOK;
        private System.Windows.Forms.TextBox txtAlteraEndereco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlterarTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlteraNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPesquisarEmpresa;
        private System.Windows.Forms.TextBox txtPesquisarEmpresa;
        private System.Windows.Forms.CheckBox ckbIncluirAtiva;
        private System.Windows.Forms.CheckBox ckbAlterarAtiva;
        private System.Windows.Forms.DataGridView dtgAlterarResultado;
    }
}