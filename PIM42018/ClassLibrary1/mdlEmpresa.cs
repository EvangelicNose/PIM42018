namespace CamadaModelo
{
    public class mdlEmpresa
    {
        public int ID { get; set; }
        public string Usuario { get; set; }
        string Senha { get; set; }
        public string Nome { get; set; }
        public string Nivel { get; set; }

        public mdlEmpresa(int id, string usuario, string senha, string nome, string nivel)
        {
            ID = id;
            Usuario = usuario;
            Senha = senha;
            Nome = nome;
            Nivel = nivel;
        }
    }
}
