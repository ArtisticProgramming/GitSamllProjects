using CodeNet.Domain.Repositories;
using CodeNet.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeNet.API.Extensions
{
    public static class RepositoryDependenciesRegistration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICodeNoteRepository, CodeNoteRepository>();

            return services;
        }
    }
}
