using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BuffetFelipe.Models.Buffet.Cliente;

namespace BuffetFelipe.Models.Buffet.Evento
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