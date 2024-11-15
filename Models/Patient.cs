using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appointment_Management.Models;

[Table("patients")]
public class Patient
{
    [Key]
    public int Id { get; set; }

    public string MedicalHistory { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    public string Address { get; set; }

    [Required]
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User User { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}
