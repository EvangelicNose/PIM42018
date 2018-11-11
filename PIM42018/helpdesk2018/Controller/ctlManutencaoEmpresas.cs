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
    public class ctlManutencaoEmpresas
    {

        public bool InserirEmpresasMDL(global::helpdesk2018.Model.mdlManutencaoEmpresas _mdlManutencaoEmpresas)
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
            pmtativa.DbType = DbType.String;
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


        public DataTable PesquisaEmpresaMDL(global::helpdesk2018.Model.mdlManutencaoEmpresas _mdlmanutencaoempresas)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select nome, endereco from tb_empresas where nome LIKE @nome + \"%\"";
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




    }
}
