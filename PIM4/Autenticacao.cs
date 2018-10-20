using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM4
{
    static class Autenticacao
    {
        static string Usuario;
        static string Senha;


        public static void login(string usuario1, string senha1)
        {
            Usuario = usuario1;
            Senha = senha1;

        }

        public static String getUsuario()
        {
            return "Usuario: " + Usuario + "\nSenha: " + Senha;
        }
    }
}
