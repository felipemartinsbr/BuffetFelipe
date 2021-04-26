using System;

namespace Buffet.Models.Buffet.Situações
{
    public class SituacaoEventoEntity
    {
        public Guid Id { get; set; }
        public Boolean Agendado { get; set; }
        public Boolean Cancelado { get; set; }
        public Boolean Executado { get; set; }
        public Boolean OutrasSituacoes { get; set; }
        public string Descricao { get; set; }
    }
}