using Employee.Core.Repositories;
using Employee.Core.Repositories.Base;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories;
using Employee.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Employee.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<EmployeeDbContext>(o =>
        {
            o.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        services.AddTransient<IEmployeeRepository, EmployeeRepository>();

        return services;
    }
}