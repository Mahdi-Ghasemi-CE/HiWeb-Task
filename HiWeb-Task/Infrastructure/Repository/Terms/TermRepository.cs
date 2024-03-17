using HiWeb_Task.Application.Interfaces.Repositories.Term;

namespace HiWeb_Task.Infrastructure.Repository.Term;

public class TermRepository : Repository<Domain.Term.Term>, ITermRepository
{
    private readonly IQueryable _queryable;
    
    public TermRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Domain.Term.Term>();
    }
}