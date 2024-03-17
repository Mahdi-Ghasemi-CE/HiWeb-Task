using HiWeb_Task.Domain.Student;
using MediatR;

namespace HiWeb_Task.Application.Models.Students;

public class AddStudentCommand : IRequest<Student>
{
    public string Name { get; set; }
}