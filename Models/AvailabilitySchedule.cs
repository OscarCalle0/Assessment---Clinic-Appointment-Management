using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;

[Table("availability_schedules")]
public class AvailabilitySchedule
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int DayOfWeek { get; set; } // 0 = Sunday, 6 = Saturday

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    [Required]
    public bool Status { get; set; } // true = Available, false = Unavailable

    [Required]
    [ForeignKey("Doctor")]
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }
}
