using Microsoft.EntityFrameworkCore;
using StudentManagement.Data.UnitOfWork;
using StudentManagement.Models.Entities;
using StudentManagement.Services.Models;

namespace StudentManagement.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(StudentEntity student)
        {
            _unitOfWork.StudentRepository.Add(student);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var student = await _unitOfWork.StudentRepository.GetByIdAsync(id);

            if (student != null)
            {
                _unitOfWork.StudentRepository.Delete(student);
                await _unitOfWork.SaveAsync();
            }            
        }

        public Task<List<StudentEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<StudentEntity?> GetByIdAsync(int id)
        {
            return _unitOfWork.StudentRepository.GetByIdAsync(id);
        }

        public async Task<List<StudentEntity>> GetFilteredStudentsAsync(FilterStudentModel filter)
        {
            var query = _unitOfWork.StudentRepository.Query();
            if(filter.Age.HasValue)
            {
                query = query.Where(s => s.Age > filter.Age.Value);
            }
            if (!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(s => (s.FirstName + " " + s.LastName).Contains(filter.Name));
            }
            return await query.ToListAsync();
        }


        public async Task UpdateAsync(StudentEntity student)
        {
            _unitOfWork.StudentRepository.Update(student);
            await _unitOfWork.SaveAsync();
        }
    }
}
