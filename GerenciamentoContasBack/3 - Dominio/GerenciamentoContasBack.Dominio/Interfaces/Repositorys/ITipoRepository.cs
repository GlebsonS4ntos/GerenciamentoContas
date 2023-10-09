using GerenciamentoContasBack.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Interfaces.Repositorys
{
    public interface ITipoRepository
    {
        Task<List<Tipo>> GetAll();
        Task<Tipo> GetTipoById(int tipoId);
        Task AddTipo(Tipo tipo);
        Task Delete(int tipoId);
        Task Update(Tipo tipo, int tipoId);
    }
}
