using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Professors.Commands;
using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Professor;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Professors.Commands;

public class AddProfessorCommandHandler : IRequestHandler<AddProfessorCommand,OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddProfessorCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<OperationResult> Handle(AddProfessorCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var professor = new Professor()
            {
                Name = request.Name
            };
        
            _unitOfWork.Professors.Add(professor);  

            return new OperationResult(HttpStatusCode.OK , professor);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }    
    }
}