namespace HiWeb_Task.Application.Interfaces.Repositories.Student;

public interface IStudentRepository : IRepository<Domain.Student.Student>
{
    Task<List<Domain.Student.Student>> StudentsWithCommonCoursesInTerm(int termId);
    Task<Domain.Student.Student> Get(int id);
}