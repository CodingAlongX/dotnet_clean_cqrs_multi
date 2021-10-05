using Employee.Core.Repositories.Base;

namespace Employee.Core.Repositories;

public interface IEmployeeRepository : IRepository<Entities.Employee>
{
    Task<IEnumerable<Entities.Employee>> GetEmployeeByLastName(string lastName);
}