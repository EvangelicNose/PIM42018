namespace helpdesk2018.Controller
{ 
    public class mdlChamados
    {
        public static mdlChamados Chamado = new mdlChamados();

        public int OS { get; set; }
        public int IDusuarios { get; set; }
        public string NomeUsuario { get; set; }
        public string Empresa { get; set; }
        public string Motivo { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public string Resposta { get; set; }
        public string Anexo { get; set; }

        /*public mdlChamados(int os = 0, int idusuarios = 0, string nomeusuario = "", int idempresa = 0, string motivo = "", string descricao = "")
        {
            OS = os;
            IDusuarios = idusuarios;
            NomeUsuario = nomeusuario;
            Empresa = idempresa;
            Motivo = motivo;
            Descricao = descricao;
        }*/
    }
}

