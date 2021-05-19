using System;
using System.Collections.Generic;

namespace Buffet.Models.Buffet.Evento
{
    public class LocalEventoEntity
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public ICollection<EventoEntity> Eventos { get; set; }

        public LocalEventoEntity()
        {
            Id = new Guid();
            Eventos = new List<EventoEntity>();
        }
    }
}