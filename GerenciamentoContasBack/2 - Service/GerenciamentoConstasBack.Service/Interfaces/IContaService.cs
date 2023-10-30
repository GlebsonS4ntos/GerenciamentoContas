using GerenciamentoConstasBack.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Interfaces
{
    public interface IContaService
    {
        Task<List<ContaDto>> GetAll();
        Task<ContaDto> GetContaById(int contaId);
        Task AddConta(ContaDto conta);
        Task Delete(int contaId);
        Task Update(ContaDto conta, int id);
    }
}
