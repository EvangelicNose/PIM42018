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
    public static class ctlManutencaoEmpresas
    {
        public static bool VerificarDuplicidade(string nome)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string qexiste = "select count(1) from tb_empresas where nome = @nome";
            OleDbCommand cmdver = new OleDbCommand(qexiste, conexao.GetConexao());

            cmdver.CommandType = CommandType.Text;
            var pmtnome = cmdver.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = nome;
            cmdver.Parameters.Add(pmtnome);
            
            int verif = (int)cmdver.ExecuteScalar();
            // int existeok = 0;

            if (verif > 0)
            {
                // found = true;
                return true;
            }
            else
            {
                //  found = false;   
                return false;
            }
        }

        public static bool VerificarDuplicidade(string nome, int id)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string qexiste = "select count(1) from tb_empresas where nome = @nome and idempresa <> @id";
            OleDbCommand cmdver = new OleDbCommand(qexiste, conexao.GetConexao());

            cmdver.CommandType = CommandType.Text;
            var pmtnome = cmdver.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = nome;
            cmdver.Parameters.Add(pmtnome);

            cmdver.CommandType = CommandType.Text;
            var pmtid = cmdver.CreateParameter();
            pmtid.ParameterName = "@id";
            pmtid.DbType = DbType.Int16;
            pmtid.Value = id;
            cmdver.Parameters.Add(pmtid);

            int verif = (int)cmdver.ExecuteScalar();
            // int existeok = 0;

            if (verif > 0)
            {
                // found = true;
                return true;
            }
            else
            {
                //  found = false;   
                return false;
            }
        }

        public static bool InserirEmpresasMDL(global::helpdesk2018.Model.mdlManutencaoEmpresas _mdlManutencaoEmpresas)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "insert into tb_empresas(nome, telefone, endereco, ativa) values(@nome, @telefone, @endereco, @ativa)";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());

            var pmtnome = cmd.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = _mdlManutencaoEmpresas.Nome;
            cmd.Parameters.Add(pmtnome);

            var pmttelefone = cmd.CreateParameter();
            pmttelefone.ParameterName = "@telefone";
            pmttelefone.DbType = DbType.String;
            pmttelefone.Value = _mdlManutencaoEmpresas.Telefone;
            cmd.Parameters.Add(pmttelefone);

            var pmtendereco = cmd.CreateParameter();
            pmtendereco.ParameterName = "@endereco";
            pmtendereco.DbType = DbType.String;
            pmtendereco.Value = _mdlManutencaoEmpresas.Endereco;
            cmd.Parameters.Add(pmtendereco);

            var pmtativa = cmd.CreateParameter();
            pmtativa.ParameterName = "@ativa";
            pmtativa.DbType = DbType.Boolean;
            pmtativa.Value = _mdlManutencaoEmpresas.Ativa;
            cmd.Parameters.Add(pmtativa);

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


        public static DataTable PesquisaEmpresaMDL(global::helpdesk2018.Model.mdlManutencaoEmpresas _mdlmanutencaoempresas)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_empresas where nome LIKE \"%\" + @nome + \"%\"";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;
            var pmtnome = cmd.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = _mdlmanutencaoempresas.Nome;
            cmd.Parameters.Add(pmtnome);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable empresas = new DataTable();
            da.Fill(empresas);
            return empresas;
        }

        public static bool AlteraEmpresaMDL(global::helpdesk2018.Model.mdlManutencaoEmpresas _mdlmanutencaoempresa)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = @"
                update tb_empresas
                set 
                    nome = @nome, 
                    telefone = @telefone,
                    endereco = @endereco,
                    ativa = @ativa
                where idempresa = @idempresa
            ";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;

            OleDbParameter pmtnome = cmd.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = _mdlmanutencaoempresa.Nome;
            cmd.Parameters.Add(pmtnome);

            OleDbParameter pmttelefone = cmd.CreateParameter();
            pmttelefone.ParameterName = "@telefone";
            pmttelefone.DbType = DbType.String;
            pmttelefone.Value = _mdlmanutencaoempresa.Telefone;
            cmd.Parameters.Add(pmttelefone);

            OleDbParameter pmtendereco = cmd.CreateParameter();
            pmtendereco.ParameterName = "@endereco";
            pmtendereco.DbType = DbType.String;
            pmtendereco.Value = _mdlmanutencaoempresa.Endereco;
            cmd.Parameters.Add(pmtendereco);

            OleDbParameter pmtativa = cmd.CreateParameter();
            pmtativa.ParameterName = "@ativa";
            pmtativa.DbType = DbType.Boolean;
            pmtativa.Value = _mdlmanutencaoempresa.Ativa;
            cmd.Parameters.Add(pmtativa);

            OleDbParameter pmtempresa = cmd.CreateParameter();
            pmtempresa.ParameterName = "@idempresa";
            pmtempresa.DbType = DbType.Int16;
            pmtempresa.Value = _mdlmanutencaoempresa.ID;
            cmd.Parameters.Add(pmtempresa);

            int resultado = cmd.ExecuteNonQuery();
            
            conexao.Fechar();
            return resultado > 0;
        } // fim altera motivo


    }
}
