using GerenciamentoContasBack.Dominio.Entities;
using GerenciamentoContasBack.Dominio.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Infra.Data.Repositories
{
    public class TipoRepostitory : ITipoRepository
    {
        private readonly ContasContext _contasContext;

        public TipoRepostitory(ContasContext contasContext)
        {
            _contasContext = contasContext;
        }

        public async Task AddTipo(Tipo tipo)
        {
            await _contasContext.Tipos.AddAsync(tipo);
            await _contasContext.SaveChangesAsync();
        }

        public async Task Delete(int tipoId)
        {
            Tipo t = await GetTipoById(tipoId);
            _contasContext.Tipos.Remove(t);
            await _contasContext.SaveChangesAsync();
        }

        public async Task<List<Tipo>> GetAll()
        {
            return await _contasContext.Tipos.ToListAsync();
        }

        public async Task<Tipo> GetTipoById(int tipoId)
        {
            return await _contasContext.Tipos.FindAsync(tipoId);
        }

        public async Task Update(Tipo tipo, int tipoId)
        {
            Tipo t = await GetTipoById(tipoId);
            t.UpdateTipo(tipo);
            _contasContext.Tipos.Update(tipo);
            await _contasContext.SaveChangesAsync();
        }
    }
}
