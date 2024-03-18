using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Courses.Commands;

public class AddCourseCommand : IRequest<OperationResult>
{
    public string Name { get; set; }
    public int ProfessorId { get; set; }
    public int TermId { get; set; }
}