using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFCore;

namespace IoC
{
    public static class Container
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            return services;
        }
    }
}
