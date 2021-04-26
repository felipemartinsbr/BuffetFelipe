using System;
using Buffet.Models.Buffet.Evento;

namespace Buffet.Models.Buffet.Convidado
{
    public class ConvidadoEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public EventoEntity Evento { get; set; }
        public SituacaoConvidadoEntity Type { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataConvidadoInserido { get; set; }
        public DateTime DataConvidadoModificado { get; set; }
        
    }
}