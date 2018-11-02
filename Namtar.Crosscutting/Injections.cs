using Microsoft.Extensions.DependencyInjection;
using Namtar.Application.Interfaces;

namespace Namtar.Crosscutting
{
    public static class Injections
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IUsuarioApplicationService>();
        }
    }
}
