using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class AppointmentsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment { Id = 1, Date = new DateTime(2024, 11, 15), StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(9, 30, 0), Status = "Scheduled", PatientId = 1, DoctorId = 1 },
                new Appointment { Id = 2, Date = new DateTime(2024, 11, 16), StartTime = new TimeSpan(10, 0, 0), EndTime = new TimeSpan(10, 30, 0), Status = "Scheduled", PatientId = 2, DoctorId = 2 },
                new Appointment { Id = 3, Date = new DateTime(2024, 11, 17), StartTime = new TimeSpan(11, 0, 0), EndTime = new TimeSpan(11, 30, 0), Status = "Scheduled", PatientId = 3, DoctorId = 3 },
                new Appointment { Id = 4, Date = new DateTime(2024, 11, 18), StartTime = new TimeSpan(12, 0, 0), EndTime = new TimeSpan(12, 30, 0), Status = "Scheduled", PatientId = 4, DoctorId = 4 },
                new Appointment { Id = 5, Date = new DateTime(2024, 11, 19), StartTime = new TimeSpan(13, 0, 0), EndTime = new TimeSpan(13, 30, 0), Status = "Scheduled", PatientId = 5, DoctorId = 5 },
                new Appointment { Id = 6, Date = new DateTime(2024, 11, 20), StartTime = new TimeSpan(14, 0, 0), EndTime = new TimeSpan(14, 30, 0), Status = "Scheduled", PatientId = 6, DoctorId = 6 },
                new Appointment { Id = 7, Date = new DateTime(2024, 11, 21), StartTime = new TimeSpan(15, 0, 0), EndTime = new TimeSpan(15, 30, 0), Status = "Scheduled", PatientId = 7, DoctorId = 7 },
                new Appointment { Id = 8, Date = new DateTime(2024, 11, 22), StartTime = new TimeSpan(16, 0, 0), EndTime = new TimeSpan(16, 30, 0), Status = "Scheduled", PatientId = 8, DoctorId = 8 },
                new Appointment { Id = 9, Date = new DateTime(2024, 11, 23), StartTime = new TimeSpan(17, 0, 0), EndTime = new TimeSpan(17, 30, 0), Status = "Scheduled", PatientId = 9, DoctorId = 9 },
                new Appointment { Id = 10, Date = new DateTime(2024, 11, 24), StartTime = new TimeSpan(18, 0, 0), EndTime = new TimeSpan(18, 30, 0), Status = "Scheduled", PatientId = 10, DoctorId = 10 }
            );
        }
    }
}
