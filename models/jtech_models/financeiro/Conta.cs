using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace jtech_models.Financeiro
{
    [Table("Contas")]
    public class Conta 
    {
        #region CONTRUTORES
        public Conta() { }
        public Conta(int contBancoID, double saldo, string contTitular)
        {
            ContBancoID = contBancoID;
            ContSaldo = saldo;
            ContTitular = contTitular;
        }

        public Conta(int contID, int contBancoID, Banco banco, double contSaldo, string contTitular, string contNumConta, string contAgencia, int contTipoConta, int contTipoPix, string contChavePix, bool contHasCartaoCredito,  CartaoCredito cartaoCredito, ICollection<Transacao> transacoes)
        {
            ContID = contID;
            ContBancoID = contBancoID;
            Banco = banco;
            ContSaldo = contSaldo;
            ContTitular = contTitular;
            ContNumConta = contNumConta;
            ContAgencia = contAgencia;
            ContTipoConta = contTipoConta;
            ContTipoPix = contTipoPix;
            ContChavePix = contChavePix;
            ContHasCartaoCredito = contHasCartaoCredito;
            CartaoCredito = cartaoCredito;
            Transacoes = transacoes;
        }

        #endregion

        #region PROPRIEDADES
        [Key]
        public int ContID { get; set; }
        [ForeignKey("Banco")]
        [Required]
        public int ContBancoID { get; set; }
        public virtual Banco Banco { get; set; }

        public double ContSaldo { get; set; }
        public string ContTitular { get; set; }
        public string ContNumConta { get; set; }
        public string ContAgencia { get; set; }
        public int ContTipoConta { get; set; }
        public int ContTipoPix { get; set; }
        public string ContChavePix { get; set; }
        public bool ContHasCartaoCredito { get; set; }

        [ForeignKey("CartaoCredito")]
        public int? ContCCredId { get; set; }
        public virtual CartaoCredito CartaoCredito { get; set; }
        public virtual ICollection<Transacao> Transacoes { get; set; }

        #endregion

       

    }
}
