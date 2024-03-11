namespace Skinet.Core.Entities;

public class Produto : Entity
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Preco { get; set; }
    public string ImagemUrl { get; set; }
    public TipoProduto TipoProduto { get; set; }
    public int TipoProdutoId { get; set; }
    public MarcaProduto MarcaProduto { get; set; }
    public int MarcaProdutoId { get; set; }
}