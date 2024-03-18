using System.Text.Json.Serialization;

namespace HiWeb_Task.Domain.Student;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
 
    [JsonIgnore]
    public ICollection<Course.Course> Courses { get; set; }
}