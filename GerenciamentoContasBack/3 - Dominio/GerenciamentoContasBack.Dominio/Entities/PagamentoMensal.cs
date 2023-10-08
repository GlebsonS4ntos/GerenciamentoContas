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
    }
}
