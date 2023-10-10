using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;

/// <summary>
/// Representa o controle de estoque de um produto.
/// </summary>
public class Estoque
{
    /// <summary>
    /// Identificador único do controle de estoque.
    /// </summary>
    [Key]
    public Guid EstoId { get; set; }

    /// <summary>
    /// Quantidade mínima no estoque.
    /// </summary>
    public int EstoMinimo { get; set; }

    /// <summary>
    /// Quantidade máxima no estoque.
    /// </summary>
    public int EstoMaximo { get; set; }

    /// <summary>
    /// Quantidade ideal no estoque.
    /// </summary>
    public int EstoIdeal { get; set; }

    /// <summary>
    /// Quantidade atual no estoque.
    /// </summary>
    public int EstoAtual { get; set; }

    /// <summary>
    /// Quantidade reservada no estoque.
    /// </summary>
    public int EstoReservado { get; set; }

    /// <summary>
    /// Quantidade disponível no estoque.
    /// </summary>
    public int EstoDisponivel { get; set; }

    /// <summary>
    /// Quantidade bloqueada no estoque.
    /// </summary>
    public int EstoBloqueado { get; set; }

    /// <summary>
    /// Quantidade vendida do estoque.
    /// </summary>
    public int EstoVendido { get; set; }

    /// <summary>
    /// Quantidade devolvida ao estoque.
    /// </summary>
    public int EstoDevolvido { get; set; }

    /// <summary>
    /// Quantidade cancelada no estoque.
    /// </summary>
    public int EstoCancelado { get; set; }

    /// <summary>
    /// Quantidade ajustada no estoque.
    /// </summary>
    public int EstoAjustado { get; set; }
}