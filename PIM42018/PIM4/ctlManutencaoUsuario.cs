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
    public class ctlManutencaoUsuario
    {

        public bool InserirUsuarioMDL(global::CamadaModelo.mdlManutencaoUsuario _mdlManutencaoUsuario)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "insert into tb_usuarios(usuarios, nomes, senhas, nivelAcesso) values(@usuarios, @nomes, @senhas, @nivelAcesso)";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            
            var pmtusuarios = cmd.CreateParameter();
            pmtusuarios.ParameterName = "@usuarios";
            pmtusuarios.DbType = DbType.String;
            pmtusuarios.Value = _mdlManutencaoUsuario.Usuario;
            cmd.Parameters.Add(pmtusuarios);

            var pmtnomes = cmd.CreateParameter();
            pmtnomes.ParameterName = "@nomes";
            pmtnomes.DbType = DbType.String;
            pmtnomes.Value = _mdlManutencaoUsuario.Nome;
            cmd.Parameters.Add(pmtnomes);

            var pmtsenhas = cmd.CreateParameter();
            pmtsenhas.ParameterName = "@senhas";
            pmtsenhas.DbType = DbType.String;
            pmtsenhas.Value = _mdlManutencaoUsuario.Senha;
            cmd.Parameters.Add(pmtsenhas);

            var pmtnivelAcesso = cmd.CreateParameter();
            pmtnivelAcesso.ParameterName = "@nivelAcesso";
            pmtnivelAcesso.DbType = DbType.String;
            pmtnivelAcesso.Value = _mdlManutencaoUsuario.Nivel;
            cmd.Parameters.Add(pmtnivelAcesso);

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
