using System.ComponentModel.DataAnnotations;
using jtech_models.comunicacao;
namespace jtech_models.vendas;
/// <summary>
/// Representa um lead.
/// </summary>
public class Lead
{
    /// <summary>
    /// Identificador único do lead.
    /// </summary>
    [Key]
    public Guid LeadId { get; set; }

    /// <summary>
    /// Nome do lead.
    /// </summary>
    public string LeadNome { get; set; }

    /// <summary>
    /// Informações de contato do lead.
    /// </summary>
    public Contato LeadContato { get; set; }

    /// <summary>
    /// Processo de venda associado ao lead.
    /// </summary>
    public ProcessoVenda LeadProcesso { get; set; }

    /// <summary>
    /// Indica se o lead foi convertido em venda.
    /// </summary>
    public bool LeadConverteuVenda { get; set; }

    /// <summary>
    /// Venda associada ao lead.
    /// </summary>
    public Venda LeadVenda { get; set; }

    /// <summary>
    /// Indica se o lead foi convertido em cliente.
    /// </summary>
    public bool LeadConverteuCliente { get; set; }

    /// <summary>
    /// Cliente associado ao lead.
    /// </summary>
    public Cliente LeadCliente { get; set; }

    /// <summary>
    /// Histórico de datas associadas ao lead.
    /// </summary>
    public List<LeadDate> LeadHistorico { get; set; }
}