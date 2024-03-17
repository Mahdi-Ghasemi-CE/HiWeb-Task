using HiWeb_Task.API.Extensions;
using HiWeb_Task.API.Models.Terms;
using HiWeb_Task.Application.Models.Terms.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Controllers;

[ApiController]
[Route("api/[Controller]")]
public class TermController : ControllerBase
{
    private readonly IMediator _mediator;

    public TermController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("AddTerm")]
    public async Task<IActionResult> AddTerm([FromBody] AddTermRequest request)
    {
        var response = await _mediator.Send(new AddTermCommand()
        {
            Name = request.Name
        });
        
        return this.ReturnResponse(response);
    }
}