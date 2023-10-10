using System.ComponentModel.DataAnnotations;
using jtech_models.empresa.time;
namespace jtech_models.vendas;

/// <summary>
/// Representa uma comissão.
/// </summary>
public class Comissao
{
    /// <summary>
    /// Identificador único da comissão.
    /// </summary>
    [Key]
    public Guid ComiId { get; set; }

    /// <summary>
    /// Identificador da venda associada à comissão.
    /// </summary>
    public int ComiVendaId { get; set; }

    /// <summary>
    /// Venda associada à comissão.
    /// </summary>
    public Venda ComiVenda { get; set; }

    /// <summary>
    /// Identificador do vendedor associado à comissão.
    /// </summary>
    public int ComiVendedorId { get; set; }

    /// <summary>
    /// Vendedor associado à comissão.
    /// </summary>
    public Vendedor ComiVendedor { get; set; }

    /// <summary>
    /// Valor da comissão.
    /// </summary>
    public decimal ComiValor { get; set; }

    /// <summary>
    /// Data da comissão.
    /// </summary>
    public DateTime ComiData { get; set; }

    /// <summary>
    /// Status da comissão (Pendente, Pago, Cancelado).
    /// </summary>
    public ComiStatus ComiStatus { get; set; }
}

/// <summary>
/// Enumeração que representa o status da comissão.
/// </summary>
public enum ComiStatus
{
    Pendente,
    Pago,
    Cancelado
}