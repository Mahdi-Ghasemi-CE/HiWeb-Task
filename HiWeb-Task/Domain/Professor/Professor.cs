namespace HiWeb_Task.Domain.Professor;

public class Professor
{
    public int ProfessorId { get; set; }
    public int Name { get; set; }
    public ICollection<Course.Course> Courses { get; set; }
}