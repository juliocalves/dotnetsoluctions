using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using jtech_models.vendas;

namespace jtech_models.Financeiro
{
    [Table("ContasPagar")]
    public class ContasPagar
    {
        #region CONSTRUTORES
        public ContasPagar() { }
        #endregion

        #region PROPRIEDADES
        [Key]
        public int ContPagID { get; set; }
        public double ContPagValorNominal { get; set; }
        public string ContPagDescricao { get; set; }
        public string ContPagCategoria { get; set; }
        //public ICollection<ItensFatura> ContPagItensFatura { get; set; }
        public DateTime ContPagDataEmissao { get; set; }
        public DateTime ContPagDataVencimento { get; set; }
        [ForeignKey("Fornecedor")]
        public int ContPagFornecedor { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public bool ContPagStatusPagamento { get; set; }
        [ForeignKey("TipoPagamento")]
        public int ContPagTipoPagamento { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public int ContPagStatus { get; set; }
        //revisar regra de calculos de juros e amortização
        public float ContPagTaxaJuros { get; set; }
        public double ContPagValorReal { get; set; } //representa valor nominal * taxa de juros
        public DateTime ContPagDataLancamento { get; set; }
        public Nullable<DateTime> ContPagDataPagamento { get; set; }
        #endregion

        #region METODOS
        public void CancelarFatura(int numeroFatura)
        {
            throw new NotImplementedException();
        }
        public void GerarRelatorio()
        {
            throw new NotImplementedException();
        }
        public void GerarAnalise()
        {
            throw new NotImplementedException();
        }
        public void RenegociarFatura()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
