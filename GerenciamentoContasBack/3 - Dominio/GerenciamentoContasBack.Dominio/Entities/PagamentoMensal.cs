using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Entities
{
    public class PagamentoMensal : BaseEntity
    {
        public int ContaId { get; set; }
        [JsonIgnore]
        public virtual Conta Conta { get; set; }
        public int Parcela { get; set; }
        public DateTime DataParcela { get; set; }

        public PagamentoMensal() { }

        public PagamentoMensal(int contaId, Conta conta, int parcela, DateTime dataParcela)
        {
            ContaId = contaId;
            Conta = conta;
            Parcela = parcela;
            DataParcela = dataParcela;
        }

        public void UpdatePagamentoMensal(PagamentoMensal pagamentoMensal)
        {
            ContaId = pagamentoMensal.ContaId;
            Conta = pagamentoMensal.Conta;
            Parcela = pagamentoMensal.Parcela;
            DataParcela = pagamentoMensal.DataParcela;
        }
    }
}
