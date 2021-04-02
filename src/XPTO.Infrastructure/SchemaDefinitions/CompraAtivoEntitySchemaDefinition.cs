





using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTO.Domain.Entities;

namespace XPTO.Infrastructure.SchemaDefinitions
{
    public class CompraAtivoEntitySchemaDefinition : IEntityTypeConfiguration<CompraAtivo>
    {
        public void Configure(EntityTypeBuilder<CompraAtivo> builder)
        {
            builder.ToTable("CompraAtivos", XPTOContext.DEFAULT_SCHEMA);
            builder.HasKey(ca => ca.CompraAtivoId);

            builder.Property(ca => ca.DataCompra)
                .IsRequired();
            builder.Property(ca => ca.Quantidade)
                .IsRequired();
            builder.Property(ca => ca.ValorUnitario)
                .IsRequired();

            builder.HasOne(ca => ca.Ativo)
                .WithMany(a => a.CompraAtivos)
                .HasForeignKey(ca => ca.AtivoId);
        }
    }
}