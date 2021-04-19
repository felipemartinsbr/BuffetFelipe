using System;
using System.Collections.Generic;

namespace BuffetFelipe.Models.Buffet.Cliente
{
    public class ClienteService
    {
        public List<ClienteEntity> obterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();

            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Felipe",
                DataDeNascimento = new DateTime(1989,11,1)
            });
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "José",
                DataDeNascimento = new DateTime(1977,1,10)
            });
            
            return listaDeClientes;
        }
    }
}