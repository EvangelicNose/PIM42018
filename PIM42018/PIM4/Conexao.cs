using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PIM4
{

    class Conexao
    {
    public OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;data source=" + Application.StartupPath + @"\helpdesk.mdb");
    
        public void conectar()
        {
            cn.Open();
        }
        public void desconectar()
        {
            cn.Close();
        }
    }
}
