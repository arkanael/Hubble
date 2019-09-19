using Hubble.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hubble.Data.Mappings
{
    public class LancamentoMateriaPrimaMap : IEntityTypeConfiguration<LancamentoMateriaPrima>
    {
        public void Configure(EntityTypeBuilder<LancamentoMateriaPrima> builder)
        {
            builder.ToTable("LancamentoMateriaPrima");
            builder.HasKey(l => l.IdLancamentoMateriaPrima);

            builder.Property(l => l.IdTransportadora)
                .HasColumnName("IdTransportadora")
                .IsRequired();

            builder.Property(l => l.Data)
                .HasColumnName("Data")
                .IsRequired();

            builder.Property(l => l.CodigoMateriaPrima)
              .HasColumnName("CodigoMateriaPrima")
              .HasColumnType("varchar(20)")
              .IsRequired();

            builder.Property(l => l.RIR)
               .HasColumnName("RIR")
               .HasColumnType("varchar(20)")
               .IsRequired();

            builder.Property(l => l.OrdemCompra)
             .HasColumnName("OrdemCompra")
             .HasColumnType("varchar(20)")
             .IsRequired();

            builder.Property(l => l.NotaFiscal)
                .HasColumnName("NotaFiscal")
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.Property(l => l.Quantidade)
               .HasColumnName("Quantidade")
               .IsRequired();


            builder.Property(l => l.Quantidade)
               .HasColumnName("Quantidade")
               .IsRequired();

            builder.Property(l => l.Lote)
               .HasColumnName("Lote")
               .HasColumnType("varchar(20)")
               .IsRequired();


            builder.Property(l => l.Validade)
                .HasColumnName("Validade")
                .IsRequired();

            builder.HasOne(l => l.Transportadora)
                .WithMany(t => t.LancamentoMateriaPrima)
                .HasForeignKey(l => l.IdTransportadora);

            builder.HasOne(l => l.Fornecedor)
                .WithMany(f => f.LancamentoMateriaPrima)
                .HasForeignKey(l => l.IdTFornecedor);
        }
    }
}
