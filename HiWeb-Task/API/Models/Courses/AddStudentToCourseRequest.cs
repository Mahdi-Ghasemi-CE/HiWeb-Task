namespace HiWeb_Task.API.Models.Courses;

public class AddStudentToCourseRequest
{
    public int CourseId { get; set; }
    public int StudentId { get; set; }
}