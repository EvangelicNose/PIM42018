using System;
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
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "select top 1 * from tb_usuarios where usuarios = @usuario";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            cmd.Parameters.AddWithValue("@usuario", Usuario);
            OleDbDataReader reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                mdlUsuario.Logado = new mdlUsuario(
                    id: Convert.ToInt32(reader["id"]),
                    nome: reader["nomes"].ToString(),
                    nivel: reader["nivelAcesso"].ToString(),
                    usuario: reader["usuarios"].ToString(),
                    idempresa: Convert.ToInt32(reader["idempresas"])
                );
                
            }
            reader.Close();

            query = "select top 1 * from tb_empresas where id = @idempresas";
            OleDbCommand cmdEmpresa = new OleDbCommand(query, conexao.GetConexao());
            cmdEmpresa.Parameters.AddWithValue("@idempresas", mdlUsuario.Logado.IDempresa);
            reader = cmdEmpresa.ExecuteReader();
            while (reader.Read())
            {
                mdlEmpresa.Logado = new mdlEmpresa(
                    id: Convert.ToInt32(reader["id"]),
                    nomeempresa: reader["nomes"].ToString(),
                    enderecoempresa: reader["enderecos"].ToString()
                    );
            }
            reader.Close();
            conexao.Fechar();
        }
    }
}
