using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Data;

public class EmployeeDbContext : DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
    {
    }

    public DbSet<Core.Entities.Employee> Employees { get; set; }
}