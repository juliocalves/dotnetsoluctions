using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jtech_dml.Financeiro
{
    [Table("TiposPagamento")]
    public class TipoPagamento
    {
        #region CONSTRUTORES
        public TipoPagamento() { }
        #endregion

        #region PROPRIEDADES
        #endregion
        [Key]
        public int TipPagId { get; set; }
    }
}