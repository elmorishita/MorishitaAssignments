using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MorishitaAssignments.Models
{
    public class Assignments
    {
        [Key]
        public int AssignmentId { get; set; }

        public int AccessLevel { get; set; } = 0;
        public string AssignmentName { get; set; } = string.Empty;
    }
}
