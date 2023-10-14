using System.ComponentModel.DataAnnotations;
using jtech_models.logradouro;

namespace jtech_models.pessoas;
/// <summary>
/// Representa uma pessoa.
/// </summary>
public class PessoaFisica
{
    /// <summary>
    /// Identificador único da pessoa.
    /// </summary>
    [Key]
    public int PessoaID { get; set; }

    /// <summary>
    /// Nome da pessoa.
    /// </summary>
    public string PessoaNome { get; set; }

    /// <summary>
    /// Sobrenome da pessoa.
    /// </summary>
    public string PessoaSobrenome { get; set; }

    /// <summary>
    /// Indica se a pessoa possui um nome social.
    /// </summary>
    public bool PessoaHasNomeSocial { get; set; }

    /// <summary>
    /// Nome social da pessoa.
    /// </summary>
    public string PessoaNomeSocial { get; set; }

    /// <summary>
    /// Data de nascimento da pessoa.
    /// </summary>
    public DateTime PessoaDataNascimento { get; set; }

    /// <summary>
    /// Documentos associados à pessoa.
    /// </summary>
    private PessoaDoc PessoaDocs { get; set; }

    /// <summary>
    /// Endereço da pessoa.
    /// </summary>
    public Endereco PessoaEndereco { get; set; }
}
