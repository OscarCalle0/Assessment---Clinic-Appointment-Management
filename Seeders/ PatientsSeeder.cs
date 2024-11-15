using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class PatientsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 1, BirthDate = new DateTime(1985, 5, 12), Address = "123 Main St", UserId = 11 },
                new Patient { Id = 2, BirthDate = new DateTime(1990, 3, 5), Address = "456 Elm St", UserId = 12 },
                new Patient { Id = 3, BirthDate = new DateTime(2000, 8, 19), Address = "789 Oak St", UserId = 13 },
                new Patient { Id = 4, BirthDate = new DateTime(1995, 11, 23), Address = "101 Pine St", UserId = 14 },
                new Patient { Id = 5, BirthDate = new DateTime(1980, 7, 30), Address = "202 Birch St", UserId = 15 },
                new Patient { Id = 6, BirthDate = new DateTime(1975, 12, 1), Address = "303 Cedar St", UserId = 16 },
                new Patient { Id = 7, BirthDate = new DateTime(2005, 6, 14), Address = "404 Maple St", UserId = 17 },
                new Patient { Id = 8, BirthDate = new DateTime(2010, 4, 10), Address = "505 Ash St", UserId = 18 },
                new Patient { Id = 9, BirthDate = new DateTime(2002, 9, 2), Address = "606 Willow St", UserId = 19 },
                new Patient { Id = 10, BirthDate = new DateTime(1988, 1, 22), Address = "707 Pine St", UserId = 20 }
            );
        }
    }
}
