using GerenciamentoConstasBack.Service.Helpers;
using GerenciamentoConstasBack.Service.Interfaces;
using GerenciamentoConstasBack.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoConstasBack.Service
{
    public static class Bootstrap
    {
        public static void AddService(this IServiceCollection service)
        {
            AddAutoMapper(service);
            AddServices(service);
        }

        private static void AddAutoMapper(IServiceCollection service)
        {
            service.AddScoped(provider => new AutoMapper.MapperConfiguration(x => {
                x.AddProfile(new GerenciamentoContasProfile());
            }).CreateMapper());
        }

        private static void AddServices(IServiceCollection service)
        {
            service.AddScoped<IContaService, ContaService>();
            service.AddScoped<ITipoService, TipoService>();
        }
    }
}
