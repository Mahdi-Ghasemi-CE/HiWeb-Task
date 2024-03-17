namespace HiWeb_Task.Domain.Course;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public ICollection<Student.Student> Students { get; set; }
    public ICollection<Term.Term> Terms { get; set; }
}