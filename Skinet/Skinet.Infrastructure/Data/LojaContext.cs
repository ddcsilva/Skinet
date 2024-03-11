using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data;

public class LojaContext : DbContext
{
    public LojaContext(DbContextOptions<LojaContext> options) : base(options) { }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<MarcaProduto> MarcasProduto { get; set; }
    public DbSet<TipoProduto> TiposProduto { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}