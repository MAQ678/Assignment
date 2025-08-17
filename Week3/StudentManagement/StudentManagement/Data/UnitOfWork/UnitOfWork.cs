using StudentManagement.Repositories.Interfaces;

namespace StudentManagement.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly StudentDbContext _context;

        public IStudentRepository ProductRepository { get; }
        public UnitOfWork(IStudentRepository productRepository, StudentDbContext context)
        {
            ProductRepository = productRepository;
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
