using MasivianAPI.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace MasivianAPI.Service
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddSingleton<IArbol, ArbolImpl>();
        }
    }
}
