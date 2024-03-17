using HiWeb_Task.Domain.Course;
using HiWeb_Task.Domain.Professor;
using HiWeb_Task.Domain.Student;
using HiWeb_Task.Domain.Term;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Options = HiWeb_Task.Application.Utils.Options;

namespace HiWeb_Task.Infrastructure;

public class AppDbContext : DbContext
{
    private readonly Options _options;
    public AppDbContext(IOptions<Options> options)
    {
        _options = options.Value;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configuration database
        optionsBuilder.UseNpgsql(_options.DbConnection);
        
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Term> Terms { get; set; }
    public DbSet<Professor> Professors { get; set; }
    
}