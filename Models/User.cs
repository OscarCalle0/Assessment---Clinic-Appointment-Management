using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [ForeignKey("Role")]
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
