using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using BuffetFelipe.Models.Buffet.Evento;

namespace BuffetFelipe.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ICollection<EventoEntity> Eventos { get; set; }


        public ClienteEntity()
        {
            Id = new Guid();
            Eventos = new List<EventoEntity>();
        }
}