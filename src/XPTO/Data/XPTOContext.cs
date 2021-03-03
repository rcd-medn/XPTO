





using Microsoft.EntityFrameworkCore;
using XPTO.Models;

namespace XPTO.Data
{
    public class XPTOContext : DbContext
    {
        public XPTOContext(DbContextOptions<XPTOContext> options) :base(options)
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
