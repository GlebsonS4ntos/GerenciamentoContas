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
    public class TipoContaRepository : ITipoContaRepository
    {
        private readonly ContasContext _context;

        public TipoContaRepository(ContasContext context)
        {
            _context = context;
        }

        public async Task AddTipoConta(TipoConta tipoConta)
        {
            await _context.TiposContas.AddAsync(tipoConta);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            TipoConta tp = await GetTipoContaById(id);
            _context.TiposContas.Remove(tp);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TipoConta>> GetALL()
        {
            return await _context.TiposContas.ToListAsync();
        }

        public async Task<TipoConta> GetTipoContaById(int id)
        {
            return await _context.TiposContas.FindAsync(id);
        }

        public async Task Update(TipoConta tipoConta, int tipoContaId)
        {
            TipoConta tp = await GetTipoContaById(tipoContaId);
            tp.UpdateTipoConta(tipoConta);
            _context.TiposContas.Update(tp);
            await _context.SaveChangesAsync();
        }
    }
}
