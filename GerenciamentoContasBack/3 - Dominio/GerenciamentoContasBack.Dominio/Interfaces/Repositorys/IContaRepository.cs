using GerenciamentoContasBack.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Interfaces.Repositorys
{
    public interface IContaRepository
    {
        Task<List<Conta>> GetAll();
        Task<Conta> GetContaById(int contaId);
        Task AddConta(Conta conta);
        Task Delete(int contaId);
        Task Update(Conta conta, int id);
    }
}
