using Infra.ErmContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Infra.Initializers
{
    public static class InitializeDbContext
    {
        public static void InitializeDb(this IServiceCollection services)
        {
            services.AddDbContext<DbContextBeer>(options => options.UseSqlServer());
        }
    }
}
