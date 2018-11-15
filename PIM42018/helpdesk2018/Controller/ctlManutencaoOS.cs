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
    class ctlManutencaoOS
    {

        public DataTable ListarOS()
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string SQL = "SELECT tb_chamados.os AS OS, tb_empresas.nome AS EMPRESA, tb_motivos.descricao AS CAUSA," +
                " tb_status.descricao AS STATUS," +
                " tb_usuarios.usuario AS RESPONSÁVEL FROM (tb_empresas INNER JOIN tb_usuarios ON tb_empresas.idempresa = " +
                "tb_usuarios.fk_idempresa) INNER JOIN(tb_status INNER JOIN" +
                " (tb_motivos INNER JOIN tb_chamados ON tb_motivos.idmotivo =" +
                " tb_chamados.fk_idmotivo) ON tb_status.idstatus = tb_chamados.fk_idstatus) " +
                "ON tb_usuarios.idusuario = tb_chamados.fk_idusuario;";
            OleDbCommand cmd = new OleDbCommand(SQL, conexao.GetConexao());
            OleDbDataAdapter os = new OleDbDataAdapter(SQL, conexao.GetConexao());
            DataTable ListaChamados = new DataTable();
            os.Fill(ListaChamados);
            return ListaChamados;
        }
    }
}
