using System.Data.OleDb;
using CamadaModelo;
using System.Windows.Forms;

namespace CamadaDados
{
    public static class ctlLogin
    {
        public static bool Login(string Nome, string Senha)
        {
            bool RetornoLogin = false;
            return RetornoLogin;
        }
        
        public static string RetornarDados(int x, string y)
        {
            Conexao conexao = new Conexao();
            OleDbCommand cmd = conexao.Comando("select id from tb_usuarios where usuarios = @usuario");
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
            OleDbCommand cmd2 = conexao.Comando(query2);
            
            cmd2.Parameters.AddWithValue("@id", id);
            string retorno = "";
            resultado = cmd2.ExecuteReader();
            if (resultado.Read())
            {
                retorno = resultado[result].ToString();
            }
            resultado.Close();

            conexao.Fechar();
            return retorno;
        }
    }
}
