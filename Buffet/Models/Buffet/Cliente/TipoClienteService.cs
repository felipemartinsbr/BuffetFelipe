using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;
using Buffet.Models.Buffet.Tipo;

namespace Buffet.Models.Buffet.Cliente
{
    public class TipoClienteService
    {
        private readonly DatabaseContext _databaseContext;

        public TipoClienteService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public ICollection<TipoClienteEntity> ObterTodos()
        {
            return _databaseContext.TipoCliente.ToList();
        }

        public TipoClienteEntity ObterPorId(int id)
        {
            try
            {
                return _databaseContext.TipoCliente.Find(id);
            }
            catch
            {
                throw new Exception("Tipo de Cliente de ID #" + id + "não encontrada");
            }
        }
    }
}