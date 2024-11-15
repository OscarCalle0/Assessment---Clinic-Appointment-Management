using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;

[Table("appointments")]
public class Appointment
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public TimeSpan StartTime { get; set; }

    [Required]
    public TimeSpan EndTime { get; set; }

    public string Reason { get; set; }
    public string Notes { get; set; }

    [Required]
    public string Status { get; set; } // e.g., Scheduled, Completed, Cancelled

    [Required]
    [ForeignKey("Patient")]
    public int PatientId { get; set; }
    public Patient Patient { get; set; }

    [Required]
    [ForeignKey("Doctor")]
    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    [ForeignKey("AvailabilitySchedule")]
    public int? AvailabilityScheduleId { get; set; }
    public AvailabilitySchedule AvailabilitySchedule { get; set; }
}
