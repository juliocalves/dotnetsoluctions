using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;

/// <summary>
/// Representa um processo de venda.
/// </summary>
public class ProcessoVenda
{
    /// <summary>
    /// Identificador único do processo de venda.
    /// </summary>
    [Key]
    public Guid PvdaId { get; set; }

    /// <summary>
    /// Status do processo de venda.
    /// </summary>
    public PvdaStatus PvdaStatus { get; set; }
}

/// <summary>
/// Enumeração que representa o status do processo de venda.
/// </summary>
public enum PvdaStatus
{
    Captacao,
    Prospeccao,
    Agendamento,
    Atendimento,
    Contrato
}