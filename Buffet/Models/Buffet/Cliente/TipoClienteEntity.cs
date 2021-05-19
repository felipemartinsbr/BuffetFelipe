using System;

namespace Buffet.Models.Buffet.Tipo
{
    public class TipoClienteEntity
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        
        public TipoClienteEntity()
        {
            Id = new Guid();
        }
        
    }

}