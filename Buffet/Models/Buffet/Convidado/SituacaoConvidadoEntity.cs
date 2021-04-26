using System;

namespace Buffet.Models.Buffet.Convidado
{
    public class SituacaoConvidadoEntity
    {
        public Guid Id { get; set; }
        public Boolean Confirmado { get; set; }
        public Boolean Cancelado { get; set; }
        public Boolean EmDuvida { get; set; }
        public Boolean OutrasSituacoes { get; set; }
        public string Descricao { get; set; }
    }
}