using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Students.Queries;
using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Students.Queries;

public class GetStudentsWithCommonCoursesInTermQueryHandler : IRequestHandler<GetStudentsWithCommonCoursesInTermQuery , OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public GetStudentsWithCommonCoursesInTermQueryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<OperationResult> Handle(GetStudentsWithCommonCoursesInTermQuery request, CancellationToken cancellationToken)
    {
        var students = await _unitOfWork.Students.StudentsWithCommonCoursesInTerm(request.TermId);
        return new OperationResult(HttpStatusCode.OK , students);
    }
}