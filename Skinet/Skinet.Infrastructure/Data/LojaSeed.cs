using System.Text.Json;
using Skinet.Core.Entities;

namespace Skinet.Infrastructure.Data;

public class LojaSeed
{
    public static async Task SeedAsync(LojaContext context)
    {
        if (!context.MarcasProduto.Any())
        {
            var marcasData = File.ReadAllText("../Skinet.Infrastructure/Data/Dados/marcas.json");
            var marcas = JsonSerializer.Deserialize<List<MarcaProduto>>(marcasData);
            context.MarcasProduto.AddRange(marcas);
        }

        if (!context.TiposProduto.Any())
        {
            var tiposData = File.ReadAllText("../Skinet.Infrastructure/Data/Dados/tipos.json");
            var tipos = JsonSerializer.Deserialize<List<TipoProduto>>(tiposData);
            context.TiposProduto.AddRange(tipos);
        }

        if (!context.Produtos.Any())
        {
            var produtosData = File.ReadAllText("../Skinet.Infrastructure/Data/Dados/produtos.json");
            var produtos = JsonSerializer.Deserialize<List<Produto>>(produtosData);
            context.Produtos.AddRange(produtos);
        }

        if (context.ChangeTracker.HasChanges())
        {
            await context.SaveChangesAsync();
        }
    }
}