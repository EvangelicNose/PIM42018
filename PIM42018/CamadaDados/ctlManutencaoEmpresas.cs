using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using CamadaDados;
using CamadaModelo;

namespace CamadaDados
{
    public class ctlManutencaoEmpresas
    {

        public bool InserirEmpresasMDL(global::CamadaModelo.mdlManutencaoEmpresas _mdlManutencaoEmpresas)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "insert into tb_empresas(nome, telefone, endereco) values(@nome, @telefone, @endereco)";
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

    }
}
