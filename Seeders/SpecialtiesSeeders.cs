using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class SpecialtiesSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seed data for Specialties
            modelBuilder.Entity<Specialty>().HasData(
                new Specialty { Id = 1, Name = "Cardiology", Description = "Heart specialist" },
                new Specialty { Id = 2, Name = "Neurology", Description = "Brain and nervous system specialist" },
                new Specialty { Id = 3, Name = "Pediatrics", Description = "Children's healthcare specialist" },
                new Specialty { Id = 4, Name = "Orthopedics", Description = "Bone and joint specialist" },
                new Specialty { Id = 5, Name = "Dermatology", Description = "Skin specialist" },
                new Specialty { Id = 6, Name = "Gynecology", Description = "Women's reproductive health specialist" },
                new Specialty { Id = 7, Name = "Psychiatry", Description = "Mental health specialist" },
                new Specialty { Id = 8, Name = "Dentistry", Description = "Teeth and mouth care specialist" },
                new Specialty { Id = 9, Name = "Ophthalmology", Description = "Eye health specialist" },
                new Specialty { Id = 10, Name = "ENT", Description = "Ear, nose, and throat specialist" }
            );
        }
    }
}
