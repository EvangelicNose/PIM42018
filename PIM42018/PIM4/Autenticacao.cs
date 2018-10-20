using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4
{
    class Autenticacao
    {
        static string Nome;
        static string Senha;


        public static void login(string nome1, string senha1)
        {
            Nome = nome1;
            Senha = senha1;

        }

        public static String getUsuario()
        {
            return "Nome: " + Nome + "\nSenha: " + Senha;
        }
    }
}
