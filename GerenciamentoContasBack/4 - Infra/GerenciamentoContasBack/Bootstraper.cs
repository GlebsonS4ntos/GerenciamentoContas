using GerenciamentoContasBack.Dominio.Interfaces.Repositorys;
using GerenciamentoContasBack.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoContasBack.Infra
{
    public static class Bootstraper 
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IContaRepository, ContaRepository>();
            service.AddScoped<IPagamentoMensalRepository, PagamentoMensalRepository>();
            service.AddScoped<ITipoContaRepository, TipoContaRepository>();
            service.AddScoped<ITipoRepository, TipoRepostitory>();
        }
    }
}
