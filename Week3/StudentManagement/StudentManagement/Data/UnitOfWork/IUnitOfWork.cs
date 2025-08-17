using StudentManagement.Repositories.Interfaces;

namespace StudentManagement.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository ProductRepository { get; }
        Task<int> SaveAsync();
    }
}
