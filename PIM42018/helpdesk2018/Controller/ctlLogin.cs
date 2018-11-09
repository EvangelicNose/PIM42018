using System;
using System.Data.OleDb;
using helpdesk2018.Model;

namespace helpdesk2018.Controller
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
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "select top 1 * from tb_usuarios where usuario = @usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            cmd.Parameters.AddWithValue("@usuario", Usuario);
            OleDbDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                mdlUsuario.Logado = new mdlUsuario(
                    id: Convert.ToInt32(reader["idusuario"]),
                    nome: reader["nome"].ToString(),
                    nivel: reader["nivelAcesso"].ToString(),
                    usuario: reader["usuario"].ToString(),
                    idempresa: Convert.ToInt32(reader["fk_idempresa"])
                );
                
            }
            reader.Close();

            query = "select top 1 * from tb_empresas where idempresa = @idempresa";
            OleDbCommand cmdEmpresa = new OleDbCommand(query, conexao.GetConexao());
            cmdEmpresa.Parameters.AddWithValue("@idempresa", mdlUsuario.Logado.IDempresa);
            reader = cmdEmpresa.ExecuteReader();
            while (reader.Read())
            {
                mdlEmpresa.Logado = new mdlEmpresa(
                    id: Convert.ToInt32(reader["idempresa"]),
                    nomeempresa: reader["nome"].ToString(),
                    enderecoempresa: reader["endereco"].ToString()
                    );
            }
            reader.Close();
            conexao.Fechar();
        }
    }
}
