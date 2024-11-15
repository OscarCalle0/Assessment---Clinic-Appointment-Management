using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class PatientsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().HasData(
                new Patient { Id = 11, BirthDate = new DateTime(1985, 5, 12), Address = "123 Main St", UserId = 11, MedicalHistory = "No known allergies" },
                new Patient { Id = 12, BirthDate = new DateTime(1990, 3, 5), Address = "456 Elm St", UserId = 12, MedicalHistory = "Asthma" },
                new Patient { Id = 13, BirthDate = new DateTime(2000, 8, 19), Address = "789 Oak St", UserId = 13, MedicalHistory = "Diabetes type 1" },
                new Patient { Id = 14, BirthDate = new DateTime(1995, 11, 23), Address = "101 Pine St", UserId = 14, MedicalHistory = "High blood pressure" },
                new Patient { Id = 15, BirthDate = new DateTime(1980, 7, 30), Address = "202 Birch St", UserId = 15, MedicalHistory = "History of heart disease" },
                new Patient { Id = 16, BirthDate = new DateTime(1975, 12, 1), Address = "303 Cedar St", UserId = 16, MedicalHistory = "Allergic to penicillin" },
                new Patient { Id = 17, BirthDate = new DateTime(2005, 6, 14), Address = "404 Maple St", UserId = 17, MedicalHistory = "No known medical issues" },
                new Patient { Id = 18, BirthDate = new DateTime(2010, 4, 10), Address = "505 Ash St", UserId = 18, MedicalHistory = "History of asthma" },
                new Patient { Id = 19, BirthDate = new DateTime(2002, 9, 2), Address = "606 Willow St", UserId = 19, MedicalHistory = "No known allergies" }
            );
        }
    }
}
