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
    public static class ctlManutencaoMotivo
    {
        public static int retorno=0;
        public static int retornoA = 1;
        public static int ja = 1;
        public static bool InserirMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();

            string qexiste = "select count(1) from tb_motivos where descricao = @descricao";
            OleDbCommand cmdver = new OleDbCommand(qexiste, conexao.GetConexao());
           
            cmdver.CommandType = CommandType.Text;
            OleDbParameter pmtmotivo = cmdver.CreateParameter();
            pmtmotivo.ParameterName = "@descricao";
            pmtmotivo.DbType = DbType.String;
            pmtmotivo.Value = _mdlmanutencaomotivo.Descricao;
            cmdver.Parameters.Add(pmtmotivo);

            int verif = (int)cmdver.ExecuteScalar();
            int existeok = 0;
          
            if (verif > 0)
            {
                // found = true;
                existeok = 1;
            }
            else
            {
                //  found = false;   
                existeok = 0;
            }


            if (existeok == 0)
            {

                string query = "insert into tb_motivos(descricao, ativo) values(@descricao, @ativo)";
                OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());

                OleDbParameter pmtdescricao = cmd.CreateParameter();
                pmtdescricao.ParameterName = "@descricao";
                pmtdescricao.DbType = DbType.String;
                pmtdescricao.Value = _mdlmanutencaomotivo.Descricao;
                cmd.Parameters.Add(pmtdescricao);

                OleDbParameter pmtativo = cmd.CreateParameter();
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
                
            }
            retorno = 1;
            return false;

        } // fim inserir motivo

        public static bool PesquisaMotivo(string Descricao)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;

        }

        public static DataTable PesquisaMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_motivos where descricao LIKE \"%\" + @descricao + \"%\"";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;
            OleDbParameter pmtmotivo = cmd.CreateParameter();
            pmtmotivo.ParameterName = "@descricao";
            pmtmotivo.DbType = DbType.String;
            pmtmotivo.Value = _mdlmanutencaomotivo.Descricao;
            cmd.Parameters.Add(pmtmotivo);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable motivo = new DataTable();
            da.Fill(motivo);
            return motivo;
        } // fim pesquisa motivo


        public static bool AlteraMotivoMDL(global::helpdesk2018.Model.mdlManutencaoMotivo _mdlmanutencaomotivo)
        {

            Conexao conexao = new Conexao();
            conexao.abrir();

            string qexiste = @"
                select count(1)
                from tb_motivos
                where
                    descricao = @descricao
                    and idmotivo <> @idmotivo
            ";
            OleDbCommand cmdver = new OleDbCommand(qexiste, conexao.GetConexao());

            cmdver.CommandType = CommandType.Text;
            OleDbParameter pmtmotivo = cmdver.CreateParameter();
            pmtmotivo.ParameterName = "@descricao";
            pmtmotivo.DbType = DbType.String;
            pmtmotivo.Value = _mdlmanutencaomotivo.Descricao;
            cmdver.Parameters.Add(pmtmotivo);

            OleDbParameter pmtidmotivover = cmdver.CreateParameter();
            pmtidmotivover.ParameterName = "@idmotivo";
            pmtidmotivover.DbType = DbType.Int16;
            pmtidmotivover.Value = _mdlmanutencaomotivo.IDMotivo;
            cmdver.Parameters.Add(pmtidmotivover);

            int verif = (int)cmdver.ExecuteScalar();
            int existeok = 0;

            if (verif > 0 && ja ==1)
            {
                // found = true;
                existeok = 1;
                retornoA = 1;
               // retorno = 1;
            }
            else
            {
                //  found = false;   
                existeok = 0;
                retornoA = 0;
            }


            if (existeok == 0)
            {

                string Query = @"
                update tb_motivos
                set descricao = @descricao, ativo = @ativo
                where idmotivo = @idmotivo
            ";
                OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
                cmd.CommandType = CommandType.Text;

                OleDbParameter pmtdescricao = cmd.CreateParameter();
                pmtdescricao.ParameterName = "@descricao";
                pmtdescricao.DbType = DbType.String;
                pmtdescricao.Value = _mdlmanutencaomotivo.Descricao;
                cmd.Parameters.Add(pmtdescricao);

                OleDbParameter pmtativo = cmd.CreateParameter();
                pmtativo.ParameterName = "@ativo";
                pmtativo.DbType = DbType.Boolean;
                pmtativo.Value = _mdlmanutencaomotivo.Ativo;
                cmd.Parameters.Add(pmtativo);

                OleDbParameter pmtidmotivo = cmd.CreateParameter();
                pmtidmotivo.ParameterName = "@idmotivo";
                pmtidmotivo.DbType = DbType.Int16;
                pmtidmotivo.Value = _mdlmanutencaomotivo.IDMotivo;
                cmd.Parameters.Add(pmtidmotivo);

                int resultado = cmd.ExecuteNonQuery();
                conexao.Fechar();
                ja = 1;
                return resultado > 0;               
            }

             //ja = 0;
            return false;
        } // fim altera motivo


    }
}