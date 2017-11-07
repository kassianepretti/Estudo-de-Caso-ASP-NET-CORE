using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Domain.Interfaces.Services;
using SisRh.Domain.Services;
using SisRh.Infra.Data.Context;
using SisRh.Infra.Data.Repository.Repositories;

namespace SisRh.Infra.CrossCutting.IoC
{
    public static class DependencyInjectionConfiguration
    {
        public static void Configuration(IServiceCollection services)
        {
            //Dependência do Context
            services.AddDbContext<SisRhContext>(o => o.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SisRh;Trusted_Connection=True;"));

            //Dependências
            services.AddScoped<IEmpregadoService, EmpregadoService>();
            services.AddScoped<IEmpregadoRepository, EmpregadoRepository>();

            services.AddScoped<ISetorService, SetorService>();
            services.AddScoped<ISetorRepository, SetorRepository>();

            services.AddScoped<IBeneficioService, BeneficioService>();
            services.AddScoped<IBeneficioRepository, BeneficioRepository>();
        }
    }
}
