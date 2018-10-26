using System.Data.OleDb;
using CamadaModelo;

namespace CamadaDados
{
    public static class ctlLogin
    {
        public static bool Login(string Nome, string Senha)
        {
            bool RetornoLogin = false;
            return RetornoLogin;
        }

        public static void GuardarDados(string Usuario)
        {
            mdlUsuario _mdlusuario = new mdlUsuario();
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "select * from tb_usuarios where usuarios = @usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            cmd.Parameters.AddWithValue("@usuario", Usuario);
            OleDbDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                _mdlusuario.NomeUsuario = reader["nomes"].ToString();
                _mdlusuario.NivelUsuario = reader["nivelAcesso"].ToString();
                _mdlusuario.IDusuario = reader["id"].ToString();
                _mdlusuario.Usuario = reader["usuarios"].ToString();
                
            }
            reader.Close();
            conexao.Fechar();
            


        }
    }
}
