using GerenciamentoConstasBack.Service.Helpers;
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
        //Adicionar ao escopo da aplicação as interfaces e os servicos alem dos helpers usando o IServiceCollection
        public static void AddService(this IServiceCollection service)
        {
            AddAutoMapper(service);
        }

        private static void AddAutoMapper(IServiceCollection service)
        {
            service.AddScoped(provider => new AutoMapper.MapperConfiguration(x => {
                x.AddProfile(new GerenciamentoContasProfile());
            }).CreateMapper());
        }
    }
}
