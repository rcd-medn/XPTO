





using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTO.Domain.Entities;

namespace XPTO.Infrastructure.SchemaDefinitions
{
    public class AtivoEntitySchemaDefinition : IEntityTypeConfiguration<Ativo>
    {
        public void Configure(EntityTypeBuilder<Ativo> builder)
        {
            builder.ToTable("Ativos", XPTOContext.DEFAULT_SCHEMA);
            builder.HasKey(a => a.AtivoId);

            builder.Property(a => a.Ticker)
                .IsRequired()
                .HasMaxLength(10);
            
            builder.HasOne(a => a.CategoriaAtivo)
                .WithMany(ca => ca.Ativos)
                .HasForeignKey(a => a.CategoriaAtivoId);
        }
    }
}