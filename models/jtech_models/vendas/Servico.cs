using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;

/// <summary>
/// Representa um serviço.
/// </summary>
public class Servico
{
    /// <summary>
    /// Identificador único do serviço.
    /// </summary>
    [Key]
    public Guid ServId { get; set; }

    /// <summary>
    /// Nome do serviço.
    /// </summary>
    public string ServNome { get; set; }

    /// <summary>
    /// Descrição do serviço.
    /// </summary>
    public string ServDescricao { get; set; }

    /// <summary>
    /// Categoria do serviço.
    /// </summary>
    public ServCategoria ServCategoria { get; set; }

    /// <summary>
    /// Preço do serviço.
    /// </summary>
    public decimal ServPreco { get; set; }

    /// <summary>
    /// Identificador do fornecedor do serviço.
    /// </summary>
    public int ServFornId { get; set; }

    /// <summary>
    /// Status do serviço.
    /// </summary>
    public ServStatus ServStatus { get; set; }

    /// <summary>
    /// Imagem do serviço em formato de bytes.
    /// </summary>
    public byte[] ServImagem { get; set; }

    /// <summary>
    /// Nome da imagem do serviço.
    /// </summary>
    public string ServImagemNome { get; set; }
}

/// <summary>
/// Enumeração que representa o status do serviço.
/// </summary>
public enum ServStatus
{
    Ativo,
    Inativo
}

/// <summary>
/// Enumeração que representa a categoria do serviço.
/// </summary>
public enum ServCategoria
{
    Tecnologia,
    Saude,
    Educacao,
    Consultoria,
    Entretenimento,
    Financeiros,
    Construcao,
    Comercio,
    Publicidade,
    Sociais
}