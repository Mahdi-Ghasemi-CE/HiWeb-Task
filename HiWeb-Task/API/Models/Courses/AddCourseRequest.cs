namespace HiWeb_Task.API.Models.Courses;

public class AddCourseRequest
{
    public string Name { get; set; }
    public int ProfessorId { get; set; }
    public int TermId { get; set; }
}