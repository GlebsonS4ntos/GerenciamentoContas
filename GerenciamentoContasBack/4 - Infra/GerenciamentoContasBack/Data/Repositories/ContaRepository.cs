using GerenciamentoContasBack.Dominio.Entities;
using GerenciamentoContasBack.Dominio.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoContasBack.Infra.Data.Repositories
{
    public class ContaRepository : IContaRepository
    {
        private readonly ContasContext _context;

        public ContaRepository(ContasContext context)
        {
            _context = context;
        }

        public async Task AddConta(Conta conta)
        {
            await _context.Contas.AddAsync(conta);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int contaId)
        {
            Conta conta = await GetContaById(contaId);
            _context.Contas.Remove(conta);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Conta>> GetAll()
        {
            return await _context.Contas.ToListAsync(); 
        }

        public async Task<Conta> GetContaById(int contaId)
        {
            return await _context.Contas.FindAsync(contaId);
        }

        public async Task Update(Conta conta, int id)
        {
            Conta c = await GetContaById(id);
            c.UpdateConta(conta);
            _context.Contas.Update(conta);
            await _context.SaveChangesAsync();
        }
    }
}
