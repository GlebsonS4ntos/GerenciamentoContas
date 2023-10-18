using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Entities
{
    public class Conta : BaseEntity
    {
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public int QuantidadeParcelas { get; set; }
        public bool IsMesAtual { get; set; }
        public virtual ICollection<TipoConta> TiposContas { get; set; }
        public virtual ICollection<PagamentoMensal> PagementosMensais { get; set; }

        public Conta() { }

        public Conta(string descricao, double valorTotal, int quantidadeParcelas, bool isMesAtual, ICollection<TipoConta> tiposContas, ICollection<PagamentoMensal> pagementosMensais)
        {
            Descricao = descricao;
            ValorTotal = valorTotal;
            QuantidadeParcelas = quantidadeParcelas;
            IsMesAtual = isMesAtual;
            TiposContas = tiposContas;
            PagementosMensais = pagementosMensais;
        }

        public void UpdateConta(Conta conta)
        {
            Descricao = conta.Descricao;
            ValorTotal = conta.ValorTotal;
            QuantidadeParcelas = conta.QuantidadeParcelas;
            IsMesAtual = conta.IsMesAtual;
            TiposContas = conta.TiposContas;
            PagementosMensais = conta.PagementosMensais;
        }
    }
}
