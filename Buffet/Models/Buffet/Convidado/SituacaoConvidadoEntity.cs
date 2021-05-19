using System;

namespace Buffet.Models.Buffet.Convidado
{
    public class SituacaoConvidadoEntity
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public SituacaoConvidadoEntity()
        {
            Id = new Guid();
        }
    }
}