using AutoMapper;
using GerenciamentoConstasBack.Service.Dtos;
using GerenciamentoConstasBack.Service.Interfaces;
using GerenciamentoContasBack.Dominio.Entities;
using GerenciamentoContasBack.Dominio.Interfaces.Repositorys;

namespace GerenciamentoConstasBack.Service.Services
{
    public class TipoService : ITipoService
    {
        private readonly ITipoRepository _tipoRepository;
        private readonly IMapper _mapper;

        public TipoService(ITipoRepository tipoRepository, IMapper mapper)
        {
            _tipoRepository = tipoRepository;
            _mapper = mapper;
        }

        public async Task AddTipo(TipoDto tipo)
        {
            Tipo t = _mapper.Map<Tipo>(tipo);
            await _tipoRepository.AddTipo(t);
        }

        public async Task Delete(int tipoId)
        {
           await _tipoRepository.Delete(tipoId); 
        }

        public async Task<List<TipoDto>> GetAll()
        {
            List<Tipo> t = await _tipoRepository.GetAll();
            List<TipoDto> tiposDtos = _mapper.Map<List<TipoDto>>(t);
            return tiposDtos;
        }

        public async Task<TipoDto> GetTipoById(int tipoId)
        {
            Tipo t = await _tipoRepository.GetTipoById(tipoId);
            TipoDto tipoDto = _mapper.Map<TipoDto>(t);
            return tipoDto;
        }

        public async Task Update(TipoDto tipo, int tipoId)
        {
            Tipo t = _mapper.Map<Tipo>(tipo);
            await _tipoRepository.Update(t, tipoId);
        }
    }
}
