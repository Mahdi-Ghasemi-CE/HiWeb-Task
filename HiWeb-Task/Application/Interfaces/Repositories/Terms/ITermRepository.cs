namespace HiWeb_Task.Application.Interfaces.Repositories.Term;

public interface ITermRepository :IRepository<Domain.Term.Term>
{
    Task<Domain.Term.Term> Get(int id);
}