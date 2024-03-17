using HiWeb_Task.Application.Handlers.Students.Commands;
using HiWeb_Task.Application.Models.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Controllers;


[ApiController]
[Route("[controller]")]
public class StudentController: ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet("AddStudent")]
    public async Task<IActionResult> AddStudent()
    {
        var res = await _mediator.Send(new AddStudentCommand()
        {
            Name = "Mahdi Ghasemi"
        });
        return Ok(res);
    }
}