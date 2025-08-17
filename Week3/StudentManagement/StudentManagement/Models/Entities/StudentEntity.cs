using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Entities
{
    public class StudentEntity : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public int Age { get; set; }
    }
}
