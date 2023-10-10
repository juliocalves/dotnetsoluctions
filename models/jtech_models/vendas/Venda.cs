using System.ComponentModel.DataAnnotations;
using jtech_models.empresa.time;
using jtech_models.logradouro;
namespace jtech_models.vendas;
/// <summary>
    /// Representa uma venda.
    /// </summary>
public class Venda
{
    /// <summary>
    /// Identificador único da venda.
    /// </summary>
    [Key]
    public Guid VendId { get; set; }

    /// <summary>
    /// Data da venda.
    /// </summary>
    public DateTime VendData { get; set; }

    /// <summary>
    /// Identificador do produto vendido.
    /// </summary>
    public int VendProdId { get; set; }

    /// <summary>
    /// Lista de produtos vendidos.
    /// </summary>
    public List<ItemVenda> VendProduto { get; set; }

    /// <summary>
    /// Valor da venda.
    /// </summary>
    public decimal VendValor { get; set; }

    /// <summary>
    /// Identificador do cliente associado à venda.
    /// </summary>
    public int VendClienteId { get; set; }

    /// <summary>
    /// Cliente associado à venda.
    /// </summary>
    public Cliente Cliente { get; set; }

    /// <summary>
    /// Identificador do vendedor associado à venda.
    /// </summary>
    public int VendVendedorId { get; set; }

    /// <summary>
    /// Vendedor associado à venda.
    /// </summary>
    public Vendedor Vendedor { get; set; }

    /// <summary>
    /// Status da venda.
    /// </summary>
    public VendStatus VendStatus { get; set; }

    /// <summary>
    /// Tipo da venda.
    /// </summary>
    public VendTipo VendTipo { get; set; }

    /// <summary>
    /// Origem da venda.
    /// </summary>
    public VendOrigem VendOrigem { get; set; }

    /// <summary>
    /// Forma de pagamento/recebimento da venda.
    /// </summary>
    public FormaPagamentoRecebimento VendFPagRec { get; set; }

    /// <summary>
    /// Frete da venda.
    /// </summary>
    public Frete Frete {get;set;}

    /// <summary>
    /// Data da venda.
    /// </summary>
    public DateTime VendDataVenda { get; set; }

}

/// <summary>
/// Enumeração que representa a origem da venda.
/// </summary>
public enum VendOrigem
{
    Venda,
    OrdemServico,
    Online,
}

/// <summary>
/// Enumeração que representa o status da venda.
/// </summary>
public enum VendStatus
{
    Pendente,
    Pago,
    Cancelado
}

/// <summary>
/// Enumeração que representa o tipo da venda.
/// </summary>
public enum VendTipo
{
    Produto,
    Servico
}