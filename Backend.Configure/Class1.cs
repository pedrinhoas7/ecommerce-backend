using Backend.Application.Interfaces;
using Backend.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Config
{
    public static class InjectionDependencies
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            return services;
        }
    }
}
