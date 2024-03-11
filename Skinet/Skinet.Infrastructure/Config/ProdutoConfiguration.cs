using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Config;

public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.Property(p => p.Id).IsRequired();
        builder.Property(p => p.Nome).IsRequired().HasMaxLength(100);
        builder.Property(p => p.Descricao).IsRequired().HasMaxLength(180);
        builder.Property(p => p.Preco).HasColumnType("decimal(18,2)");
        builder.Property(p => p.ImagemUrl).IsRequired();
        builder.HasOne(b => b.MarcaProduto).WithMany()
            .HasForeignKey(p => p.MarcaProdutoId);
        builder.HasOne(t => t.TipoProduto).WithMany()
            .HasForeignKey(p => p.TipoProdutoId);
    }
}