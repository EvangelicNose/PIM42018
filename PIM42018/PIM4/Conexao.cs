﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace PIM4
{

    class Conexao
    {
    public OleDbConnection cn = new OleDbConnection();
    
        public void conectar()
        {
            cn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Very Good\Desktop\Pim4Thiago\Banco\senhas.mdb";
            cn.Open();
        }
    }
}
