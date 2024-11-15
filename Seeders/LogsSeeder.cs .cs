using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class LogsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>().HasData(
                new Log { Id = 1, Action = "Created", TimeStamp = DateTime.Now, AppointmentId = 1, UserId = 1 },
                new Log { Id = 2, Action = "Updated", TimeStamp = DateTime.Now, AppointmentId = 2, UserId = 2 },
                new Log { Id = 3, Action = "Deleted", TimeStamp = DateTime.Now, AppointmentId = 3, UserId = 3 },
                new Log { Id = 4, Action = "Created", TimeStamp = DateTime.Now, AppointmentId = 4, UserId = 4 },
                new Log { Id = 5, Action = "Updated", TimeStamp = DateTime.Now, AppointmentId = 5, UserId = 5 },
                new Log { Id = 6, Action = "Created", TimeStamp = DateTime.Now, AppointmentId = 6, UserId = 6 },
                new Log { Id = 7, Action = "Updated", TimeStamp = DateTime.Now, AppointmentId = 7, UserId = 7 },
                new Log { Id = 8, Action = "Created", TimeStamp = DateTime.Now, AppointmentId = 8, UserId = 8 },
                new Log { Id = 9, Action = "Updated", TimeStamp = DateTime.Now, AppointmentId = 9, UserId = 9 },
                new Log { Id = 10, Action = "Deleted", TimeStamp = DateTime.Now, AppointmentId = 10, UserId = 10 }
            );
        }
    }
}
