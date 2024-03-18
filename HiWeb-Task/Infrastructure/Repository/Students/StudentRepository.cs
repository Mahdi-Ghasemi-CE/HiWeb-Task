using HiWeb_Task.Application.Interfaces.Repositories.Student;
using HiWeb_Task.Domain.Student;
using Microsoft.EntityFrameworkCore;

namespace HiWeb_Task.Infrastructure.Repository.Students;

public class StudentRepository :Repository<Student>,IStudentRepository 
{
    private readonly IQueryable<Student> _queryable;

    public StudentRepository(AppDbContext dbContext) : base(dbContext)
    {
        _queryable = dbContext.Set<Student>();
    }

    public async Task<List<Student>> StudentsWithCommonCoursesInTerm(int termId)
    {
        var commonCourses = 
            await 
                _dbContext
                .Courses
                .Where(c => c.Term.TermId == termId)
                .Select(c => c.CourseId)
                .ToListAsync();

        return await 
                _dbContext
                .Students
                .Where(s => s.Courses.Any(c => commonCourses.Contains(c.CourseId)))
                .ToListAsync();
    }

    public async Task<Student> Get(int id)
    {
        return await _queryable.SingleOrDefaultAsync(s => s.StudentId == id);
    }
}