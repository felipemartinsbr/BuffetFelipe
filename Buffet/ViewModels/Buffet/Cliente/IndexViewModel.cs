using System.Collections.Generic;

namespace Buffet.ViewModels.Buffet.Cliente
{
    public class IndexViewModel
    {
        public ICollection<Cliente> Clientes { get; set; }
        public string MensagemSucesso { get; set; }
        public string MensagemErro { get; set; }
        public IndexViewModel()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DataDeNascimento { get; set; }
        public string Observacoes { get; set; }
        public string TipoCliente { get; set; }
        public string DataEntrada { get; set; }
        public string UltimaModificacao { get; set; }
        
    }
}