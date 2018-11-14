using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using helpdesk2018.Model;


namespace helpdesk2018.Controller
{
    public class ctlManutencaoUsuario
    {

        public bool InserirUsuarioMDL(global::helpdesk2018.Model.mdlManutencaoUsuario _mdlManutencaoUsuario)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string query = "insert into tb_usuarios(usuario, nome, senha, telefone, nivelAcesso, fk_idempresa, ativo) values(@usuario, @nome, @senha, @telefone, @nivelAcesso, @fk_idempresa, @ativo)";
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
            pmttelefones.Value = _mdlManutencaoUsuario.Telefone;
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

            var pmtativo = cmd.CreateParameter();
            pmtativo.ParameterName = "@ativo";
            pmtativo.DbType = DbType.Boolean;
            pmtativo.Value = _mdlManutencaoUsuario.Ativo;
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
        } // fim inserir usuario

        public bool PesquisaNome(string Nome)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;

        }

        public DataTable PesquisaNomeMDL(global::helpdesk2018.Model.mdlManutencaoUsuario _mdlmanutencaousuario)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = "select * from tb_usuarios where nome LIKE \"%\" + @nome + \"%\"";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;
            var pmtnome = cmd.CreateParameter();
            pmtnome.ParameterName = "@nome";
            pmtnome.DbType = DbType.String;
            pmtnome.Value = _mdlmanutencaousuario.Nome;
            cmd.Parameters.Add(pmtnome);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable usuarios = new DataTable();
            da.Fill(usuarios);
            return usuarios;
        }

        public bool AlteraUsuarioMDL(global::helpdesk2018.Model.mdlManutencaoUsuario _mdlmanutencaousuario)
        {
            Conexao conexao = new Conexao();
            conexao.abrir();
            string Query = @"
                update tb_usuarios
                set
                    usuario = @usuario,
                    nome = @nome,
                    senha = @senha,
                    telefone = @telefone,
                    nivelAcesso = @nivelAcesso,
                    fk_idempresa = @fk_idempresa,
                    ativo = @ativo
                where idusuario = @idusuario
            ";
            OleDbCommand cmd = new OleDbCommand(Query, conexao.GetConexao());
            cmd.CommandType = CommandType.Text;
            
            OleDbParameter pmtusuarios = cmd.CreateParameter();
            pmtusuarios.ParameterName = "@usuario";
            pmtusuarios.DbType = DbType.String;
            pmtusuarios.Value = _mdlmanutencaousuario.Usuario;
            cmd.Parameters.Add(pmtusuarios);

            OleDbParameter pmtnomes = cmd.CreateParameter();
            pmtnomes.ParameterName = "@nome";
            pmtnomes.DbType = DbType.String;
            pmtnomes.Value = _mdlmanutencaousuario.Nome;
            cmd.Parameters.Add(pmtnomes);

            OleDbParameter pmtsenhas = cmd.CreateParameter();
            pmtsenhas.ParameterName = "@senha";
            pmtsenhas.DbType = DbType.String;
            pmtsenhas.Value = _mdlmanutencaousuario.Senha;
            cmd.Parameters.Add(pmtsenhas);

            OleDbParameter pmttelefones = cmd.CreateParameter();
            pmttelefones.ParameterName = "@telefone";
            pmttelefones.DbType = DbType.String;
            pmttelefones.Value = _mdlmanutencaousuario.Telefone;
            cmd.Parameters.Add(pmttelefones);

            OleDbParameter pmtnivelAcesso = cmd.CreateParameter();
            pmtnivelAcesso.ParameterName = "@nivelAcesso";
            pmtnivelAcesso.DbType = DbType.String;
            pmtnivelAcesso.Value = _mdlmanutencaousuario.Nivel;
            cmd.Parameters.Add(pmtnivelAcesso);

            OleDbParameter pmtidempresas = cmd.CreateParameter();
            pmtidempresas.ParameterName = "@fk_idempresa";
            pmtidempresas.DbType = DbType.String;
            pmtidempresas.Value = _mdlmanutencaousuario.Empresa;
            cmd.Parameters.Add(pmtidempresas);

            OleDbParameter pmtativo = cmd.CreateParameter();
            pmtativo.ParameterName = "@ativo";
            pmtativo.DbType = DbType.Boolean;
            pmtativo.Value = _mdlmanutencaousuario.Ativo;
            cmd.Parameters.Add(pmtativo);

            OleDbParameter pmtidusuario = cmd.CreateParameter();
            pmtidusuario.ParameterName = "@idusuario";
            pmtidusuario.DbType = DbType.String;
            pmtidusuario.Value = _mdlmanutencaousuario.IDUsuario;
            cmd.Parameters.Add(pmtidusuario);

            int resultado = cmd.ExecuteNonQuery();
            conexao.Fechar();
            return resultado > 0;
        }

    }
}
