namespace helpdesk2018.View
{
    partial class frmAberturaChamados
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
            this.lblAberturaChamados = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbbMotivo = new System.Windows.Forms.ComboBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.btnAMaior = new System.Windows.Forms.Button();
            this.btnAMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAberturaChamados
            // 
            this.lblAberturaChamados.AutoSize = true;
            this.lblAberturaChamados.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAberturaChamados.Location = new System.Drawing.Point(20, 13);
            this.lblAberturaChamados.Name = "lblAberturaChamados";
            this.lblAberturaChamados.Size = new System.Drawing.Size(303, 26);
            this.lblAberturaChamados.TabIndex = 0;
            this.lblAberturaChamados.Text = "ABERTURA DE CHAMADOS";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(27, 78);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 19);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNome.Location = new System.Drawing.Point(41, 106);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(59, 18);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmpresa.Location = new System.Drawing.Point(19, 135);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(81, 21);
            this.lblEmpresa.TabIndex = 4;
            this.lblEmpresa.Text = "Empresa:";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMotivo
            // 
            this.lblMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMotivo.Location = new System.Drawing.Point(37, 163);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(63, 18);
            this.lblMotivo.TabIndex = 5;
            this.lblMotivo.Text = "Motivo:";
            this.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDescricao.Location = new System.Drawing.Point(12, 192);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(88, 21);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(471, 35);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(93, 21);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(483, 56);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 21);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(106, 195);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(347, 151);
            this.txtDescricao.TabIndex = 2;
            // 
            // cbbMotivo
            // 
            this.cbbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMotivo.FormattingEnabled = true;
            this.cbbMotivo.Location = new System.Drawing.Point(106, 163);
            this.cbbMotivo.Name = "cbbMotivo";
            this.cbbMotivo.Size = new System.Drawing.Size(346, 21);
            this.cbbMotivo.TabIndex = 1;
            // 
            // btnAnexo
            // 
            this.btnAnexo.Image = global::helpdesk2018.Properties.Resources.Anexo;
            this.btnAnexo.Location = new System.Drawing.Point(458, 265);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(93, 81);
            this.btnAnexo.TabIndex = 5;
            this.btnAnexo.UseVisualStyleBackColor = true;
            this.btnAnexo.Click += new System.EventHandler(this.btnAnexo_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(458, 160);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(94, 27);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(458, 195);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 27);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(103, 78);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(52, 17);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "label2";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(103, 107);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 17);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "label2";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpresa.Location = new System.Drawing.Point(103, 136);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(52, 17);
            this.lbEmpresa.TabIndex = 15;
            this.lbEmpresa.Text = "label2";
            // 
            // btnAMaior
            // 
            this.btnAMaior.Location = new System.Drawing.Point(546, 5);
            this.btnAMaior.Name = "btnAMaior";
            this.btnAMaior.Size = new System.Drawing.Size(28, 23);
            this.btnAMaior.TabIndex = 22;
            this.btnAMaior.Text = "A+";
            this.btnAMaior.UseVisualStyleBackColor = true;
            this.btnAMaior.Click += new System.EventHandler(this.btnIncluiAMaior_Click);
            // 
            // btnAMenor
            // 
            this.btnAMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAMenor.Location = new System.Drawing.Point(523, 5);
            this.btnAMenor.Name = "btnAMenor";
            this.btnAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAMenor.TabIndex = 21;
            this.btnAMenor.Text = "A-";
            this.btnAMenor.UseVisualStyleBackColor = true;
            this.btnAMenor.Click += new System.EventHandler(this.btnAMenor_Click);
            // 
            // frmAberturaChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 363);
            this.Controls.Add(this.btnAMaior);
            this.Controls.Add(this.btnAMenor);
            this.Controls.Add(this.lbEmpresa);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.cbbMotivo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAberturaChamados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAberturaChamados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura de Chamados";
            this.Load += new System.EventHandler(this.AberturaChamados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAberturaChamados;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbbMotivo;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Button btnAMaior;
        private System.Windows.Forms.Button btnAMenor;
    }
}