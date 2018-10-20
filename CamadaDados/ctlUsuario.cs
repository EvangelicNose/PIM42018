using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CamadaModelo;
using System.Data;
using System.Data.OleDb;

namespace CamadaDados
{
    public class ctlUsuario
    {
        public bool PesquisarUsuario(string Usuario)
        {
            bool RetornoPesquisar = false;
            return RetornoPesquisar;

        }

        public DataTable PesquisarUsuarioMDL(global::CamadaModelo.mdlUsuario _mdlUsuario)
        {
            string ConexaoAccess = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\PIM4\Banco\helpdesk.mdb";
            OleDbConnection ConexaoDB = new OleDbConnection(ConexaoAccess);
            ConexaoDB.Open();
            string Query = "select * from tb_usuarios where usuario LIKE @Usuario";
            OleDbCommand cmd = new OleDbCommand(Query, ConexaoDB);
            cmd.CommandType = CommandType.Text;
            var pmtUsuario = cmd.CreateParameter();
            pmtUsuario.ParameterName = "@Usuario";
            pmtUsuario.DbType = DbType.String;
            pmtUsuario.Value = _mdlUsuario.Usuario;
            cmd.Parameters.Add(pmtUsuario);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable usuarios = new DataTable();
            da.Fill(usuarios);
            return usuarios;


        }
    }
}
