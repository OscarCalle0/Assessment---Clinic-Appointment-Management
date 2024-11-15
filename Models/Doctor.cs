using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;

[Table("doctors")]
public class Doctor
{
    [Key]
    public int Id { get; set; }

    [Required]
    public bool Availability { get; set; }  // true for available, false otherwise

    [Required]
    public string Status { get; set; } // e.g., Active, Inactive

    [Required]
    [ForeignKey("Specialty")]
    public int SpecialtyId { get; set; }
    public Specialty Specialty { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
    public ICollection<AvailabilitySchedule> AvailabilitySchedules { get; set; }
}
