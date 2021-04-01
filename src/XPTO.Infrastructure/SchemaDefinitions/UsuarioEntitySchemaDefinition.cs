




using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using XPTO.Domain.Entities;

namespace XPTO.Infrastructure.SchemaDefinitions
{
    public class UsuarioEntitySchemaDefinition : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios", XPTOContext.DEFAULT_SCHEMA);
            builder.HasKey(u => u.UsuarioId);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(120);
            
            builder.Property(u => u.RG)
                .IsRequired()
                .HasMaxLength(20);
            
            builder.Property(u => u.CPF)
                .IsRequired()
                .HasMaxLength(11);
            
            builder.Property(u => u.Email)
                .IsRequired();
        }
    }
}