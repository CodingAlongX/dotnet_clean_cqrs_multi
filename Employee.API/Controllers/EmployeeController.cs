using Employee.Application.Commands;
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

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] CreateEmployeeCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }

}