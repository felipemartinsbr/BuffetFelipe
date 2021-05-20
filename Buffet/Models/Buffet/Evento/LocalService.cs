using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;

namespace Buffet.Models.Buffet.Evento
{
    public class LocalService
    {
       private readonly DatabaseContext _databaseContext;

       public LocalService(
           DatabaseContext databaseContext)
       {
           _databaseContext = databaseContext;
       }
       
       public ICollection<LocalEventoEntity> ObterTodos()
       {
           return _databaseContext.Local
               .ToList();
       }
       
       public LocalEventoEntity ObterPorId(Guid id)
       {
           try
           {
               return _databaseContext.Local
                   .First(c => c.Id == id);

           }catch
           {
               throw new Exception("Local de ID #" + id + "não encontrado");
           }
       }
    }
}