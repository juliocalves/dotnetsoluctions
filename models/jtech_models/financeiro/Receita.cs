using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jtech_models.Financeiro
{
    [Table("Receitas")]
    public class Receita
    {
        public Receita(int receID, int receContaID, string receDescricao, double receValor, DateTime receDataEntrada)
        {
            ReceID = receID;
            ReceContaID = receContaID;
            ReceDescricao = receDescricao;
            ReceValor = receValor;
            ReceDataEntrada = receDataEntrada;
        }

        [Key]
        public int ReceID { get; set; }
        [ForeignKey("Conta")]
        [Required]
        public int ReceContaID { get; set; }
        public virtual Conta Conta { get; set; }
        [Required]
        public string ReceDescricao { get; set; }
        public double ReceValor { get; set; }
        public DateTime ReceDataEntrada { get; set; }
    }
}
