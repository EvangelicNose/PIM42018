using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using helpdesk2018.Model;
using System.Data;

namespace helpdesk2018.Controller
{
    class ctlMotivo
    {
        public static List<string> motivo = new List<string>();
        public static DataTable CarregaDados()
        {
            /*Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "select * from tb_motivos";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            OleDbDataReader reader = cmd.ExecuteReader();
            motivo.Clear();
        int i = 0;
            while (reader.Read())
            {
                motivo.Add(reader["descricao"].ToString());      
            }
            reader.Close();
            conexao.Fechar();*/

            Conexao conexao = new Conexao();

            string Query = "select * from tb_motivos where ativo = true";
            OleDbDataAdapter motivos = new OleDbDataAdapter(Query, conexao.GetConexao());

            DataTable motivocbb = new DataTable();

            motivos.Fill(motivocbb);

            return motivocbb;

        }
    }
}
