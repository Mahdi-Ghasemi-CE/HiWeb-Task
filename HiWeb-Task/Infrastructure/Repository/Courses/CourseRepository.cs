using HiWeb_Task.Application.Interfaces.Repositories.Course;

namespace HiWeb_Task.Infrastructure.Repository.Course;

public class CourseRepository : Repository<Domain.Course.Course>,ICourseRepository
{
    private readonly IQueryable _queryable;

    public CourseRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Domain.Course.Course>();
    }
}