using HiWeb_Task.API.Extensions;
using HiWeb_Task.API.Models.Students;
using HiWeb_Task.Application.Handlers.Students.Commands;
using HiWeb_Task.Application.Models.Students;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class StudentController: ControllerBase
{
    private readonly IMediator _mediator;

    public StudentController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("AddStudent")]
    public async Task<IActionResult> AddStudent([FromBody] AddStudentRequest request)
    {
        var response = await _mediator.Send(new AddStudentCommand()
        {
            Name = request.Name
        });
        
        return this.ReturnResponse(response);
    }
    
    [HttpDelete("DeleteStudent")]
    public async Task<IActionResult> DeleteStudent([FromBody] DeleteStudentRequest request)
    {
        var response = await _mediator.Send(new DeleteStudentCommand()
        {
            StudentId = request.StudentId
        });
        
        return this.ReturnResponse(response);
    }
}