namespace helpdesk2018
{
    partial class frmListarChamado
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
            this.lblLista = new System.Windows.Forms.Label();
            this.dtgListaChamado = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAMaior = new System.Windows.Forms.Button();
            this.btnAMenor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaChamado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(12, 14);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(97, 13);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "Lista de Chamados";
            // 
            // dtgListaChamado
            // 
            this.dtgListaChamado.AllowDrop = true;
            this.dtgListaChamado.AllowUserToAddRows = false;
            this.dtgListaChamado.AllowUserToDeleteRows = false;
            this.dtgListaChamado.AllowUserToResizeRows = false;
            this.dtgListaChamado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaChamado.Location = new System.Drawing.Point(15, 40);
            this.dtgListaChamado.MultiSelect = false;
            this.dtgListaChamado.Name = "dtgListaChamado";
            this.dtgListaChamado.ReadOnly = true;
            this.dtgListaChamado.RowHeadersVisible = false;
            this.dtgListaChamado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListaChamado.Size = new System.Drawing.Size(577, 222);
            this.dtgListaChamado.TabIndex = 0;
            this.dtgListaChamado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListaChamado_CellClick);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(517, 271);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 27);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAMaior
            // 
            this.btnAMaior.Location = new System.Drawing.Point(574, 4);
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
            this.btnAMenor.Location = new System.Drawing.Point(551, 4);
            this.btnAMenor.Name = "btnAMenor";
            this.btnAMenor.Size = new System.Drawing.Size(24, 23);
            this.btnAMenor.TabIndex = 21;
            this.btnAMenor.Text = "A-";
            this.btnAMenor.UseVisualStyleBackColor = true;
            this.btnAMenor.Click += new System.EventHandler(this.btnAMenor_Click);
            // 
            // frmListarChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 305);
            this.Controls.Add(this.btnAMaior);
            this.Controls.Add(this.btnAMenor);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dtgListaChamado);
            this.Controls.Add(this.lblLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmListarChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Chamados";
            this.Load += new System.EventHandler(this.frmListarChamado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaChamado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.DataGridView dtgListaChamado;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAMaior;
        private System.Windows.Forms.Button btnAMenor;
    }
}