using GerenciamentoContasBack.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Interfaces.Repositorys
{
    public interface ITipoContaRepository
    {
        Task<List<TipoConta>> GetALL();
        Task<TipoConta> GetTipoContaById(int id);
        Task AddTipoConta(TipoConta tipoConta);
        Task Delete(int id);
        Task Update(TipoConta tipoConta, int tipoContaId);
    }
}
