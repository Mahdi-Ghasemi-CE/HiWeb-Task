using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Students;
using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Student;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Students.Commands;

public class AddStudentCommandHandler :  IRequestHandler<AddStudentCommand, OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddStudentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<OperationResult> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var student = new Student
            {
                Name = request.Name
            };
        
            _unitOfWork.Students.Add(student);  

            return new OperationResult(HttpStatusCode.OK , student);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }
    }
}