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
    public class PagamentoMensalRepository : IPagamentoMensalRepository
    {
        private readonly ContasContext _context;

        public PagamentoMensalRepository(ContasContext context)
        {
            _context = context;
        }

        public async Task AddPagamentoMensal(PagamentoMensal pagamentoMensal)
        {
            await _context.PagamentosMensais.AddAsync(pagamentoMensal);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            PagamentoMensal pm = await GetPagamentoMensalById(id);
            _context.PagamentosMensais.Remove(pm);
            await _context.SaveChangesAsync();
        }

        public async Task<List<PagamentoMensal>> GetAll()
        {
            return await _context.PagamentosMensais.ToListAsync();
        }

        public async Task<PagamentoMensal> GetPagamentoMensalById(int id)
        {
            return await _context.PagamentosMensais.FindAsync(id);
        }

        public async Task Update(PagamentoMensal pagamentoMensal, int pagamentoMensalId)
        {
            PagamentoMensal pm = await GetPagamentoMensalById(pagamentoMensalId);
            pm.UpdatePagamentoMensal(pagamentoMensal);

            _context.PagamentosMensais.Update(pm);
            await _context.SaveChangesAsync();
        }
    }
}
