namespace helpdesk2018.View
{
    partial class frmAnexo
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
            this.ptbAnexo = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnexo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbAnexo
            // 
            this.ptbAnexo.Location = new System.Drawing.Point(12, 12);
            this.ptbAnexo.Name = "ptbAnexo";
            this.ptbAnexo.Size = new System.Drawing.Size(617, 303);
            this.ptbAnexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnexo.TabIndex = 0;
            this.ptbAnexo.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(554, 321);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // frmAnexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 352);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.ptbAnexo);
            this.Name = "frmAnexo";
            this.Text = "frmAnexo";
            this.Load += new System.EventHandler(this.frmAnexo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbAnexo;
        private System.Windows.Forms.Button btnVoltar;
    }
}