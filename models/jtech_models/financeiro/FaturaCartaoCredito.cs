using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jtech_dml.Financeiro
{
    [Table("FaturasCartaoCredito")]
    public class FaturaCartaoCredito
    {
        #region CONSTRUTORES
        public FaturaCartaoCredito() { }
        #endregion
        #region  PROPRIEDADES
        [Key]
        public int FatCarId { get; set; }
        [ForeignKey("CartaoCredito")]
        public int FatCarCartaoId { get; set; }
        public double FatCarValor { get; set; }
        public DateTime FatCarDataVencimento { get; set; }
        public bool FatCarStatusPagamento { get; set; }
        public DateTime? FatCarDataPagamento { get; set; }
        public virtual List<DespesaCartaoCredito> FatCarItensFatura { get; set; }
        public CartaoCredito CartaoCredito { get; set; }
        public decimal? FatCarIof { get; set; }
        public decimal? FatCarTaxaJuros { get; set; }

       

        #endregion  
    }
}
