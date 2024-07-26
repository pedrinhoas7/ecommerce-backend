using Backend.Application.Interfaces;
using Backend.Application.Services;
using Backend.Core.Interfaces;
using Backend.Core.Repositories;
using Backend.Domain.Connection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Backend.Config
{
    public static class InjectionDependencies
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Services
            services.AddScoped<IClientService, ClientService>();
            //Repositories
            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }
    }
}
