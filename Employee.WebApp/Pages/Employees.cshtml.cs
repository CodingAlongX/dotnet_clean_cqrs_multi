using Employee.Application.Queries;
using Employee.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employee.WebApp.Pages;

public class Employees : PageModel
{
    private readonly IMediator _mediator;

    public IEnumerable<EmployeeResponse> EmployeeResponses { get; set; }

    public Employees(IMediator mediator)
    {
        _mediator = mediator;
    }
    public async Task OnGetAsync()
    {
        var query = new GetAllEmployeeQuery();

        var employeeList = await _mediator.Send(query);

        EmployeeResponses=employeeList;
    }
}