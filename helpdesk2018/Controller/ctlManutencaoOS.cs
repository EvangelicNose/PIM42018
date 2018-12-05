using helpdesk2018.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpdesk2018.Controller
{
    public static class ctlManutencaoOS
    {

        public static DataTable ListarOS()
        {
            Conexao conexao = new Conexao();
            conexao.abrir();

            string SQL;

            if (mdlUsuario.Logado.Nivel == "0")
            {
                SQL = "SELECT tb_chamados.os AS OS, tb_empresas.nome AS EMPRESA, tb_motivos.descricao AS CAUSA," +
                    " tb_status.descricao AS STATUS," +
                    " tb_usuarios.usuario AS RESPONSÁVEL FROM (tb_empresas INNER JOIN tb_usuarios ON tb_empresas.idempresa = " +
                    "tb_usuarios.fk_idempresa) INNER JOIN(tb_status INNER JOIN" +
                    " (tb_motivos INNER JOIN tb_chamados ON tb_motivos.idmotivo =" +
                    " tb_chamados.fk_idmotivo) ON tb_status.idstatus = tb_chamados.fk_idstatus) " +
                    "ON tb_usuarios.idusuario = tb_chamados.fk_idusuario " +
                    "WHERE fk_idusuario = @idusuario order by OS desc;";
            }
            else
            {
                SQL = "SELECT tb_chamados.os AS OS, tb_empresas.nome AS EMPRESA, tb_motivos.descricao AS CAUSA," +
                    " tb_status.descricao AS STATUS," +
                    " tb_usuarios.usuario AS RESPONSÁVEL FROM (tb_empresas INNER JOIN tb_usuarios ON tb_empresas.idempresa = " +
                    "tb_usuarios.fk_idempresa) INNER JOIN(tb_status INNER JOIN" +
                    " (tb_motivos INNER JOIN tb_chamados ON tb_motivos.idmotivo =" +
                    " tb_chamados.fk_idmotivo) ON tb_status.idstatus = tb_chamados.fk_idstatus) " +
                    "ON tb_usuarios.idusuario = tb_chamados.fk_idusuario order by OS desc;";
            }
            OleDbCommand cmd = new OleDbCommand(SQL, conexao.GetConexao());

            var pmtIDUsuario = cmd.CreateParameter();
            pmtIDUsuario.ParameterName = "@idusuario";
            pmtIDUsuario.DbType = DbType.Int16;
            pmtIDUsuario.Value = mdlUsuario.Logado.ID;
            cmd.Parameters.Add(pmtIDUsuario);



            OleDbDataAdapter os = new OleDbDataAdapter(cmd);
            DataTable ListaChamados = new DataTable();
            os.Fill(ListaChamados);
            return ListaChamados;
        }
    }
}
