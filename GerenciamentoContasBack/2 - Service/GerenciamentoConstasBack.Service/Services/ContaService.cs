using AutoMapper;
using GerenciamentoConstasBack.Service.Dtos;
using GerenciamentoConstasBack.Service.Helpers;
using GerenciamentoConstasBack.Service.Interfaces;
using GerenciamentoContasBack.Dominio.Entities;
using GerenciamentoContasBack.Dominio.Interfaces.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Services
{
    public class ContaService : IContaService
    {
        private readonly IContaRepository _contaRepository;
        private readonly IPagamentoMensalRepository _pagamentoMensalRepository;
        private readonly IMapper _mapper;

        public ContaService(IContaRepository contaRepository, IMapper mapper, IPagamentoMensalRepository pagamentoMensalRepository)
        {
            _contaRepository = contaRepository;
            _mapper = mapper;
            _pagamentoMensalRepository = pagamentoMensalRepository;
        }

        public async Task AddConta(ContaDto conta)
        {
            Conta c = _mapper.Map<Conta>(conta);
            await _contaRepository.AddConta(c);

            await AdicionarParcelas(c);
        }

        public async Task Delete(int contaId)
        {
            await _contaRepository.Delete(contaId);          
        }

        public async Task<List<ContaDto>> GetAll()
        {
            List<Conta> contas = await _contaRepository.GetAll();
            List<ContaDto> contasDto = _mapper.Map<List<ContaDto>>(contas);
            return contasDto;
        }

        public async Task<ContaDto> GetContaById(int contaId)
        {
            Conta c = await _contaRepository.GetContaById(contaId);
            ContaDto contaDto = _mapper.Map<ContaDto>(c);
            return contaDto;
        }

        public async Task Update(ContaDto conta, int id)
        {
            Conta c = _mapper.Map<Conta>(conta);
            await _contaRepository.Update(c, id);
            await ExcluirParcelas(id);
            await AdicionarParcelas(c);
        }

        private async Task AdicionarParcelas(Conta c)
        {
            /* Crio a data com o mesmo ano e mes da criação da conta porem com o dia 1 pra quando adicionar os meses pra contruir as
             * datas das parcelas n ter chance de ocorrer algum bug com o mês de fevereiro ja que ele tem 28 dias*/
            DateTime dataCriacaoBase = new DateTime(c.DataCriacao.Year, c.DataCriacao.Month, 1);

            double valorParcela = c.ValorTotal / c.QuantidadeParcelas;

            if (c.IsMesAtual)
            {
                dataCriacaoBase.AddMonths(1); // Adiciona 1 mês na contagem base caso a conta comece apenas proximo mês
            }

            for (int i = 1; i <= c.QuantidadeParcelas; i++)
            {
                DateTime dataMensal = dataCriacaoBase.AddMonths(i);
                PagamentoMensal pm = new PagamentoMensal(c.Id, c, i, dataMensal, valorParcela);
                await _pagamentoMensalRepository.AddPagamentoMensal(pm);
            }
        }
        private async Task ExcluirParcelas(int contaId)
        {
            List<PagamentoMensal> pm = await _pagamentoMensalRepository.GetAllPagamentosByContaId(contaId);
            foreach (PagamentoMensal pagamento in pm)
            {
                await _pagamentoMensalRepository.Delete(pagamento.Id);
            }
        }
    }
}
