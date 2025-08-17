using Microsoft.EntityFrameworkCore;
using StudentManagement.Models.Entities;

namespace StudentManagement.Data
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }
        public DbSet<StudentEntity> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentEntity>()
                .HasData(
                    new StudentEntity
                    {
                        Id = 1,
                        FirstName = "John",
                        LastName = "Doe",
                        Email = "johndoe@gmail.com",
                        Age = 20
                    },
                    new StudentEntity
                    {
                        Id = 2,
                        FirstName = "Jane",
                        LastName = "Smith",
                        Email = "janesmith@yahoo.com",
                        Age = 22,

                    },
                    new StudentEntity
                    {
                        Id = 3,
                        FirstName = "Alice",
                        LastName = "Johnson",
                        Email = "alicejohnson@live.com",
                        Age = 19,
                    },
                    new StudentEntity
                    {
                        Id = 4,
                        FirstName = "Bob",
                        LastName = "Brown",
                        Email = "bobbrown@gmail.com",
                        Age = 17,
                    });
        }
    }
}
