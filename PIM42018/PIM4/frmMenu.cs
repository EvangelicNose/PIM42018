﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM4
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void abrirChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberturaChamados _frmaberturachamados = new frmAberturaChamados();
            _frmaberturachamados.MdiParent = this;
            _frmaberturachamados.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}