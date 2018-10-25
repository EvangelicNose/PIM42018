using System.Data.OleDb;
using System.Windows.Forms;

namespace CamadaDados
{
    public class Conexao
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.JET.OLEDB.4.0;data source=" + Application.StartupPath + @"\helpdesk.mdb");

        public void abrir()
        {
            connection.Open();
        }

        public OleDbConnection GetConexao()
        {
            return connection;
        }

        public OleDbCommand Comando(string consulta)
        {
            return new OleDbCommand(consulta, connection);
        }

        public void Fechar()
        {
            connection.Close();
        }
    }
}
