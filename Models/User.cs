using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;
[Table("bookings")]
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
    public string Role { get; set; } // e.g., Patient, Doctor, Admin

    [Required]
    public string Password { get; set; }

    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
}