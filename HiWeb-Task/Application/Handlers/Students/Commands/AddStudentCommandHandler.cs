using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Students;
using HiWeb_Task.Domain.Student;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Students.Commands;

public class AddStudentCommandHandler :  IRequestHandler<AddStudentCommand, Student>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddStudentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        _unitOfWork.Students.Add(new Student
        {
            Name = request.Name
        });
        return new Student();
    }
}