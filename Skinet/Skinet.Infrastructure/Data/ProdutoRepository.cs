using Skinet.Core.Entities;
using Skinet.Core.Interfaces;

namespace Skinet.Infrastructure.Data;

public class ProdutoRepository : IProdutoRepository
{
    public Task<IReadOnlyList<Produto>> ObterProdutosAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Produto> ObterProdutoPorIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}