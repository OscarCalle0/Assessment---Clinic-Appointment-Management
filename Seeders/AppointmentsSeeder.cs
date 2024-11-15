using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class AppointmentsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    Date = new DateTime(2024, 11, 15),
                    StartTime = new TimeSpan(9, 0, 0),
                    EndTime = new TimeSpan(9, 30, 0),
                    Status = "Scheduled",
                    Notes = "First appointment of the day",
                    Reason = "Routine check-up",
                    PatientId = 11,
                    DoctorId = 1
                },
                new Appointment
                {
                    Id = 2,
                    Date = new DateTime(2024, 11, 16),
                    StartTime = new TimeSpan(10, 0, 0),
                    EndTime = new TimeSpan(10, 30, 0),
                    Status = "Scheduled",
                    Notes = "Follow-up consultation",
                    Reason = "Follow-up for previous diagnosis",
                    PatientId = 12,
                    DoctorId = 2
                },
                new Appointment
                {
                    Id = 3,
                    Date = new DateTime(2024, 11, 17),
                    StartTime = new TimeSpan(11, 0, 0),
                    EndTime = new TimeSpan(11, 30, 0),
                    Status = "Scheduled",
                    Notes = "Routine check-up",
                    Reason = "General check-up",
                    PatientId = 13,
                    DoctorId = 3
                },
                new Appointment
                {
                    Id = 4,
                    Date = new DateTime(2024, 11, 18),
                    StartTime = new TimeSpan(12, 0, 0),
                    EndTime = new TimeSpan(12, 30, 0),
                    Status = "Scheduled",
                    Notes = "Consultation for lab results",
                    Reason = "Lab result discussion",
                    PatientId = 14,
                    DoctorId = 4
                },
                new Appointment
                {
                    Id = 5,
                    Date = new DateTime(2024, 11, 19),
                    StartTime = new TimeSpan(13, 0, 0),
                    EndTime = new TimeSpan(13, 30, 0),
                    Status = "Scheduled",
                    Notes = "Consultation for follow-up",
                    Reason = "Follow-up consultation",
                    PatientId = 15,
                    DoctorId = 5
                },
                new Appointment
                {
                    Id = 6,
                    Date = new DateTime(2024, 11, 20),
                    StartTime = new TimeSpan(14, 0, 0),
                    EndTime = new TimeSpan(14, 30, 0),
                    Status = "Scheduled",
                    Notes = "New patient consultation",
                    Reason = "Initial consultation",
                    PatientId = 16,
                    DoctorId = 6
                },
                new Appointment
                {
                    Id = 7,
                    Date = new DateTime(2024, 11, 21),
                    StartTime = new TimeSpan(15, 0, 0),
                    EndTime = new TimeSpan(15, 30, 0),
                    Status = "Scheduled",
                    Notes = "Consultation for chronic condition",
                    Reason = "Management of chronic illness",
                    PatientId = 17,
                    DoctorId = 7
                },
                new Appointment
                {
                    Id = 8,
                    Date = new DateTime(2024, 11, 22),
                    StartTime = new TimeSpan(16, 0, 0),
                    EndTime = new TimeSpan(16, 30, 0),
                    Status = "Scheduled",
                    Notes = "Routine follow-up",
                    Reason = "Check-up after treatment",
                    PatientId = 18,
                    DoctorId = 8
                },
                new Appointment
                {
                    Id = 9,
                    Date = new DateTime(2024, 11, 23),
                    StartTime = new TimeSpan(17, 0, 0),
                    EndTime = new TimeSpan(17, 30, 0),
                    Status = "Scheduled",
                    Notes = "Consultation for test results",
                    Reason = "Discuss test results",
                    PatientId = 19,
                    DoctorId = 9
                },
                new Appointment
                {
                    Id = 10,
                    Date = new DateTime(2024, 11, 24),
                    StartTime = new TimeSpan(18, 0, 0),
                    EndTime = new TimeSpan(18, 30, 0),
                    Status = "Scheduled",
                    Notes = "Routine check-up",
                    Reason = "General health check",
                    PatientId = 11,
                    DoctorId = 10
                }
            );
        }
    }
}
