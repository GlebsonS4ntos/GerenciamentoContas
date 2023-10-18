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
        public virtual ICollection<TipoConta> TiposContas { get; set; }

        public Tipo() { }

        public Tipo(string nome, ICollection<TipoConta> tiposContas)
        {
            Nome = nome;
            TiposContas = tiposContas;
        }

        public void UpdateTipo(Tipo tipo)
        {
            Nome = tipo.Nome;
            TiposContas = tipo.TiposContas;
        }
    }
}
