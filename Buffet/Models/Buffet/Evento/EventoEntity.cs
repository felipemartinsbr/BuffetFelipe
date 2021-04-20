using System;
using Buffet.Models.Buffet.Cliente;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ClienteEntity Cliente { get; set; }

        public EventoEntity()
        {
            Id = new Guid();
        }
    }
}