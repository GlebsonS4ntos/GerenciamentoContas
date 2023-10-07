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
        public Conta Conta { get; set; }
        public int ParcelaAtual { get; set; }
    }
}
