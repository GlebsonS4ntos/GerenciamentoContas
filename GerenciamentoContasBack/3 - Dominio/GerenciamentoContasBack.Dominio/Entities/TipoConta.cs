using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Entities
{
    public class TipoConta : BaseEntity
    {
        public int TipoId { get; set; }
        [JsonIgnore]
        public virtual Tipo Tipo { get; set; }
        public int ContaId { get; set; }
        [JsonIgnore]
        public virtual Conta Conta { get; set; }
    }
}
