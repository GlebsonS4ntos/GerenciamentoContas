using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Dtos
{
    public class BaseDto
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
    }
}
