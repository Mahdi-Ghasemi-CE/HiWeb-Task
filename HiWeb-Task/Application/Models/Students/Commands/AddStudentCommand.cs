using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Student;
using MediatR;

namespace HiWeb_Task.Application.Models.Students;

public class AddStudentCommand : IRequest<OperationResult>
{
    public string Name { get; set; }
}