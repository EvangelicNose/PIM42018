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
            string query = "insert into tb_empresas(nomes, telefones, enderecos) values(@nomes, @telefones, @enderecos)";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());

            var pmtnomes = cmd.CreateParameter();
            pmtnomes.ParameterName = "@nomes";
            pmtnomes.DbType = DbType.String;
            pmtnomes.Value = _mdlManutencaoEmpresas.Nome;
            cmd.Parameters.Add(pmtnomes);

            var pmttelefones = cmd.CreateParameter();
            pmttelefones.ParameterName = "@telefones";
            pmttelefones.DbType = DbType.String;
            pmttelefones.Value = _mdlManutencaoEmpresas.Telefone;
            cmd.Parameters.Add(pmttelefones);

            var pmtenderecos = cmd.CreateParameter();
            pmtenderecos.ParameterName = "@enderecos";
            pmtenderecos.DbType = DbType.String;
            pmtenderecos.Value = _mdlManutencaoEmpresas.Endereco;
            cmd.Parameters.Add(pmtenderecos);

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
