using Appointment_Management.Models;
using System.Threading.Tasks;

namespace Appointment_Management.Repositories
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task Register(User user, string password);
        Task<User> GetByEmail(string email);
        Task<User> ValidatePasswordResetToken(string token);
        Task UpdatePassword(User user, string newPassword);
    }
}
