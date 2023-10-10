using System.ComponentModel.DataAnnotations;
using jtech_models.comunicacao;
using jtech_models.logradouro;
namespace jtech_models.vendas;

/// <summary>
/// Representa um fornecedor.
/// </summary>
public class Fornecedor
{
    /// <summary>
    /// Identificador único do fornecedor.
    /// </summary>
    [Key]
    public Guid FornId { get; set; }

    /// <summary>
    /// Nome do fornecedor.
    /// </summary>
    public string FornNome { get; set; }

    /// <summary>
    /// Tipo do fornecedor (Pessoa Física ou Pessoa Jurídica).
    /// </summary>
    public FornTipo FornTipo { get; set; }

    /// <summary>
    /// CPF ou CNPJ do fornecedor.
    /// </summary>
    public string FornCpfCnpj { get; set; }

    /// <summary>
    /// Categoria do fornecedor (Produtos ou Serviços).
    /// </summary>
    public FornCategoria FornCategoria { get; set; }

    /// <summary>
    /// Informações de contato do fornecedor.
    /// </summary>
    public Contato FornContato { get; set; }

    /// <summary>
    /// Endereço do fornecedor.
    /// </summary>
    public Endereco FornEndereco { get; set; }

    /// <summary>
    /// Identificador do endereço ativo do fornecedor.
    /// </summary>
    public int FornEnderecoAtivoId { get; set; }

    /// <summary>
    /// Lista de produtos fornecidos pelo fornecedor.
    /// </summary>
    public List<Produto> FornProdutos { get; set; }

    /// <summary>
    /// Lista de serviços fornecidos pelo fornecedor.
    /// </summary>
    public List<Servico> FornServicos { get; set; }

    /// <summary>
    /// Forma de pagamento/recebimento do fornecedor.
    /// </summary>
    public FormaPagamentoRecebimento FornFPagRec { get; set; }

    /// <summary>
    /// Status do fornecedor (Ativo ou Inativo).
    /// </summary>
    public FornStatus FornStatus { get; set; }
}

/// <summary>
/// Enumeração que representa o status do fornecedor.
/// </summary>
public enum FornStatus
{
    Ativo,
    Inativo
}

/// <summary>
/// Enumeração que representa o tipo do fornecedor.
/// </summary>
public enum FornTipo
{
    PessoaFisica,
    PessoaJuridica
}

/// <summary>
/// Enumeração que representa a categoria do fornecedor.
/// </summary>
public enum FornCategoria
{
    Produtos,
    Servicos
}