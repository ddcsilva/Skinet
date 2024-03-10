using Microsoft.AspNetCore.Mvc;

namespace Skinet.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    [HttpGet]
    public string ObterProdutos()
    {
        return "Esta é uma lista de produtos";
    }

    [HttpGet("{id}")]
    public string ObterProduto(int id)
    {
        return "Este é um produto";
    }
}