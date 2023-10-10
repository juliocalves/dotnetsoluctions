using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace jtech_dml.Financeiro
{
    [Table("CartoesCredito")]

    public class CartaoCredito 
    {
        #region CONSTRUTO
        public CartaoCredito(string cCredDescricaoCartao,  string cCredNumeroCartao,
            double cCredLimiteCartao, double cCredLimiteDisponivel, int cCredDiaVencimento)
        {

            CCredDescricaoCartao = cCredDescricaoCartao;
            CCredNumeroCartao = cCredNumeroCartao;
            CCredLimiteCartao = cCredLimiteCartao;
            CCredLimiteDisponivel = cCredLimiteDisponivel;
            CCredDiaVencimento = cCredDiaVencimento;
        }
        public CartaoCredito() { }
        #endregion
        #region PROPRIEDADES
        [Key]
        public int CCredID { get; set; }
        public string CCredDescricaoCartao { get; set; }
        public string CCredBandeira { get; set; }
        public string CCredNumeroCartao { get; set; }
        public double CCredLimiteCartao { get; set; }
        public double CCredLimiteDisponivel { get; set; }
        public int CCredDiaVencimento { get; set; }
        public string CCredTitular { get; set; }
        public ICollection<DespesaCartaoCredito> CCredDespesas { get; set; }


        #endregion
    }
}
