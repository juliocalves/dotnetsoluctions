using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;

namespace jtech_dml.Financeiro
{
    [Table("Despesas")]
    public class Despesa
    {
        #region CONSTRUTORES
        public Despesa(string despDescricao, string despCategoria, double despValor,int despTipo,
            bool despPago)
        {
            DespDescricao = despDescricao;
            DespCategoria = despCategoria;
            DespValor = despValor;
            DespDataLancamento = DateTime.Now;
            DespPago = despPago;
            DespTipo = despTipo;
        }
        public Despesa() { }
        #endregion
        
        #region PROPRIEDADES
        [Key]
        public int DespID { get; set; }
        public double DespValor { get; set; }
        public string DespDescricao { get; set; }
        public string DespCategoria { get; set; }
        public int DespTipo { get; set; }
        public virtual ICollection<DespesaCartaoCredito> DespesaDetalhesCartaoCredito { get; set; }
        public DateTime DespDataDespesa { get; set; }
        public DateTime DespDataLancamento { get; set; } = DateTime.Now;
        public Nullable<DateTime> DespDataPagamento { get; set; }
        public Nullable<DateTime> DespDataBaixa { get; set; }
        public bool DespPago { get; set; } = false;
        public string DespObservacoes { get; set; } 
       
        
        #endregion
      
    }
}