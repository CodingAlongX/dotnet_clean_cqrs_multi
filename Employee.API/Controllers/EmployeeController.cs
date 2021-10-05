using Employee.Application.Commands;
using Employee.Application.Queries;
using Employee.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers;

[Route("api/[controller]")]
public class EmployeeController:ControllerBase
{
    private readonly IMediator _mediator;

    public EmployeeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<EmployeeResponse>>> GetAllEmployee()
    {
        var query = new GetAllEmployeeQuery();

        var result = await _mediator.Send(query);
        return Ok(result);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}