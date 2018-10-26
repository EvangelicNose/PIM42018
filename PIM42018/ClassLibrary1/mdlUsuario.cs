namespace CamadaModelo
{
    public class mdlUsuario
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        string Senha { get; set; }
        public string Nome { get; set; }
        public string Nivel { get; set; }
        public string Empresa { get; set; }

        public mdlUsuario(int id, string usuario, string nome, string nivel, string senha = "")
        {
            ID = id;
            Usuario = usuario;
            Senha = senha;
            Nome = nome;
            Nivel = nivel;
        }
    }
}
