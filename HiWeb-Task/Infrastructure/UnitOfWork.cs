using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Interfaces.Repositories.Course;
using HiWeb_Task.Application.Interfaces.Repositories.Professor;
using HiWeb_Task.Application.Interfaces.Repositories.Student;
using HiWeb_Task.Application.Interfaces.Repositories.Term;
using HiWeb_Task.Infrastructure.Repository.Course;
using HiWeb_Task.Infrastructure.Repository.Professors;
using HiWeb_Task.Infrastructure.Repository.Students;
using HiWeb_Task.Infrastructure.Repository.Term;

namespace HiWeb_Task.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IStudentRepository Students { get; set; }
    public IProfessorRepository Professors { get; set; }
    public ITermRepository Terms { get; set; }
    public ICourseRepository Courses { get; set; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;

        Students = new StudentRepository(_context);
        Professors = new ProfessorRepository(_context);
        Terms = new TermRepository(_context);
        Courses = new CourseRepository(_context);
    }
    
    public async Task<bool> CommitAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}