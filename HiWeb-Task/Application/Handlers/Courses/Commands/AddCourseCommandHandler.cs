using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Courses.Commands;
using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Course;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Courses.Commands;

public class AddCourseCommandHandler : IRequestHandler<AddCourseCommand, OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddCourseCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<OperationResult> Handle(AddCourseCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var term = await _unitOfWork.Terms.Get(request.TermId);
            var professor = await _unitOfWork.Professors.Get(request.ProfessorId);
            if (term is null || professor is null)
            {
                return new OperationResult(HttpStatusCode.NotAcceptable, "Term or Professor is not found.");
            }
            var course = new Course
            {
                Name = request.Name,
                Professor = professor,
                Term = term,
            };
            _unitOfWork.Courses.Add(course);
    
            return new OperationResult(HttpStatusCode.OK , course);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }    
    }
}