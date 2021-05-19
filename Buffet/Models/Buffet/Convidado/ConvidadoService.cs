using Buffet.Data;

namespace Buffet.Models.Buffet.Convidado
{
    public class ConvidadoService
    {
        private readonly DatabaseContext _databaseContext;

        public ConvidadoService(DatabaseContext databaseContext)
        { 
            _databaseContext = databaseContext;
        }
    }
}