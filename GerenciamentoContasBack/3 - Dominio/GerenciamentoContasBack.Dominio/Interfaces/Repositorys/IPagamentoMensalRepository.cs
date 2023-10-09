using GerenciamentoContasBack.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Dominio.Interfaces.Repositorys
{
    public interface IPagamentoMensalRepository
    {
        Task<List<PagamentoMensal>> GetAll();
        Task<PagamentoMensal> GetPagamentoMensalById(int pagamentoMensalId);
        Task AddPagamentoMensal(PagamentoMensal pagamentoMensal);
    }
}
