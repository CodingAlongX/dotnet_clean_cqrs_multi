using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace Employee.Infrastructure.Repositories;

public class EmployeeRepository : Repository<Core.Entities.Employee>, IEmployeeRepository
{
    private readonly EmployeeDbContext _context;

    public EmployeeRepository(EmployeeDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Core.Entities.Employee>> GetEmployeeByLastName(string lastName)
    {
        return await _context.Employees.Where(e => e.LastName == lastName).ToListAsync();
    }
}