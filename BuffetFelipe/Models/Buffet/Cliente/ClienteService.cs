using System;
using System.Collections.Generic;
using System.Linq;
using BuffetFelipe.Data;

namespace BuffetFelipe.Models.Buffet.Cliente
{
    public class ClienteService
    {
        private readonly DataBaseContext _dataBaseContext;

        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public List<ClienteEntity> obterClientes()
        {
            return _dataBaseContext.Clientes.ToList();
        }
    }
}