using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helpdesk2018.View
{
    public partial class FrmPrintChamados : Form
    {
        public FrmPrintChamados(string OS, string Nome, string Empresa, string Motivo,
            string Descricao, string Aberto, string Resposta)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "helpdesk2018.View.rptChamados.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[6];
            p[0] = new Microsoft.Reporting.WinForms.ReportParameter("Nome", Nome);
            p[1] = new Microsoft.Reporting.WinForms.ReportParameter("Empresa", Empresa);
            p[2] = new Microsoft.Reporting.WinForms.ReportParameter("Motivo", Motivo);
            p[3] = new Microsoft.Reporting.WinForms.ReportParameter("Descricao", Descricao);
            p[4] = new Microsoft.Reporting.WinForms.ReportParameter("OS", OS);
          //  p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Aberto", Aberto);
            p[5] = new Microsoft.Reporting.WinForms.ReportParameter("Resposta", Resposta);
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}
