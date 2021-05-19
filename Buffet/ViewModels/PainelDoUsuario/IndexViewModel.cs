using Buffet.Models.Acesso;

namespace Buffet.ViewModels.PainelDoUsuario
{
    public class IndexViewModel
    {
        public DescricaoUsuario DadosUsuario { get; set; }
    }
    
    public class DescricaoUsuario
    {
        public string Id { get; set; }
        public string Email { get; set; }
        
    }
}