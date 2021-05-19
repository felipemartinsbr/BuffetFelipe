using System;

namespace Buffet.Models.Buffet.Tipo
{
    public class TipoEventoEntity
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public TipoEventoEntity()
        {
            Id = new Guid();
        }
    }
}