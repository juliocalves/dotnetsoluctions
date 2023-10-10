using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace jtech_models.vendas;

/// <summary>
/// Representa um item de venda em um sistema de vendas.
/// </summary>
public class ItemVenda
{
    /// <summary>
    /// Identificador único do item de venda.
    /// </summary>
    [Key]
    public Guid IVendID { get; set; }

    /// <summary>
    /// Produto associado ao item de venda.
    /// </summary>
    public Produto IVendProd { get; set; }

    /// <summary>
    /// Quantidade do produto no item de venda.
    /// </summary>
    public int IVendQtd { get; set; }

    /// <summary>
    /// Valor total do item de venda.
    /// </summary>
    public decimal IVendValorTotal { get; set; }

    /// <summary>
    /// Valor unitário do produto no item de venda.
    /// </summary>
    public decimal IVendValorUnitario { get; set; }

    /// <summary>
    /// Venda associada ao item de venda.
    /// </summary>
    public Venda IVendVenda { get; set; }

    /// <summary>
    /// Valor de desconto aplicado ao item de venda.
    /// </summary>
    public decimal IVendValorDesconto { get; set; }

    /// <summary>
    /// Valor de acréscimo aplicado ao item de venda.
    /// </summary>
    public decimal IVendValorAcrescimo { get; set; }

    /// <summary>
    /// Valor total líquido do item de venda (considerando desconto e acréscimo).
    /// </summary>
    public decimal IVendValorTotalLiquido { get; set; }
}

