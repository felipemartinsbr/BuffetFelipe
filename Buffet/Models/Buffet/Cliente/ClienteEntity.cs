using System;
using System.Collections;
using System.Collections.Generic;
using Buffet.Models.Buffet.Evento;
using Buffet.Models.Buffet.Tipo;

namespace Buffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Observaçoes { get; set; }
        public DateTime EntradaCliente { get; set; }
        public DateTime UltimaModificacaoCliente { get; set; }
        public ICollection<EventoEntity> Eventos { get; set; }
        public TipoClienteEntity TipoCliente { get; set; }
        

        
        public ClienteEntity()
        {
            Id = new Guid();
            Eventos = new List<EventoEntity>();
        }
        
        
    }
}