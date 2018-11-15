using System.Data.OleDb;
using System.Data;
using helpdesk2018.Model;

namespace helpdesk2018.Controller
{
    public class ctlChamados
    {
        public static string Abrirchamado(int fk_motivo, string descricao)
        {
            Conexao conexao = new Conexao();

            conexao.abrir();

            OleDbCommand cmdAbrir = conexao.Comando(@"
                insert into tb_chamados
                (fk_idusuario, fk_idmotivo, fk_idstatus, descricao) values
                (@fk_idusuario, @fk_idmotivo, @fk_idstatus, @descricao)
            ");

            int status = 1; // pode tirar essa linha e alterar para linha 36


            var pmtIdUsuario = cmdAbrir.CreateParameter();
            pmtIdUsuario.Value = mdlUsuario.Logado.ID;
            pmtIdUsuario.ParameterName = "@fk_idusuario";
            pmtIdUsuario.DbType = DbType.Int16;
            cmdAbrir.Parameters.Add(pmtIdUsuario);

            var pmtidmotivo = cmdAbrir.CreateParameter();
            pmtidmotivo.Value = fk_motivo;
            pmtidmotivo.ParameterName = "@fk_idmotivo";
            pmtidmotivo.DbType = DbType.Int16;
            cmdAbrir.Parameters.Add(pmtidmotivo);

            var pmtidstatus= cmdAbrir.CreateParameter();
            // pmtidstatus.Value = 1; se fizer assim tbem resolve, nao precisa de variavel
            pmtidstatus.Value = status;
            pmtidstatus.ParameterName = "@fk_idstatus";
            pmtidstatus.DbType = DbType.Int16;
            cmdAbrir.Parameters.Add(pmtidstatus);

            var pmtdescricao = cmdAbrir.CreateParameter();
            pmtdescricao.Value = descricao;
            pmtdescricao.ParameterName = "@descricao";
            pmtdescricao.DbType = DbType.String;
            cmdAbrir.Parameters.Add(pmtdescricao);

            /*cmdAbrir.Parameters.AddWithValue("@fk_idusuario", mdlUsuario.Logado.ID);
            cmdAbrir.Parameters.AddWithValue("@fk_idmotivo", fk_motivo);
            cmdAbrir.Parameters.AddWithValue("@descricao", descricao);
            cmdAbrir.Parameters.AddWithValue("@fk_idstatus", status);*/

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
