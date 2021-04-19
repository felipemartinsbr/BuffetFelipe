using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace BuffetFelipe.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        [Key] public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public int Idade { get; set; }
        
        
        public string Sobrenome { get; set; }
    }
}