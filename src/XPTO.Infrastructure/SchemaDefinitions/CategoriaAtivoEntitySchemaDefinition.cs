




using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTO.Domain.Entities;

namespace XPTO.Infrastructure.SchemaDefinitions
{
    public class CategoriaAtivoEntitySchemaDefinition : IEntityTypeConfiguration<CategoriaAtivo>
    {
        public void Configure(EntityTypeBuilder<CategoriaAtivo> builder)
        {
            builder.ToTable("CategoriaAtivos", XPTOContext.DEFAULT_SCHEMA);
            builder.HasKey(c => c.CategoriaAtivoId);

            builder.Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(150);
            
            builder.Property(c => c.DataCriacao)
                .IsRequired();
            
            builder.HasOne(ca => ca.Usuario)
                .WithMany(u => u.CategoriaAtivos)
                .HasForeignKey(ca => ca.UsuarioId);
        }
    }
}
