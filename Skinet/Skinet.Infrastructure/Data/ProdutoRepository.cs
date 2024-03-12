using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;
using Skinet.Core.Interfaces;

namespace Skinet.Infrastructure.Data;

public class ProdutoRepository : IProdutoRepository
{
    private readonly LojaContext _context;

    public ProdutoRepository(LojaContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<Produto>> ObterProdutosAsync()
    {
        return await _context.Produtos.ToListAsync();
    }

    public async Task<Produto> ObterProdutoPorIdAsync(int id)
    {
        return await _context.Produtos.FindAsync(id);
    }

    public async Task<IReadOnlyList<MarcaProduto>> ObterMarcasProdutoAsync()
    {
        return await _context.MarcasProduto.ToListAsync();
    }

    public async Task<IReadOnlyList<TipoProduto>> ObterTiposProdutoAsync()
    {
        return await _context.TiposProduto.ToListAsync();
    }
}