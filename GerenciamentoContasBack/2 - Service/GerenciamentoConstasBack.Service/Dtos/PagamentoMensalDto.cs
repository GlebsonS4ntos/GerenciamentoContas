using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Dtos
{
    public class PagamentoMensalDto : BaseDto
    {
        public int ContaId { get; set; }
        public ContaDto Conta { get; set; }
        public int Parcela { get; set; }
        public DateTime DataParcela { get; set; }
    }
}
