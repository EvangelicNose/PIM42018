using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace helpdesk2018.View
{
    public partial class FrmPrintChamados : Form
    {
        public FrmPrintChamados(string OS, string Nome, string Empresa, string Motivo,
            string Descricao, string Aberto, string Resposta, string Fechado)
        {
            InitializeComponent();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.ReportEmbeddedResource = "helpdesk2018.View.rptChamados.rdlc";
            ReportParameter[] p = new ReportParameter[8];
            p[0] = new ReportParameter("Nome", Nome);
            p[1] = new ReportParameter("Empresa", Empresa);
            p[2] = new ReportParameter("Motivo", Motivo);
            p[3] = new ReportParameter("Descricao", Descricao);
            p[4] = new ReportParameter("OS", OS);
            p[5] = new ReportParameter("Emissao", Aberto);
            p[6] = new ReportParameter("Resposta", Resposta);
            p[7] = new ReportParameter("Fechamento", Fechado);

            reportViewer1.LocalReport.SetParameters(p);
            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
