using jtech_models.comunicacao;
using jtech_models.logradouro;
namespace jtech_models.empresas;

/// <summary>
/// Representa uma pessoa jurídica.
/// </summary>
public class PessoaJuridica
{
    /// <summary>
    /// Identificador único da pessoa jurídica.
    /// </summary>
    public Guid PjId { get; set; }  
    
    /// <summary>
    /// Razão social da pessoa jurídica.
    /// </summary>
    public string PjRazaoSocial { get; set; }
    
    /// <summary>
    /// Nome fantasia da pessoa jurídica.
    /// </summary>
    public string PjNomeFantasia { get; set; }
    
    // ... outras propriedades

    /// <summary>
    /// Lista de sócios da pessoa jurídica.
    /// </summary>
    public List<PessoaJuridicaSocio> PjSocios { get; set; }

    /// <summary>
    /// Lista de endereços associados à pessoa jurídica.
    /// </summary>
    public List<Endereco> PjEnderecos { get; set; }

    /// <summary>
    /// Lista de contatos associados à pessoa jurídica.
    /// </summary>
    public List<Contato> PjContatos { get; set; }
}