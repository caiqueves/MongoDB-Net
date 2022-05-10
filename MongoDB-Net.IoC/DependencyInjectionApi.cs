using Microsoft.Extensions.DependencyInjection;
using MongoDB_Net.Application.Interfaces;
using MongoDB_Net.Application.Mappings;
using MongoDB_Net.Application.Services;
using MongoDB_Net.Domain.Interfaces;
using MongoDB_Net.Infra.Data.Context;
using MongoDB_Net.Infra.Data.Repositories;

namespace MongoDB_Net.IoC
{
    public static class DependencyInjectionApi
    {

        public static void AddDependencyInjectionApi(this IServiceCollection services)
        {
            //if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSingleton<ApplicationMongoDB>();

            services.AddScoped<IInfectadoRepository, InfectadoRepository>();
            services.AddScoped<IInfectadoService, InfectadoService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        }
    }
}
