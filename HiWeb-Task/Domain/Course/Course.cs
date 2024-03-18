namespace HiWeb_Task.Domain.Course;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public Professor.Professor Professor { get; set; }
    public Term.Term Term { get; set; }
    public ICollection<Student.Student> Students { get; set; }
}