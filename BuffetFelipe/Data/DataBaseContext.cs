using BuffetFelipe.Models.Buffet.Cliente;
using Microsoft.EntityFrameworkCore;

namespace BuffetFelipe.Data
{
    public class DataBaseContext : DbContext
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options)
        {
            
        }
    }
}