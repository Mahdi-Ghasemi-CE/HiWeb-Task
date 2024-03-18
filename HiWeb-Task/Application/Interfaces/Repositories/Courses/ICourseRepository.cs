namespace HiWeb_Task.Application.Interfaces.Repositories.Course;

public interface ICourseRepository : IRepository<Domain.Course.Course>
{
    Task<Domain.Course.Course> Get(int id);
}