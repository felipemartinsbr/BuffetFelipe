using System.Collections.Generic;
using BuffetFelipe.ViewModels.Shared;

namespace BuffetFelipe.ViewModels.Home
{
    public class StatusEventoViewModel
    {
        public List<Status> ListaDeStatus  { get; set; }
        
                public StatusEventoViewModel()
                {
                    ListaDeStatus = new List<Status>();
                }
    }

    
}