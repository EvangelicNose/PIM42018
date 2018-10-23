using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using CamadaModelo;
using System.Windows.Forms;

namespace CamadaDados
{
    public class ctlLogin
    {
        string Conn = @"Provider=Microsoft.JET.OLEDB.4.0;data source=" + Application.StartupPath + @"\helpdesk.mdb";
        public bool Login(string Nome, string Senha)
        {
            bool RetornoLogin = false;
            return RetornoLogin;

        }
        
        public string RetornarDados(int x, string y)
        {
            mdlUsuario _mdlusuario = new mdlUsuario();
            OleDbConnection Conexao = new OleDbConnection(Conn);
            Conexao.Open();

            string query = "select id from tb_usuarios where usuarios = @usuario";
            OleDbCommand cmd = new OleDbCommand(query, Conexao);
            cmd.Parameters.AddWithValue("@usuario", y);
            string id = "";
            OleDbDataReader resultado = cmd.ExecuteReader();
            if (resultado.Read())
            id = resultado["id"].ToString();

            resultado.Close();

            string result = "";
            string query2;
            if (x == 1)
            {
                query2 = "SELECT nomes FROM tb_usuarios WHERE id = @id";
                result = "nomes";
            }
            else
            {
                query2 = "select NomeEmpresa from tb_empresas where id = @id";
                result = "NomeEmpresa";
            }
            OleDbCommand cmd2 = new OleDbCommand(query2, Conexao);
            
            
            
            
            cmd2.Parameters.AddWithValue("@id", id);
            string retorno = "";
            resultado = cmd2.ExecuteReader();
            if (resultado.Read())
            {
                retorno = resultado[result].ToString();
            }
<<<<<<< HEAD
            resultado.Close();
=======
>>>>>>> b5cd5f1b41c5a43b6e454f48d3952b4a3450eceb
            Conexao.Close();
            return retorno;



        }
    }
}
