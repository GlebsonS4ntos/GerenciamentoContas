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
    }
}
