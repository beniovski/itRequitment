using ItRequitment.Core.Models;
using System.Threading.Tasks;

namespace ItRequitment.Infrastructure.Services
{
    interface IUserService : IService
    {
        Task<User> GetAsync(string email);

        Task LoginAsync(string email, string password);

        Task RegisterAsync(User user);

    }
}
