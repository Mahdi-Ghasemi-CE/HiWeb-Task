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

    public Task<Student> StudentsWithJointCourseInTerm()
    {
        throw new NotImplementedException();
    }

    public async Task<Student> Get(int id)
    {
        return await _queryable.SingleOrDefaultAsync(s => s.StudentId == id);
    }
}