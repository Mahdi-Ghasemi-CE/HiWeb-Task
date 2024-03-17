using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Terms.Commands;

public class AddTermCommand : IRequest<OperationResult>
{
    public string Name { get; set; }
}