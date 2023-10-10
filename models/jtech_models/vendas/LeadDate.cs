using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;
/// <summary>
/// Representa uma data associada a um lead.
/// </summary>
public class LeadDate
{
    /// <summary>
    /// Identificador único da data.
    /// </summary>
    [Key]
    public Guid DataId { get; set; }

    /// <summary>
    /// Data da ação relacionada.
    /// </summary>
    public DateTime DateAction { get; set; }

    /// <summary>
    /// Tipo da data.
    /// </summary>
    public DateType DateType { get; set; }

    /// <summary>
    /// Identificador do lead associado.
    /// </summary>
    public int LeadId { get; set; }
}

/// <summary>
/// Enumeração que representa o tipo de data.
/// </summary>
public enum DateType
{
    CriadoEm,
    AtualizadoEm,
    ConcluidoEm,
    DeletadoEm
}