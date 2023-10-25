using AutoMapper;
using GerenciamentoConstasBack.Service.Dtos;
using GerenciamentoContasBack.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service.Helpers
{
    public class GerenciamentoContasProfile : Profile
    {
        public GerenciamentoContasProfile() 
        {
            CreateMap<ContaDto, Conta>();
            CreateMap<Conta, ContaDto>();

            CreateMap<PagamentoMensalDto, PagamentoMensalDto>();
            CreateMap<PagamentoMensal, PagamentoMensalDto>();

            CreateMap<TipoDto, Tipo>();
            CreateMap<Tipo, TipoDto>();

            CreateMap<TipoContaDto, TipoConta>();
            CreateMap<TipoConta, TipoContaDto>();
        }
    }
}
