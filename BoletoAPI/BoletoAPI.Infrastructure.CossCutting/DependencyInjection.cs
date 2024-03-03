using BoletoAPI.Application;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using BoletoAPI.Infrastructure.Data.Repositories;
using BoletoAPI.Application.Interfaces;
using BoletoAPI.Application.Mappings;
using BoletoAPI.Domain.Core.Interfaces.Repositories;
using BoletoAPI.Domain.Core.Interfaces.Services;
using BoletoAPI.Domain.Services;

namespace BoletoAPI.Infrastructure.CossCutting
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IBoletoRepository, BoletoRepository>();
            services.AddScoped<IBoletoApplicationService, BoletoApplicationService>();
            services.AddScoped<IBoletoService, BoletoService>();
            services.AddAutoMapper(typeof(DomainParaDTO));

            return services;
        }
    }
}