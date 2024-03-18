using HiWeb_Task.API.Extensions;
using HiWeb_Task.API.Models.Courses;
using HiWeb_Task.Application.Models.Courses.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HiWeb_Task.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CourseController : ControllerBase
{
    private readonly IMediator _mediator;

    public CourseController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost("AddCourse")]
    public async Task<IActionResult> AddCourse([FromBody] AddCourseRequest request)
    {
        var response = await _mediator.Send(new AddCourseCommand()
        {
            Name = request.Name,
            TermId = request.TermId,
            ProfessorId = request.ProfessorId
        });
        
        return this.ReturnResponse(response);
    }
    
    [HttpPost("AddStudentToCourse")]
    public async Task<IActionResult> AddStudentToCourse([FromBody] AddStudentToCourseRequest request)
    {
        var response = await _mediator.Send(new AddStudentToCourseCommand()
        {
            CourseId = request.CourseId,
            StudentId = request.StudentId
        });
        
        return this.ReturnResponse(response);
    }
}