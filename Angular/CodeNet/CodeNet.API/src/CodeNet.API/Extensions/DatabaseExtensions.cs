using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CodeNet.Infrastructure;

namespace CodeNet.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddCodeNetContext(this IServiceCollection services, string connectionString)
        {
            return services
                .AddEntityFrameworkSqlServer()
                .AddDbContext<CodeNetContext>(opt =>
                {
                    opt.UseSqlServer(
                        connectionString,
                        x =>
                        {
                            x.MigrationsAssembly(typeof(Startup)
                                .GetTypeInfo()
                                .Assembly
                                .GetName().Name);
                        });
                });
        }
    }
}