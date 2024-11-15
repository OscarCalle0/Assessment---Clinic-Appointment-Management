using Appointment_Management.Models;
using Microsoft.EntityFrameworkCore;

namespace Appointment_Management.Seeders
{
    public static class UsersSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "John Doe", Email = "johndoe@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 2, Name = "Jane Smith", Email = "janesmith@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 3, Name = "Mike Johnson", Email = "mikejohnson@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 4, Name = "Emily Davis", Email = "emilydavis@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 5, Name = "Sarah Wilson", Email = "sarahwilson@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 6, Name = "David Brown", Email = "davidbrown@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 7, Name = "Lisa White", Email = "lisawhite@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 8, Name = "Tom Clark", Email = "tomclark@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 9, Name = "Rachel Lee", Email = "rachelee@example.com", RoleId = 2, Password = "1234" },
                new User { Id = 10, Name = "Paul Harris", Email = "paulharris@example.com", RoleId = 2, Password = "1234" },

                new User { Id = 11, Name = "Anna Brown", Email = "annabrown@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 12, Name = "Ben Johnson", Email = "benjohnson@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 13, Name = "Clara Wilson", Email = "clarawilson@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 14, Name = "Daniel Green", Email = "danielgreen@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 15, Name = "Ella White", Email = "ellawhite@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 16, Name = "Fiona Turner", Email = "fionaturner@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 17, Name = "George Harris", Email = "georgeharris@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 18, Name = "Helen Clark", Email = "helenclark@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 19, Name = "Ivy Cooper", Email = "ivycooper@example.com", RoleId = 3, Password = "1234" },
                new User { Id = 20, Name = "Jack Moore", Email = "jackmoore@example.com", RoleId = 3, Password = "1234" },

                new User { Id = 21, Name = "Oscar Calle", Email = "oscarcalle0@gmail.com", RoleId = 1, Password = "1234" }
            );

        }
    }
}
