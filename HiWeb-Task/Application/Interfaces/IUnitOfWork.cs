using HiWeb_Task.Application.Interfaces.Repositories.Course;
using HiWeb_Task.Application.Interfaces.Repositories.Professor;
using HiWeb_Task.Application.Interfaces.Repositories.Student;
using HiWeb_Task.Application.Interfaces.Repositories.Term;

namespace HiWeb_Task.Application.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public IStudentRepository Students { get; set; }
    public IProfessorRepository Professors { get; set; }
    public ITermRepository Terms { get; set; }
    public ICourseRepository Courses { get; set; }
    Task<bool> CommitAsync();
}