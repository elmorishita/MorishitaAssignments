using System.ComponentModel.DataAnnotations;

namespace MorishitaAssignments.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string Grade { get; set; } = string.Empty;
        [Required]
        public int StudentAccessLevel { get; set; } = 0;
    }
}
