using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace jtech_models.Financeiro
{
    [Table("DespesasCartaoCredito")]
    public class DespesaCartaoCredito
    {
        #region CONSTRUTORES
    
        public DespesaCartaoCredito()
        {

        }
        #endregion
        #region PROPRIEDADES
        [Key]
        public int DespCarCreditoID { get; set; }

        [ForeignKey("Despesa")]
        public int DespCarCredDespID { get; set; }
        public virtual Despesa Despesa { get; set; }

        [ForeignKey("CartaoCredito")]
        public int DespCarCartaoCreditoID { get; set; }
        public virtual CartaoCredito CartaoCredito { get; set; }
        public int DespCarNumeroParcelaAtual { get; set; }
        public int DespCarNumeroParcelas { get; set; }
        public double DespCarValorParcelaAtual { get; set; }
        public DateTime DespCarDataFechamento { get; set; }
        public bool DespPago { get; set; } = false;
        #endregion

    }
}