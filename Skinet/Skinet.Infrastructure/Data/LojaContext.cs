using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data;

public class LojaContext : DbContext
{
    public LojaContext(DbContextOptions<LojaContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}