using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace jtech_models.Financeiro
{

    [Table("Transacoes")]
    public class Transacao
    {

        #region MODEL

        [Key]
        public int TransacaoID { get; set; }
        [ForeignKey("Conta")]
        public int ContaID { get; set; }
        public virtual Conta Conta { get; set; }
        public int ItemTransacaoId { get; set; } //representa se a transação feita é um conta a pagar ou conta a receber
        public DateTime DataTransacao { get; set; }
        public int TipoTransacao { get; set; }

        #endregion

        #region METODOS

        public void GerarRelatorio(int tipoRelatorio)
        {
            throw new NotImplementedException();
        }

        public void ProgramarTransacao(Transacao transacao, DateTime dataPlanejada, int numeroRepeticoes)
        {
            throw new NotImplementedException();

        }

        public void GerarAnalise(int tipoAnalise)
        {
            throw new NotImplementedException();
        }

        #endregion

    }


}