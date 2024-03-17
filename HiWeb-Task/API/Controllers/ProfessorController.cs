using HiWeb_Task.API.Extensions;
using HiWeb_Task.API.Models.Professors;
using HiWeb_Task.Application.Models.Professors.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class ProfessorController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProfessorController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("AddProfessor")]
    public async Task<IActionResult> AddProfessor([FromBody] AddProfessorRequest request)
    {
        var response = await _mediator.Send(new AddProfessorCommand()
        {
            Name = request.Name
        });
        
        return this.ReturnResponse(response);
    }
}