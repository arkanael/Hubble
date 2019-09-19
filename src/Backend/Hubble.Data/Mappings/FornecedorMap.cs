using Hubble.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Hubble.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");
            builder.HasKey(f => f.IdFornecedor);

            builder.Property(f => f.IdFornecedor)
                .HasColumnName("IdFornecedor")
                .IsRequired();

            builder.Property(f => f.RazaoSocial)
              .HasColumnName("RazaoSocial")
              .HasColumnType("varchar(70)")
              .IsRequired();
        }
    }
}
