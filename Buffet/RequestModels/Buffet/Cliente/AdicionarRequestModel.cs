using System.Collections.Generic;
using Buffet.Models.Buffet.Cliente;

namespace Buffet.RequestModels.Buffet.Cliente
{
    public class AdicionarRequestModel : ClienteService.IDadosBasicosClienteModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string TipoCliente { get; set; }
        public string Cpf{ get; set; }
        public string Cnpj { get; set; }
        public string Observacoes { get; set; }

        public ICollection<string> ValidarEFiltrar()
        {
            var listaDeErros = new List<string>();

            return listaDeErros;
        }
    }
}