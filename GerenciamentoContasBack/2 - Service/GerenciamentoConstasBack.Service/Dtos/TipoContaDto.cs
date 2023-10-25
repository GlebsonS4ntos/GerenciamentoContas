using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Dtos
{
    public class TipoContaDto : BaseDto
    {
        public int TipoId { get; set; }
        public TipoDto Tipo { get; set; }
        public int ContaId { get; set; }
        public ContaDto Conta { get; set; }
    }
}
