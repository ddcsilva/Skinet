using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Skinet.Core.Entities;
using Skinet.Core.Interfaces;
using Skinet.Infrastructure.Data;

namespace Skinet.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    public readonly IProdutoRepository _produtoRepository;

    public ProdutosController(IProdutoRepository produtoRepository)
    {
        _produtoRepository = produtoRepository;
    }

    [HttpGet]
    public async Task<ActionResult<List<Produto>>> ObterProdutos()
    {
        var produtos = await _produtoRepository.ObterProdutosAsync();
        return Ok(produtos);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Produto>> ObterProduto(int id)
    {
        var produto = await _produtoRepository.ObterProdutoPorIdAsync(id);
        return Ok(produto);
    }

    [HttpGet("marcas")]
    public async Task<ActionResult<IReadOnlyList<MarcaProduto>>> ObterMarcasProduto()
    {
        var marcas = await _produtoRepository.ObterMarcasProdutoAsync();
        return Ok(marcas);
    }

    [HttpGet("tipos")]
    public async Task<ActionResult<IReadOnlyList<TipoProduto>>> ObterTiposProduto()
    {
        var tipos = await _produtoRepository.ObterTiposProdutoAsync();
        return Ok(tipos);
    }
}