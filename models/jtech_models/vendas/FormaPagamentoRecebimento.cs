using System.ComponentModel.DataAnnotations;
namespace jtech_models.vendas;
/// <summary>
/// Representa uma forma de pagamento ou recebimento.
/// </summary>
public class FormaPagamentoRecebimento
{
/// <summary>
/// Identificador único da forma de pagamento/recebimento.
/// </summary>
[Key]
public Guid FPagRecId { get; set; }

/// <summary>
/// Nome da forma de pagamento/recebimento.
/// </summary>
public FPagRecNome FPagRecNome { get; set; }
}

/// <summary>
/// Enumeração que representa o nome da forma de pagamento/recebimento.
/// </summary>
public enum FPagRecNome
{
Dinheiro,
CartaoDebito,
CartaoCredito,
Cheque,
Boleto,
Transferencia,
Deposito
}