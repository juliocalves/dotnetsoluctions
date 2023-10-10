using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;

/// <summary>
/// Representa um catálogo que pode conter produtos ou serviços.
/// </summary>
public class Catalogo
{
    /// <summary>
    /// Identificador único do catálogo.
    /// </summary>
    [Key]
    public Guid CatId { get; set; }

    /// <summary>
    /// Nome do catálogo.
    /// </summary>
    public string CatNome { get; set; }

    /// <summary>
    /// Descrição do catálogo.
    /// </summary>
    public string CatDescricao { get; set; }

    /// <summary>
    /// Tipo do catálogo (Produto ou Serviço).
    /// </summary>
    public CatTipo CatTipo { get; set; }

    /// <summary>
    /// Lista de produtos associados ao catálogo.
    /// </summary>
    public List<Produto>? CatProdutos { get; set; }

    /// <summary>
    /// Lista de serviços associados ao catálogo.
    /// </summary>
    public List<Servico>? CatServicos { get; set; }

    /// <summary>
    /// Status do catálogo (Ativo ou Inativo).
    /// </summary>
    public CatStatus CatStatus { get; set; }

    /// <summary>
    /// Documento relacionado ao catálogo (ex: PDF, imagem, etc.).
    /// </summary>
    public byte[]? CatDoc { get; set; }

    /// <summary>
    /// construtor padrão.
    /// </summary>
    /// <param name="nome">Nome do catálogo.</param>
    /// <param name="descricao">Descrição do catálogo.</param>
    /// <param name="tipo">Tipo do catálogo.</param>
    /// <param name="status">Status do catálogo.</param>
    /// <returns>Retorna uma instância de catálogo.</returns>
    public Catalogo(string nome, string descricao, CatTipo tipo, CatStatus status)
    {
        CatNome = nome;
        CatDescricao = descricao;
        CatTipo = tipo;
        CatStatus = status;
    }
    public Catalogo(){}

    /// <summary>
    /// Adiciona um produto ao catálogo.
    /// </summary>
    /// <param name="produto">Produto associado</param>
    public void AdicionarProduto(Produto produto)
    {
        CatProdutos.Add(produto);
    }

    /// <summary>
    /// Adiciona um serviço ao catálogo.
    /// </summary>
    /// <param name="servico">Servico asssociado</param>
    public void AdicionarServico(Servico servico)
    {
        CatServicos.Add(servico);
    }

}

/// <summary>
/// Enumeração que representa o tipo do catálogo.
/// </summary>
public enum CatTipo
{
    Produto,
    Servico
}

/// <summary>
/// Enumeração que representa o status do catálogo.
/// </summary>
public enum CatStatus
{
    Ativo,
    Inativo
}