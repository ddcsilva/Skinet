using Microsoft.EntityFrameworkCore;
using Skinet.API.Entities;

namespace Skinet.API.Data;

public class LojaContext : DbContext
{
    public LojaContext(DbContextOptions<LojaContext> options) : base(options)
    {
    }

    public DbSet<Produto> Produtos { get; set; }
}