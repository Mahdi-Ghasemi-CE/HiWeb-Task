namespace HiWeb_Task.Application.Interfaces.Repositories.Student;

public interface IStudentRepository : IRepository<Domain.Student.Student>
{
    Task<Domain.Student.Student> StudentsWithJointCourseInTerm();
}