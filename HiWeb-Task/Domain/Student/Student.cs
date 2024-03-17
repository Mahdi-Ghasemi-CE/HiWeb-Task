namespace HiWeb_Task.Domain.Student;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public ICollection<Course.Course> Courses { get; set; }
}