using StudentManagement.Data;
using StudentManagement.Models.Entities;
using StudentManagement.Repositories.Interfaces;

namespace StudentManagement.Repositories.Implementations
{
    public class StudentRepository : Repository<StudentEntity>, IStudentRepository
    {
        public StudentRepository(StudentDbContext context) : base(context)
        {
        }
    }
}
