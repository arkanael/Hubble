using Hubble.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Hubble.Data.Mappings
{
    public class TransportadoraMap : IEntityTypeConfiguration<Transportadora>
    {
        public void Configure(EntityTypeBuilder<Transportadora> builder)
        {
            builder.ToTable("Transportadora");
            builder.HasKey(t => t.IdTransportadora);

            builder.Property(f => f.IdTransportadora)
                   .HasColumnName("IdTransportadora")
                   .IsRequired();

            builder.Property(f => f.RazaoSocial)
                   .HasColumnName("RazaoSocial")
                   .HasColumnType("varchar(70)")
                   .IsRequired();
        }
    }
}
