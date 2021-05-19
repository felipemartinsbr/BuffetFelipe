using Buffet.Data;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoService
    {
        private readonly DatabaseContext _databaseContext;

        public EventoService(DatabaseContext databaseContext)
        { 
            _databaseContext = databaseContext;
        }
    }
}