using HiWeb_Task.Application.Utils;
using HiWeb_Task.Infrastructure;

namespace HiWeb_Task.Domain.Term;

public class Term
{
    public int TermId { get; set; }
    public string Name { get; set; }
    public ICollection<Course.Course> Courses { get; set; }
}

