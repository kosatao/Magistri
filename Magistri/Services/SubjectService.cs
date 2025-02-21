using Magistri.DTO;
using Magistri.Models;
using Microsoft.EntityFrameworkCore;

namespace Magistri.Services
{
    public class SubjectService
    {
        //    private ApplicationDbContext dbContext;

        //    public SubjectService(ApplicationDbContext dbContext)
        //    {
        //        this.dbContext = dbContext;
        //    }

        //    internal IEnumerable<SubjectDto> GetAllStudents()
        //    {
        //        var allSubjects = dbContext.Subjects;

        //        var subjectDtos = new List<SubjectDto>();
        //        foreach (var subject in allSubjects)
        //        {
        //            subjectDtos.Add(ModelToDto(subject));
        //        }
        //        return subjectDtos;
        //    }

        //    private static SubjectDto ModelToDto(Subject subject)
        //    {
        //        return new SubjectDto

        //        {
        //            Id = subject.Id,
        //            DateOfBirth = subject.DateOfBirth,
        //            FirstName = subject.FirstName,
        //            LastName = subject.LastName,
        //        };
        //    }


        //    public async Task CreateStudentAsync(SubjectDto studentDto)
        //    {
        //        await dbContext.Students.AddAsync(DtoToModel(studentDto));
        //        await dbContext.SaveChangesAsync();
        //    }

        //    private Subject DtoToModel(SubjectDto studentDto)
        //    {
        //        return new Subject
        //        {
        //            Id = studentDto.Id,
        //            DateOfBirth = studentDto.DateOfBirth,
        //            FirstName = studentDto.FirstName,
        //            LastName = studentDto.LastName,
        //        };
        //    }

        //    internal async Task<SubjectDto> GetByIdAsync(int id)
        //    {
        //        var studentToEdit = await dbContext.Students.FirstOrDefaultAsync(student => student.Id == id);
        //        if (studentToEdit == null)
        //        {
        //            return null;
        //        }
        //        return ModelToDto(studentToEdit);
        //    }

        //    internal async Task UpdateAsync(int id, SubjectDto updatedStudent)
        //    {
        //        dbContext.Update(DtoToModel(updatedStudent));
        //        await dbContext.SaveChangesAsync();
        //    }

        //    internal async Task DeleteAsync(int id)
        //    {
        //        var studentToDelete = dbContext.Students.FirstOrDefault(student => student.Id == id);
        //        dbContext.Students.Remove(studentToDelete);
        //        await dbContext.SaveChangesAsync();
        //    }
    }
}
