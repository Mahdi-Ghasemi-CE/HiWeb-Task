using System.Net;
using HiWeb_Task.Application.Interfaces;
using HiWeb_Task.Application.Models.Courses.Commands;
using HiWeb_Task.Application.Utils;
using HiWeb_Task.Domain.Course;
using HiWeb_Task.Domain.Student;
using MediatR;

namespace HiWeb_Task.Application.Handlers.Courses.Commands;

public class AddStudentToCourseCommandHandler : IRequestHandler<AddStudentToCourseCommand , OperationResult>
{
    private readonly IUnitOfWork _unitOfWork;

    public AddStudentToCourseCommandHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<OperationResult> Handle(AddStudentToCourseCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var course = await _unitOfWork.Courses.Get(request.CourseId);
            var student = await _unitOfWork.Students.Get(request.StudentId);
            if (student is null || student is null)
            {
                return new OperationResult(HttpStatusCode.NotAcceptable, "Course or Student is not found.");
            }

            AddStudentToCourseStudents(course, student);

            _unitOfWork.Courses.Update(course);
    
            return new OperationResult(HttpStatusCode.OK , course);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return new OperationResult(HttpStatusCode.NotAcceptable , null);
        }
    }

    private static void AddStudentToCourseStudents(Course course, Student student)
    {
        var courseStudents = course.Students;
        if (courseStudents is null)
        {
            course.Students = new List<Student>()
            {
                student
            };
        }
        else
        {
            courseStudents.Add(student);
        }
    }
}