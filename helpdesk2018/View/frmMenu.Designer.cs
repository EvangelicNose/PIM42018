namespace helpdesk2018.View
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fazerLogoffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHTCaption = new System.Windows.Forms.Label();
            this.ptbBackground = new System.Windows.Forms.PictureBox();
            this.ptbIcon = new System.Windows.Forms.PictureBox();
            this.acessibilidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botãoPCDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosToolStripMenuItem,
            this.manutençãoToolStripMenuItem,
            this.acessibilidadeToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 70);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadosToolStripMenuItem,
            this.listarChamadosToolStripMenuItem});
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.chamadosToolStripMenuItem.Text = "&Chamados";
            // 
            // abrirChamadosToolStripMenuItem
            // 
            this.abrirChamadosToolStripMenuItem.Name = "abrirChamadosToolStripMenuItem";
            this.abrirChamadosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.abrirChamadosToolStripMenuItem.Text = "&Abrir Chamados";
            this.abrirChamadosToolStripMenuItem.Click += new System.EventHandler(this.abrirChamadosToolStripMenuItem_Click);
            // 
            // listarChamadosToolStripMenuItem
            // 
            this.listarChamadosToolStripMenuItem.Name = "listarChamadosToolStripMenuItem";
            this.listarChamadosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listarChamadosToolStripMenuItem.Text = "&Listar Chamados";
            this.listarChamadosToolStripMenuItem.Click += new System.EventHandler(this.listarChamadosToolStripMenuItem_Click);
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.motivosToolStripMenuItem});
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.manutençãoToolStripMenuItem.Text = "&Manutenção";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuáriosToolStripMenuItem.Text = "&Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.empresasToolStripMenuItem.Text = "&Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // motivosToolStripMenuItem
            // 
            this.motivosToolStripMenuItem.Name = "motivosToolStripMenuItem";
            this.motivosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.motivosToolStripMenuItem.Text = "&Motivos";
            this.motivosToolStripMenuItem.Click += new System.EventHandler(this.motivosToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sobreToolStripMenuItem.Text = "&Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fazerLogoffToolStripMenuItem1,
            this.finalizarSistemaToolStripMenuItem1});
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sai&r";
            // 
            // fazerLogoffToolStripMenuItem1
            // 
            this.fazerLogoffToolStripMenuItem1.Name = "fazerLogoffToolStripMenuItem1";
            this.fazerLogoffToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.fazerLogoffToolStripMenuItem1.Text = "Fazer &Logoff";
            this.fazerLogoffToolStripMenuItem1.Click += new System.EventHandler(this.fazerLogoffToolStripMenuItem1_Click);
            // 
            // finalizarSistemaToolStripMenuItem1
            // 
            this.finalizarSistemaToolStripMenuItem1.Name = "finalizarSistemaToolStripMenuItem1";
            this.finalizarSistemaToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.finalizarSistemaToolStripMenuItem1.Text = "&Finalizar Sistema";
            this.finalizarSistemaToolStripMenuItem1.Click += new System.EventHandler(this.finalizarSistemaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(861, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHTCaption
            // 
            this.lblHTCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHTCaption.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblHTCaption.Location = new System.Drawing.Point(65, 17);
            this.lblHTCaption.Name = "lblHTCaption";
            this.lblHTCaption.Size = new System.Drawing.Size(755, 37);
            this.lblHTCaption.TabIndex = 10;
            this.lblHTCaption.Text = "label2";
            this.lblHTCaption.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ptbBackground
            // 
            this.ptbBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbBackground.BackgroundImage = global::helpdesk2018.Properties.Resources.Untitled_e1468611844859;
            this.ptbBackground.Location = new System.Drawing.Point(0, 97);
            this.ptbBackground.Name = "ptbBackground";
            this.ptbBackground.Size = new System.Drawing.Size(884, 471);
            this.ptbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBackground.TabIndex = 12;
            this.ptbBackground.TabStop = false;
            // 
            // ptbIcon
            // 
            this.ptbIcon.Image = global::helpdesk2018.Properties.Resources.HeadSet;
            this.ptbIcon.Location = new System.Drawing.Point(13, 10);
            this.ptbIcon.Name = "ptbIcon";
            this.ptbIcon.Size = new System.Drawing.Size(50, 50);
            this.ptbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbIcon.TabIndex = 11;
            this.ptbIcon.TabStop = false;
            // 
            // acessibilidadeToolStripMenuItem
            // 
            this.acessibilidadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.botãoPCDToolStripMenuItem});
            this.acessibilidadeToolStripMenuItem.Name = "acessibilidadeToolStripMenuItem";
            this.acessibilidadeToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.acessibilidadeToolStripMenuItem.Text = "&Acessibilidade";
            // 
            // botãoPCDToolStripMenuItem
            // 
            this.botãoPCDToolStripMenuItem.AutoToolTip = true;
            this.botãoPCDToolStripMenuItem.CheckOnClick = true;
            this.botãoPCDToolStripMenuItem.Name = "botãoPCDToolStripMenuItem";
            this.botãoPCDToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.botãoPCDToolStripMenuItem.Text = "Aumentar &Fonte";
            this.botãoPCDToolStripMenuItem.Click += new System.EventHandler(this.botãoPCDToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 568);
            this.Controls.Add(this.ptbBackground);
            this.Controls.Add(this.ptbIcon);
            this.Controls.Add(this.lblHTCaption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fazerLogoffToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finalizarSistemaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem motivosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHTCaption;
        private System.Windows.Forms.PictureBox ptbIcon;
        private System.Windows.Forms.PictureBox ptbBackground;
        private System.Windows.Forms.ToolStripMenuItem acessibilidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem botãoPCDToolStripMenuItem;
    }
}