using StudentManagement.Repositories.Interfaces;

namespace StudentManagement.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        Task<int> SaveAsync();
    }
}
