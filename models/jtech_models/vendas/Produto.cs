using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;

/// <summary>
/// Representa um produto.
/// </summary>
public class Produto
{
    /// <summary>
    /// Identificador único do produto.
    /// </summary>
    [Key]
    public Guid ProdId { get; set; }

    /// <summary>
    /// Nome do produto.
    /// </summary>
    public string ProdNome { get; set; }

    /// <summary>
    /// Descrição do produto.
    /// </summary>
    public string ProdDescricao { get; set; }

    /// <summary>
    /// Categoria do produto.
    /// </summary>
    public ProdCategoria ProdCategoria { get; set; }

    /// <summary>
    /// Unidade do produto.
    /// </summary>
    public string ProdUnidade { get; set; }

    /// <summary>
    /// Preço de compra do produto.
    /// </summary>
    public decimal ProdPrecoCompra { get; set; }

    /// <summary>
    /// Preço de venda do produto.
    /// </summary>
    public decimal ProdPrecoVenda { get; set; }

    /// <summary>
    /// Identificador do fornecedor do produto.
    /// </summary>
    public int ProdFornId { get; set; }

    /// <summary>
    /// Fornecedor do produto.
    /// </summary>
    public Fornecedor ProdFornecedor { get; set; }

    /// <summary>
    /// Estoque do produto.
    /// </summary>
    public Estoque ProdEstoque { get; set; }

    /// <summary>
    /// Imagem do produto em formato de bytes.
    /// </summary>
    public byte[] ProdImagem { get; set; }

    /// <summary>
    /// Nome da imagem do produto.
    /// </summary>
    public string ProdImagemNome { get; set; }

    /// <summary>
    /// Status do produto.
    /// </summary>
    public ProdStatus ProdStatus { get; set; }
}

/// <summary>
/// Enumeração que representa o status do produto.
/// </summary>
public enum ProdStatus
{
    Ativo,
    Inativo
}

/// <summary>
/// Enumeração que representa a categoria do produto.
/// </summary>
public enum ProdCategoria
{
    Alimentos,
    Bebidas,
    Limpeza,
    Higiene,
    Outros
}