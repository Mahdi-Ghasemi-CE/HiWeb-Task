using HiWeb_Task.Application.Interfaces.Repositories.Term;
using Microsoft.EntityFrameworkCore;

namespace HiWeb_Task.Infrastructure.Repository.Term;

public class TermRepository : Repository<Domain.Term.Term>, ITermRepository
{
    private readonly IQueryable _queryable;
    
    public TermRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Domain.Term.Term>();
    }

    public async Task<Domain.Term.Term> Get(int id)
    {
        return await _dbContext.Terms.SingleOrDefaultAsync(x => x.TermId == id);
    }
}