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
            string query = "insert into tb_usuarios(usuario, nome, senha, telefone, nivelAcesso, fk_idempresa) values(@usuario, @nome, @senha, @telefone, @nivelAcesso, @fk_idempresa)";
            OleDbCommand cmd = new OleDbCommand(query, conexao.GetConexao());
            
            var pmtusuarios = cmd.CreateParameter();
            pmtusuarios.ParameterName = "@usuario";
            pmtusuarios.DbType = DbType.String;
            pmtusuarios.Value = _mdlManutencaoUsuario.Usuario;
            cmd.Parameters.Add(pmtusuarios);

            var pmtnomes = cmd.CreateParameter();
            pmtnomes.ParameterName = "@nome";
            pmtnomes.DbType = DbType.String;
            pmtnomes.Value = _mdlManutencaoUsuario.Nome;
            cmd.Parameters.Add(pmtnomes);

            var pmtsenhas = cmd.CreateParameter();
            pmtsenhas.ParameterName = "@senha";
            pmtsenhas.DbType = DbType.String;
            pmtsenhas.Value = _mdlManutencaoUsuario.Senha;
            cmd.Parameters.Add(pmtsenhas);

            var pmttelefones = cmd.CreateParameter();
            pmttelefones.ParameterName = "@telefone";
            pmttelefones.DbType = DbType.String;
            pmttelefones.Value = _mdlManutencaoUsuario.Senha;
            cmd.Parameters.Add(pmttelefones);

            var pmtnivelAcesso = cmd.CreateParameter();
            pmtnivelAcesso.ParameterName = "@nivelAcesso";
            pmtnivelAcesso.DbType = DbType.String;
            pmtnivelAcesso.Value = _mdlManutencaoUsuario.Nivel;
            cmd.Parameters.Add(pmtnivelAcesso);

            var pmtidempresas = cmd.CreateParameter();
            pmtidempresas.ParameterName = "@fk_idempresa";
            pmtidempresas.DbType = DbType.String;
            pmtidempresas.Value = _mdlManutencaoUsuario.Empresa;
            cmd.Parameters.Add(pmtidempresas);

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
