using HiWeb_Task.Application.Interfaces.Repositories.Course;
using Microsoft.EntityFrameworkCore;

namespace HiWeb_Task.Infrastructure.Repository.Course;

public class CourseRepository : Repository<Domain.Course.Course>,ICourseRepository
{
    private readonly IQueryable _queryable;

    public CourseRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Domain.Course.Course>();
    }

    public async Task<Domain.Course.Course> Get(int id)
    {
        var course = 
            await 
                _dbContext
                .Courses
                .Include(C => C.Professor)
                .Include(C => C.Term)
                .Include(C => C.Students)
                .FirstOrDefaultAsync();
        return course;
    }
}