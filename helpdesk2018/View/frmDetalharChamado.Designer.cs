namespace helpdesk2018.View
{
    partial class frmDetalharChamado
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnFecharChamado = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblOS = new System.Windows.Forms.Label();
            this.txtOS = new System.Windows.Forms.TextBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAMaior = new System.Windows.Forms.Button();
            this.btnAMenor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAberto = new System.Windows.Forms.TextBox();
            this.lblFechado = new System.Windows.Forms.Label();
            this.txtFechado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(98, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(165, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.TabStop = false;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Enabled = false;
            this.txtEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(98, 59);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(165, 20);
            this.txtEmpresa.TabIndex = 1;
            this.txtEmpresa.TabStop = false;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Enabled = false;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(98, 85);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(262, 20);
            this.txtMotivo.TabIndex = 2;
            this.txtMotivo.TabStop = false;
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(98, 233);
            this.txtResposta.Multiline = true;
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(374, 104);
            this.txtResposta.TabIndex = 0;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(98, 118);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(262, 104);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblNome.Location = new System.Drawing.Point(7, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmpresa.Location = new System.Drawing.Point(7, 62);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(51, 13);
            this.lblEmpresa.TabIndex = 6;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMotivo.Location = new System.Drawing.Point(7, 88);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(42, 13);
            this.lblMotivo.TabIndex = 7;
            this.lblMotivo.Text = "Motivo:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDescricao.Location = new System.Drawing.Point(7, 121);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 8;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblResposta.Location = new System.Drawing.Point(7, 236);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(55, 13);
            this.lblResposta.TabIndex = 9;
            this.lblResposta.Text = "Resposta:";
            // 
            // btnFecharChamado
            // 
            this.btnFecharChamado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFecharChamado.Location = new System.Drawing.Point(98, 346);
            this.btnFecharChamado.Name = "btnFecharChamado";
            this.btnFecharChamado.Size = new System.Drawing.Size(107, 28);
            this.btnFecharChamado.TabIndex = 1;
            this.btnFecharChamado.Text = "Fechar chamado";
            this.btnFecharChamado.UseVisualStyleBackColor = true;
            this.btnFecharChamado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(395, 346);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(77, 28);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblOS
            // 
            this.lblOS.AutoSize = true;
            this.lblOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOS.Location = new System.Drawing.Point(363, 87);
            this.lblOS.Name = "lblOS";
            this.lblOS.Size = new System.Drawing.Size(31, 13);
            this.lblOS.TabIndex = 12;
            this.lblOS.Text = "O.S.:";
            // 
            // txtOS
            // 
            this.txtOS.Enabled = false;
            this.txtOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOS.Location = new System.Drawing.Point(408, 85);
            this.txtOS.Name = "txtOS";
            this.txtOS.Size = new System.Drawing.Size(64, 20);
            this.txtOS.TabIndex = 13;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Enabled = false;
            this.btnAnexo.Image = global::helpdesk2018.Properties.Resources.Anexo;
            this.btnAnexo.Location = new System.Drawing.Point(379, 141);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(93, 81);
            this.btnAnexo.TabIndex = 4;
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click_1);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(209, 346);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(107, 28);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "Imprimir chamado";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnAMaior
            // 
            this.btnAMaior.Location = new System.Drawing.Point(444, 2);
            this.btnAMaior.Name = "btnAMaior";
            this.btnAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAMaior.TabIndex = 24;
            this.btnAMaior.Text = "A+";
            this.btnAMaior.UseVisualStyleBackColor = true;
            this.btnAMaior.Click += new System.EventHandler(this.btnAMaior_Click);
            // 
            // btnAMenor
            // 
            this.btnAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMenor.Location = new System.Drawing.Point(421, 2);
            this.btnAMenor.Name = "btnAMenor";
            this.btnAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAMenor.TabIndex = 23;
            this.btnAMenor.Text = "A-";
            this.btnAMenor.UseVisualStyleBackColor = true;
            this.btnAMenor.Click += new System.EventHandler(this.btnAMenor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Aberto:";
            // 
            // txtAberto
            // 
            this.txtAberto.Enabled = false;
            this.txtAberto.Location = new System.Drawing.Point(359, 33);
            this.txtAberto.Name = "txtAberto";
            this.txtAberto.Size = new System.Drawing.Size(113, 20);
            this.txtAberto.TabIndex = 26;
            // 
            // lblFechado
            // 
            this.lblFechado.AutoSize = true;
            this.lblFechado.Location = new System.Drawing.Point(300, 62);
            this.lblFechado.Name = "lblFechado";
            this.lblFechado.Size = new System.Drawing.Size(52, 13);
            this.lblFechado.TabIndex = 27;
            this.lblFechado.Text = "Fechado:";
            this.lblFechado.Visible = false;
            // 
            // txtFechado
            // 
            this.txtFechado.Enabled = false;
            this.txtFechado.Location = new System.Drawing.Point(359, 59);
            this.txtFechado.Name = "txtFechado";
            this.txtFechado.Size = new System.Drawing.Size(113, 20);
            this.txtFechado.TabIndex = 28;
            this.txtFechado.Visible = false;
            // 
            // frmDetalharChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 402);
            this.Controls.Add(this.txtFechado);
            this.Controls.Add(this.lblFechado);
            this.Controls.Add(this.txtAberto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAMaior);
            this.Controls.Add(this.btnAMenor);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.txtOS);
            this.Controls.Add(this.lblOS);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnFecharChamado);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDetalharChamado";
            this.Text = "Detalhes do Chamado";
            this.Load += new System.EventHandler(this.frmDetalharChamado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnFecharChamado;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblOS;
        private System.Windows.Forms.TextBox txtOS;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAMaior;
        private System.Windows.Forms.Button btnAMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAberto;
        private System.Windows.Forms.Label lblFechado;
        private System.Windows.Forms.TextBox txtFechado;
    }
}