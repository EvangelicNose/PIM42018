namespace helpdesk2018.Controller
{
    public class mdlUsuario
    {
        public static mdlUsuario Logado;

        public int ID { get; }
        public string Usuario { get; }
        string Senha { get; }
        public string Nome { get; }
        public string Nivel { get; }
        public string Empresa { get; }
        public int IDempresa { get; }

        public mdlUsuario(int id, int idempresa, string usuario, string nome, string nivel, string senha = "")
        {
            ID = id;
            Usuario = usuario;
            Senha = senha;
            Nome = nome;
            Nivel = nivel;
            IDempresa = idempresa;
        }
    }
}
