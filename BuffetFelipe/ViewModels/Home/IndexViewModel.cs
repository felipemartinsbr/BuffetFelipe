namespace BuffetFelipe.ViewModels.Home
{
    public class IndexViewModel
    {
        public string InformacaoQualquer { get; set; }
        public string Titulo { get; set; }

        public Usuario UsuarioLogado { get; set; }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}