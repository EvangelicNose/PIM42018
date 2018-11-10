namespace helpdesk2018.Model
{
    public class mdlEmpresa
    {
        public static mdlEmpresa Logado;

        public int ID { get; }
        public string NomeEmpresa { get; }
        public string EnderecoEmpresa { get; }

        public mdlEmpresa(int id, string nomeempresa, string enderecoempresa)
        {
            ID = id;
            NomeEmpresa = nomeempresa;
            EnderecoEmpresa = enderecoempresa;
        }
    }
    

}
