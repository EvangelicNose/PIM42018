using System.Data.OleDb;
using CamadaModelo;

namespace CamadaDados
{
    public static class ctlChamados
    {
        public static void Abrir(string motivo, string descricao)
        {
            Conexao conexao = new Conexao();

            OleDbCommand cmd = conexao.Comando(@"
                insert into tb_chamados
                (idusuarios, nome, idempresas, idmotivos, obs) values
                (@idusuario, @nome, @idempresa, @idmotivo, @obs)
            ");

            // cmd.Parameters.AddWithValue("@idusuario", );
        }

        public static string ConsultaUsuario(string usuario)
        {
            Conexao conexao = new Conexao();
            OleDbCommand cmd = conexao.Comando("select id from tb_usuarios where usuarios = @usuario");
            cmd.Parameters.AddWithValue("@usuario", usuario);
            string id = "";
            OleDbDataReader resultado = cmd.ExecuteReader();
            if (resultado.Read())
                id = resultado["id"].ToString();
            resultado.Close();

            string result = "";
            string query2;
            query2 = "SELECT nomes FROM tb_usuarios WHERE id = @id";
            result = "nomes";
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

        public static string ConsultaEmpresa(string empresa)
        {
            Conexao conexao = new Conexao();
            OleDbCommand cmd = conexao.Comando(@"
                select id from tb_usuarios
                where usuarios = @usuario
            ");
            cmd.Parameters.AddWithValue("@usuario", empresa);
            string id = "";
            OleDbDataReader resultado = cmd.ExecuteReader();
            if (resultado.Read())
                id = resultado["id"].ToString();
            resultado.Close();

            string result = "";
            result = "NomeEmpresa";
            OleDbCommand cmd2 = conexao.Comando(@"
                select NomeEmpresa from tb_empresas
                where id = @id
            ");

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
