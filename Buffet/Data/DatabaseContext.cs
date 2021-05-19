using System;
using Buffet.Models.Acesso;
using Buffet.Models.Buffet.Cliente;
using Buffet.Models.Buffet.Convidado;
using Buffet.Models.Buffet.Evento;
using Buffet.Models.Buffet.Situações;
using Buffet.Models.Buffet.Tipo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Data
{
    public class DatabaseContext : IdentityDbContext<Usuario, Papel, Guid>
    {
        public DbSet<ClienteEntity> Clientes { get; set; }
        public DbSet<EventoEntity> Eventos { get; set; }
        public DbSet<ConvidadoEntity> Convidados { get; set; }
        //public DbSet<SituacaoEventoEntity> SituacaoEvento { get; set; }
        //public DbSet<TipoEventoEntity> TipoEvento { get; set; }
        //public DbSet<SituacaoConvidadoEntity> SituacaoConvidado { get; set; }
        //public DbSet<TipoClienteEntity> TipoCliente { get; set; }
        //public DbSet<LocalEventoEntity> Local { get; set; }
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            :base(options)
        {
        }
    }
}