using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Students;

public class DeleteStudentCommand : IRequest<OperationResult>
{
    public int StudentId { get; set; }
}