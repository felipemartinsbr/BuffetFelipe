using System;

namespace Buffet.Models.Buffet.Situações
{
    public class SituacaoEventoEntity
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public SituacaoEventoEntity()
        {
            Id = new Guid();
        }
    }
}