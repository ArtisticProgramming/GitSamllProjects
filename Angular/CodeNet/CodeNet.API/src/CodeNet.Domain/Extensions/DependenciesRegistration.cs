using System;
using System.Collections.Generic;
using System.Text;
using CodeNet.Domain.Mappers;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Services;
using CodeNet.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CodeNet.Domain.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddSingleton<ICodeNoteMapper, CodeNoteMapper>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICodeNoteService, CodeNoteService>();

            return services;
        }
    }
}
