using System.Collections.Generic;
using Buffet.Models.Buffet.Tipo;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Buffet.ViewModels.Buffet.Cliente
{
    public class AdicionarViewModel
    {
        public string[] FormMensagensErro { get; set; }
        public ICollection<SelectListItem> TipoClientes { get; set; }
        
        public AdicionarViewModel()
        {
            TipoClientes = new List<SelectListItem>
            {
                new SelectListItem("Selecione", "")
            };
        }
    }
}