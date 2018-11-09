namespace helpdesk2018.Controller { 
    public class mdlChamados
    {
        public static mdlChamados Logado;

        public int OS { get; }
        public int IDusuarios { get; }
        public string NomeUsuario { get; }
        public int IDEmpresa { get; }
        public string Motivo { get; }
        public string Descricao { get; }

        public mdlChamados(int os = 0, int idusuarios = 0, string nomeusuario = "", int idempresa = 0, string motivo = "", string descricao = "")
        {
            OS = os;
            IDusuarios = idusuarios;
            NomeUsuario = nomeusuario;
            IDEmpresa = idempresa;
            Motivo = motivo;
            Descricao = descricao;
        }
    }
}

