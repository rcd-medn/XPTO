




using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using XPTO.Domain.Entities;
using XPTO.Domain.Repositories;
using XPTO.Infrastructure.SchemaDefinitions;

namespace XPTO.Infrastructure
{
    public class XPTOContext : DbContext, IUnitOfWork
    {
        public XPTOContext(DbContextOptions<XPTOContext> options) : base(options)
        {
            
        }

        public const string DEFAULT_SCHEMA = "xpto";
        public DbSet<Usuario> Usuarios { get; set; }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await SaveChangesAsync();
            return true;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioEntitySchemaDefinition());
            modelBuilder.ApplyConfiguration(new AtivoEntitySchemaDefinition());
            modelBuilder.ApplyConfiguration(new CategoriaAtivoEntitySchemaDefinition());
            modelBuilder.ApplyConfiguration(new CompraAtivoEntitySchemaDefinition());
            modelBuilder.ApplyConfiguration(new VendaAtivoEntitySchemaDefinition());
        }
    }
}
