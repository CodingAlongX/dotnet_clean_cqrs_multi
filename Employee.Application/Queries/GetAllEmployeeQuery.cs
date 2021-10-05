using Employee.Application.Responses;
using MediatR;

namespace Employee.Application.Queries;

public class GetAllEmployeeQuery:IRequest<IEnumerable<EmployeeResponse>>
{
    
}