namespace HiWeb_Task.Application.Interfaces.Repositories.Professor;

public interface IProfessorRepository : IRepository<Domain.Professor.Professor>
{
    Task<Domain.Professor.Professor> Get(int id);
}