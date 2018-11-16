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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cbbMotivo = new System.Windows.Forms.ComboBox();
            this.btnAnexo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABERTURA DE CHAMADOS";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(34, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuário:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(42, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(29, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Empresa:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(38, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Motivo:";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(22, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descrição:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblData
            // 
            this.lblData.Location = new System.Drawing.Point(496, 22);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(55, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(496, 35);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(55, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(80, 192);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(373, 154);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // cbbMotivo
            // 
            this.cbbMotivo.FormattingEnabled = true;
            this.cbbMotivo.Location = new System.Drawing.Point(80, 165);
            this.cbbMotivo.Name = "cbbMotivo";
            this.cbbMotivo.Size = new System.Drawing.Size(372, 21);
            this.cbbMotivo.TabIndex = 1;
            this.cbbMotivo.SelectedIndexChanged += new System.EventHandler(this.cbbMotivo_SelectedIndexChanged);
            // 
            // btnAnexo
            // 
            this.btnAnexo.Image = global::helpdesk2018.Properties.Resources.Anexo;
            this.btnAnexo.Location = new System.Drawing.Point(458, 265);
            this.btnAnexo.Name = "btnAnexo";
            this.btnAnexo.Size = new System.Drawing.Size(93, 81);
            this.btnAnexo.TabIndex = 5;
            this.btnAnexo.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(458, 165);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(93, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(458, 194);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(80, 80);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(52, 17);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "label2";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(80, 109);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(52, 17);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "label2";
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpresa.Location = new System.Drawing.Point(80, 138);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(52, 17);
            this.lbEmpresa.TabIndex = 15;
            this.lbEmpresa.Text = "label2";
            // 
            // frmAberturaChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 363);
            this.Controls.Add(this.lbEmpresa);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnAnexo);
            this.Controls.Add(this.cbbMotivo);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cbbMotivo;
        private System.Windows.Forms.Button btnAnexo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmpresa;
    }
}