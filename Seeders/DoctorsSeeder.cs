using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class DoctorsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor { Id = 1, Availability = true, Status = "Active", SpecialtyId = 1, UserId = 1 },
                new Doctor { Id = 2, Availability = true, Status = "Active", SpecialtyId = 2, UserId = 2 },
                new Doctor { Id = 3, Availability = true, Status = "Active", SpecialtyId = 3, UserId = 3 },
                new Doctor { Id = 4, Availability = true, Status = "Active", SpecialtyId = 4, UserId = 4 },
                new Doctor { Id = 5, Availability = true, Status = "Active", SpecialtyId = 5, UserId = 5 },
                new Doctor { Id = 6, Availability = true, Status = "Active", SpecialtyId = 6, UserId = 6 },
                new Doctor { Id = 7, Availability = true, Status = "Active", SpecialtyId = 7, UserId = 7 },
                new Doctor { Id = 8, Availability = true, Status = "Active", SpecialtyId = 8, UserId = 8 },
                new Doctor { Id = 9, Availability = true, Status = "Active", SpecialtyId = 9, UserId = 9 },
                new Doctor { Id = 10, Availability = true, Status = "Active", SpecialtyId = 10, UserId = 10 }
            );
        }
    }
}
