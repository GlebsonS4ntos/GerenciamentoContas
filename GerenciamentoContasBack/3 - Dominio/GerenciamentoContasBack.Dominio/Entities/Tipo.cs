using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Entities
{
    public class Tipo : BaseEntity
    {
        public string Nome { get; set; } 
        public ICollection<TipoConta> TiposContas { get; set; }
    }
}
