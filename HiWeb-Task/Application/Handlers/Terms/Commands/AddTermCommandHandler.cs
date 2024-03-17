using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Terms.Commands;
using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Term;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Terms.Commands;

public class AddTermCommandHandler : IRequestHandler<AddTermCommand , OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddTermCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<OperationResult> Handle(AddTermCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var term = new Term
            {
                Name = request.Name
            };
        
            _unitOfWork.Terms.Add(term);  

            return new OperationResult(HttpStatusCode.OK , term);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }    
    }
}