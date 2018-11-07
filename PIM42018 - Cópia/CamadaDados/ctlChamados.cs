using System.Data.OleDb;
using CamadaModelo;

namespace CamadaDados
{
    public class ctlChamados
    {
        public static string Abrirchamado(string motivo, string descricao)
        {
            Conexao conexao = new Conexao();

            conexao.abrir();

            OleDbCommand cmdAbrir = conexao.Comando(@"
                insert into tb_chamados
                (idusuarios, nome, empresa, motivo, descricao) values
                (@idusuario, @nome, @empresa, @motivo, @obs)
            ");

            cmdAbrir.Parameters.AddWithValue("@idusuario", mdlUsuario.Logado.ID);
            cmdAbrir.Parameters.AddWithValue("@nome", mdlUsuario.Logado.Nome);
            cmdAbrir.Parameters.AddWithValue("@empresa", mdlEmpresa.Logado.NomeEmpresa);
            cmdAbrir.Parameters.AddWithValue("@motivo", motivo);
            cmdAbrir.Parameters.AddWithValue("@descicao", descricao);

            string retorno = "";

            cmdAbrir.ExecuteNonQuery();

            OleDbCommand cmdOS = conexao.Comando(@"
            select top 1 * from tb_chamados order by OS DESC
            ");

            OleDbDataReader reader = cmdOS.ExecuteReader();
            
            while (reader.Read())
            {
                retorno = reader["OS"].ToString();

            }
            reader.Close();
            conexao.Fechar();

            return retorno;
        }
    }
}
