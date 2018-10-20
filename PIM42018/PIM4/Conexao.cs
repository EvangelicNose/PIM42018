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
    public OleDbConnection cn = new OleDbConnection();
    
        public void conectar()
        {
            cn.ConnectionString = @"Provider=Microsoft.JET.OLEDB.4.0;data source="+ Application.StartupPath + @"\senhas.mdb";
            cn.Open();
        }
    }
}
