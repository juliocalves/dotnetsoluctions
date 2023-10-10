using System.ComponentModel.DataAnnotations;
using jtech_models.vendas;

namespace jtech_models.logradouro;

/// <summary>
/// Representa informações sobre frete em um sistema de vendas.
/// </summary>
public class Frete
{
    /// <summary>
    /// Identificador único do frete.
    /// </summary>
    [Key]
    public Guid FreteID { get; set; }

    /// <summary>
    /// Endereço associado ao frete.
    /// </summary>
    public Endereco FreteEndereco { get; set; }

    /// <summary>
    /// Valor do frete.
    /// </summary>
    public decimal FreteValor { get; set; }

    /// <summary>
    /// Venda associada ao frete.
    /// </summary>
    public Venda FreteVenda { get; set; }

    /// <summary>
    /// Data de entrega prevista para o frete.
    /// </summary>
    public DateTime FreteDataEntrega { get; set; }
}

