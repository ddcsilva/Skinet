using Skinet.Core.Entities;

namespace Skinet.Core.Interfaces;

public interface IProdutoRepository
{
    Task<IReadOnlyList<Produto>> ObterProdutosAsync();
    Task<Produto> ObterProdutoPorIdAsync(int id);
}