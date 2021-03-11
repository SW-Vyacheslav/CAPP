using CAPP.Application.Common.Interfaces;
using CAPP.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CAPP.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CAPP_DB;Trusted_Connection=True;MultipleActiveResultSets=True"));

            services.AddScoped<IApplicationDbContext>(services => services.GetService<ApplicationDbContext>());

            return services;
        }
    }
}
