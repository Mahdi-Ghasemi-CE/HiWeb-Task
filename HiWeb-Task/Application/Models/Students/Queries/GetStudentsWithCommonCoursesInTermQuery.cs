using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Students.Queries;

public class GetStudentsWithCommonCoursesInTermQuery : IRequest<OperationResult>
{
    public int TermId { get; set; }
}