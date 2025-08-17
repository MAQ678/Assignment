using System.ComponentModel.DataAnnotations;

namespace StudentManagement.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; } // Primary Key, Auto-Increment by convention
    }
}
