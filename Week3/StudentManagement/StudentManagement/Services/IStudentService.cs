using StudentManagement.Models.Entities;
using StudentManagement.Services.Models;

namespace StudentManagement.Services
{
    public interface IStudentService
    {
        Task AddAsync(StudentEntity student);
        Task UpdateAsync(StudentEntity student);
        Task DeleteAsync(int id);
        Task<StudentEntity?> GetByIdAsync(int id);
        Task<List<StudentEntity>> GetAllAsync();
        Task<List<StudentEntity>> GetFilteredStudentsAsync(FilterStudentModel filter);
    }
}
