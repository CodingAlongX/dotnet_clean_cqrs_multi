using Employee.Application.Mappers;
using Employee.Application.Queries;
using Employee.Application.Responses;
using Employee.Core.Repositories;
using MediatR;

namespace Employee.Application.Handlers;

public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeResponse>>
{
    private readonly IEmployeeRepository _repository;

    public GetAllEmployeeHandler(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<EmployeeResponse>> Handle(GetAllEmployeeQuery request,
        CancellationToken cancellationToken)
    {
        var employeeList = await _repository.GetAllAsync();
        var employeeResponseList = EmployeeMapper.Mapper.Map<IEnumerable<EmployeeResponse>>(employeeList);

        return employeeResponseList;
    }
}