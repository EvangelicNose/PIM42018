using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk2018.Model;

namespace helpdesk2018.Controller
{
    class ctlMotivo
    {
        public static List<string> motivo = new List<string>();
        public static void CarregaDados()
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "select * from tb_motivos";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            OleDbDataReader reader = cmd.ExecuteReader();

        int i = 0;
            while (reader.Read())
            {
                motivo.Add(reader["descricao"].ToString());      
            }
            reader.Close();
        }
    }
}
