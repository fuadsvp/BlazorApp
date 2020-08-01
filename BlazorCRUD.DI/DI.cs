using BlazorCRUD.DataAccess;
using BlazorCRUD.DataAccess.Repo;
using BlazorCRUD.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCRUD.DI
{
    public static class DI
    {
        public static IServiceCollection AddDependencies(
            this IServiceCollection services,
            string SqlString
            )
        {
            services.AddDbContext<AppDB>(optionsBuilder => optionsBuilder.UseSqlServer(SqlString));
            services.AddScoped<AppDB>();
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<UoW>();
            services.AddScoped<EmployeeLogic>();

            return services;
        }
    }
}
