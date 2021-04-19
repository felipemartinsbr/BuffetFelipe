using System.Collections.Generic;
using BuffetFelipe.ViewModels.Shared;

namespace BuffetFelipe.ViewModels.Home
{
    public class StatusConvidadoViewModel
    {
        public List<Status> ListaDeStatus  { get; set; }
        
        public StatusConvidadoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }
    }

    
}