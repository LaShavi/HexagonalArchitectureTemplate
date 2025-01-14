using Application.Ports;
using Application.Services;
using Infrastructure.Persistence.Repositories;

namespace Api.Middleware
{
    public static class ServiceExtensions
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            // Registro de Repositorios
            services.AddScoped<IClienteRepository, ClienteRepository>();

            // Registro de Servicios (Casos de Uso)
            services.AddScoped<ClienteService>();
        }
    }
}
