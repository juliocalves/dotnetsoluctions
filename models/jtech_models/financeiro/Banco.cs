using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace jtech_models.Financeiro
{
    [Table("Bancos")]
    public class Banco
    {
        public Banco() { }
        #region PROPRIEDADES
        private ICollection<Conta> bancContas;

        [Key]
        public int BancID { get; set; }
        [Required]

        public string BancNome { get; set; }
        public string BancCompe { get; set; }

        public virtual ICollection<Conta> GetBancContas()
        {
            return bancContas;
        }

        public virtual void SetBancContas(ICollection<Conta> value)
        {
            bancContas = value;
        }
        #endregion
    }



}
