using System.ComponentModel.DataAnnotations;
using jtech_models.comunicacao;
using jtech_models.logradouro;
using jtech_models.pessoas;
using jtech_models.vendas;
namespace jtech_models.empresa.time;
/// <summary>
/// Representa um vendedor.
/// </summary>
public class Vendedor : PessoaFisica
{
    /// <summary>
    /// Identificador único do vendedor.
    /// </summary>
    public Guid VdorId { get; set; }

    // Propriedades específicas de um vendedor
    public string VendedorNumeroRegistro { get; set; }

    /// <summary>
    /// Informações de contato do vendedor.
    /// </summary>
    public Contato VdorContato { get; set; }

    /// <summary>
    /// Lista de endereços associados ao vendedor.
    /// </summary>
    public List<Endereco> VdorEnderecos { get; set; }

    /// <summary>
    /// Identificador do endereço ativo do vendedor.
    /// </summary>
    public int VdorEnderecoAtivoId { get; set; }

    /// <summary>
    /// Lista de vendas associadas ao vendedor.
    /// </summary>
    public List<Venda> VdorVendas { get; set; }

    /// <summary>
    /// Lista de clientes associados ao vendedor.
    /// </summary>
    public List<Cliente> VdorClientes { get; set; }

    /// <summary>
    /// Tipo do vendedor.
    /// </summary>
    public VdorTipo VdorTipo { get; set; }

    /// <summary>
    /// Status do vendedor.
    /// </summary>
    public VdorStatus VdorStatus { get; set; }
}

/// <summary>
/// Enumeração que representa o status do vendedor.
/// </summary>
public enum VdorStatus
{
    Ativo,
    Inativo
}

/// <summary>
/// Enumeração que representa o tipo de vendedor.
/// </summary>
public enum VdorTipo
{
    Interno,
    Externo,
    Representante,
    Outros
}