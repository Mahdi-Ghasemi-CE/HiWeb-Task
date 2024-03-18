using HiWeb_Task.Application.Interfaces.Repositories.Professor;
using HiWeb_Task.Domain.Professor;
using Microsoft.EntityFrameworkCore;

namespace HiWeb_Task.Infrastructure.Repository.Professors;

public class ProfessorRepository : Repository<Professor> , IProfessorRepository
{
    private readonly IQueryable<Professor> _queryable;

    public ProfessorRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Professor>();
    }

    public async Task<Professor> Get(int id)
    {
        return await _queryable.SingleOrDefaultAsync(x => x.ProfessorId == id);
    }
}