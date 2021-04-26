using System;
using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Situações;
using Buffet.Models.Buffet.Tipo;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public ClienteEntity Cliente { get; set; }
        public TipoEventoEntity TipoDeEvento { get; set; }
        public SituacaoEventoEntity Situacao { get; set; }
        public string Local { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataEventoInserido { get; set; }
        public DateTime DataEventoModificado { get; set; }
        
        public EventoEntity()
        {
            Id = new Guid();
        }
        
    }
}