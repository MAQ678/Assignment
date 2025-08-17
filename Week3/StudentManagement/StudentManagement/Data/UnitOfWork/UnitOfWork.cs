using StudentManagement.Repositories.Interfaces;

namespace StudentManagement.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext _context;

        public IStudentRepository StudentRepository { get; }
        public UnitOfWork(IStudentRepository studentRepository, StudentDbContext context)
        {
            StudentRepository = studentRepository;
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
