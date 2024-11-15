using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;

[Table("logs")]
public class Log
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Action { get; set; } // e.g., Created, Updated, Deleted

    [Required]
    public DateTime TimeStamp { get; set; }

    [Required]
    [ForeignKey("Appointment")]
    public int AppointmentId { get; set; }
    public Appointment Appointment { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }
}
