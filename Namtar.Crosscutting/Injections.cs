﻿using Microsoft.Extensions.DependencyInjection;
using Namtar.Application;
using Namtar.Application.Interfaces;
using Namtar.Domain.Interfaces;
using Namtar.Domain.Services;
using Namtar.Repository;

namespace Namtar.Crosscutting
{
    public static class Injections
    {
        public static void Register(IServiceCollection services)
        {
            services.AddTransient<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
