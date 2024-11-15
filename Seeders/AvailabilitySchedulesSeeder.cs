using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class AvailabilitySchedulesSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AvailabilitySchedule>().HasData(
                new AvailabilitySchedule { Id = 1, DayOfWeek = 1, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 1 },
                new AvailabilitySchedule { Id = 2, DayOfWeek = 2, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 2 },
                new AvailabilitySchedule { Id = 3, DayOfWeek = 3, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 3 },
                new AvailabilitySchedule { Id = 4, DayOfWeek = 4, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 4 },
                new AvailabilitySchedule { Id = 5, DayOfWeek = 5, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 5 },
                new AvailabilitySchedule { Id = 6, DayOfWeek = 6, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 6 },
                new AvailabilitySchedule { Id = 7, DayOfWeek = 0, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 7 },
                new AvailabilitySchedule { Id = 8, DayOfWeek = 1, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 8 },
                new AvailabilitySchedule { Id = 9, DayOfWeek = 2, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 9 },
                new AvailabilitySchedule { Id = 10, DayOfWeek = 3, StartTime = new TimeSpan(9, 0, 0), EndTime = new TimeSpan(17, 0, 0), Status = true, DoctorId = 10 }
            );
        }
    }
}
