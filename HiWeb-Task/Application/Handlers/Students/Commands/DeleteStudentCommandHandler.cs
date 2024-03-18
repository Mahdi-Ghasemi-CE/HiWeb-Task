using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Students;
using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Students.Commands;

public class DeleteStudentCommandHandler : IRequestHandler<DeleteStudentCommand , OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public DeleteStudentCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<OperationResult> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var student = await _unitOfWork.Students.Get(request.StudentId);
            
            if (student == null)
                return new OperationResult(HttpStatusCode.NotFound,"The student is not found .");
        
            _unitOfWork.Students.Remove(student);  

            return new OperationResult(HttpStatusCode.OK , student);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }
    }
}