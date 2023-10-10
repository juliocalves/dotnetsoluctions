using System.ComponentModel.DataAnnotations;
namespace jtech_models.comunicacao;

/// <summary>
/// Representa um contato.
/// </summary>
public class Contato
{
    /// <summary>
    /// Identificador único do contato.
    /// </summary>
    [Key]
    public Guid ContatoId { get; set; }

    /// <summary>
    /// Nome do contato.
    /// </summary>
    public string ContatoNome { get; set; }

    /// <summary>
    /// E-mail do contato.
    /// </summary>
    public string ContatoEmail { get; set; }

    /// <summary>
    /// Telefone do contato.
    /// </summary>
    public string ContatoTelefone { get; set; }
}