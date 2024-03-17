using HiWeb_Task.Application.Utils;
using MediatR;

namespace HiWeb_Task.Application.Models.Professors.Commands;

public class AddProfessorCommand :IRequest<OperationResult>
{
    public string Name { get; set; }
}