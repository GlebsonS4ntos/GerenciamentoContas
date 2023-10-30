using GerenciamentoConstasBack.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Interfaces
{
    public interface ITipoService
    {
        Task<List<TipoDto>> GetAll();
        Task<TipoDto> GetTipoById(int tipoId);
        Task AddTipo(TipoDto tipo);
        Task Delete(int tipoId);
        Task Update(TipoDto tipo, int tipoId);
    }
}
