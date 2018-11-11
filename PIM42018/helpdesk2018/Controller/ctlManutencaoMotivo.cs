using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using helpdesk2018.Controller;
using helpdesk2018.Model;

namespace helpdesk2018.Controller
{
    public class ctlManutencaoMotivo
    {

        public bool InserirMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "insert into tb_motivos(descricao, ativo) values(@descricao, @ativo)";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());

            var pmtdescricao = cmd.CreateParameter();
            pmtdescricao.ParameterName = "@descricao";
            pmtdescricao.DbType = DbType.String;
            pmtdescricao.Value = _mdlmanutencaomotivo.Descricao;
            cmd.Parameters.Add(pmtdescricao);
            
            var pmtativo = cmd.CreateParameter();
            pmtativo.ParameterName = "@ativo";
            pmtativo.DbType = DbType.Boolean;
            pmtativo.Value = _mdlmanutencaomotivo.Ativo;
            cmd.Parameters.Add(pmtativo);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexao.Fechar();
                return true;
            }
            else
            {
                conexao.Fechar();
                return false;
            }
        } // fim inserir motivo

        public bool PesquisaMotivo(string Descricao)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;

        }

        public DataTable PesquisaMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_motivos where motivo LIKE @motivo + \"%\"";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;
            var pmtmotivo = cmd.CreateParameter();
            pmtmotivo.ParameterName = "@descricao";
            pmtmotivo.DbType = DbType.String;
            pmtmotivo.Value = _mdlmanutencaomotivo.Descricao;
            cmd.Parameters.Add(pmtmotivo);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable motivo = new DataTable();
            da.Fill(motivo);
            return motivo;
        } // fim pesquisa motivo


        public bool AlteraMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "update tb_motivos set " +
                "descricao      = @descricao, " +
                "ativo        = @ativo " +
                "where idmotivo=@idmotivo";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;

            var pmtdescricao = cmd.CreateParameter();
            pmtdescricao.ParameterName = "@descricao";
            pmtdescricao.DbType = DbType.String;
            pmtdescricao.Value = _mdlmanutencaomotivo;
            cmd.Parameters.Add(pmtdescricao);

            var pmtativo = cmd.CreateParameter();
            pmtativo.ParameterName = "@ativo";
            pmtativo.DbType = DbType.Boolean;
            pmtativo.Value = _mdlmanutencaomotivo.Ativo;
            cmd.Parameters.Add(pmtativo);

             var pmtidmotivo = cmd.CreateParameter();
            pmtidmotivo.ParameterName = "@idmotivo";
            pmtidmotivo.DbType = DbType.String;
            pmtidmotivo.Value = _mdlmanutencaomotivo.IDMotivo;
            cmd.Parameters.Add(pmtidmotivo); 
             
            if (cmd.ExecuteNonQuery() > 0)
            {
                conexao.Fechar();
                return true;
            }
            else
            {
                conexao.Fechar();
                return false;
            }

        } // fim altera motivo


    }
}