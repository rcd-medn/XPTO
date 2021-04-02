





using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTO.Domain.Entities;

namespace XPTO.Infrastructure.SchemaDefinitions
{
    public class VendaAtivoEntitySchemaDefinition : IEntityTypeConfiguration<VendaAtivo>
    {
        public void Configure(EntityTypeBuilder<VendaAtivo> builder)
        {
            builder.ToTable("VendaAtivos", XPTOContext.DEFAULT_SCHEMA);
            builder.HasKey(va => va.VendaAtivoId);

            builder.Property(va => va.DataVenda)
                .IsRequired();
            builder.Property(va => va.Quantidade)
                .IsRequired();
            builder.Property(va => va.ValorUnitario)
                .IsRequired();
            
            builder.HasOne(va => va.Ativo)
                .WithMany(a => a.VendaAtivos)
                .HasForeignKey(va => va.AtivoId);

        }
    }
}