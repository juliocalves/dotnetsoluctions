using System.ComponentModel.DataAnnotations;
using jtech_models.empresas;
using jtech_models.pessoas;
namespace jtech_models.vendas;

/// <summary>
/// Representa um cliente.
/// </summary>
public class Cliente
{
    /// <summary>
    /// Identificador único do cliente.
    /// </summary>
    [Key]
    public Guid ClieId { get; set; }

    /// <summary>
    /// Tipo do cliente (Pessoa Física ou Pessoa Jurídica).
    /// </summary>
    public ClieTipo ClieTipo { get; set; }

    /// <summary>
    /// Lista de compras realizadas pelo cliente.
    /// </summary>
    public List<Venda>? ClieCompras { get; set; }

    /// <summary>
    /// Status do cliente (Ativo ou Inativo).
    /// </summary>
    public ClieStatus ClieStatus { get; set; }

    /// <summary>
    /// Data da última compra realizada pelo cliente.
    /// </summary>
     public DateTime ClieDataUltimaCompra { get; set; }

    /// <summary>
    /// Valor da última compra realizada pelo cliente.
    /// </summary>
    public decimal ClieVrUltimaCompra { get; set; }
   
}

/// <summary>
/// Enumeração que representa o status do cliente.
/// </summary>
public enum ClieStatus
{
    Ativo,
    Inativo
}

/// <summary>
/// Enumeração que representa o tipo do cliente.
/// </summary>
public enum ClieTipo
{
    PessoaFisica,
    PessoaJuridica
}
