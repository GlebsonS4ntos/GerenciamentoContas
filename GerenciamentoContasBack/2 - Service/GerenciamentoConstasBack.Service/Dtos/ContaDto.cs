using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Dtos
{
    public class ContaDto : BaseDto
    {
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public int QuantidadeParcelas { get; set; }
        public bool IsMesAtual { get; set; }
        public virtual ICollection<TipoContaDto> TiposContas { get; set; }
        public virtual ICollection<PagamentoMensalDto> PagementosMensais { get; set; }        
    }
}
