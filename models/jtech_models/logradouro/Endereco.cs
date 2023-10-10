using System.ComponentModel.DataAnnotations;
namespace jtech_models.logradouro;

/// <summary>
/// Representa um endereço.
/// </summary>
public class Endereco
{
    /// <summary>
    /// Identificador único do endereço.
    /// </summary>
    [Key]
    public Guid EnderecoId { get; set; }

    /// <summary>
    /// Nome da rua do endereço.
    /// </summary>
    public string EnderecoRua { get; set; }

    /// <summary>
    /// Número do endereço.
    /// </summary>
    public string EnderecoNumero { get; set; }

    /// <summary>
    /// Bairro do endereço.
    /// </summary>
    public string EnderecoBairro { get; set; }

    /// <summary>
    /// Cidade do endereço.
    /// </summary>
    public string EnderecoCidade { get; set; }

    /// <summary>
    /// Estado do endereço.
    /// </summary>
    public string EnderecoEstado { get; set; }

    /// <summary>
    /// CEP do endereço.
    /// </summary>
    public string EnderecoCep { get; set; }

    /// <summary>
    /// Complemento do endereço.
    /// </summary>
    public string EnderecoComplemento { get; set; }

    /// <summary>
    /// Latitude do endereço.
    /// </summary>
    public string EnderecoLatitude { get; set; }

    /// <summary>
    /// Longitude do endereço.
    /// </summary>
    public string EnderecoLongitude { get; set; }
}