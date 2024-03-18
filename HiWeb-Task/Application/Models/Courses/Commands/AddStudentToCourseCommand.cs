using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Courses.Commands;

public class AddStudentToCourseCommand : IRequest<OperationResult>
{
    public int CourseId { get; set; }
    public int StudentId { get; set; }
}