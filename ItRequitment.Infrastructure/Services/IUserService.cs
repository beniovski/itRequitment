using ItRequitment.Core;
using System.Threading.Tasks;

namespace ItRequitment.Infrastructure.Services
{
    public interface IUserService : IService
    {
        Task<User> GetAsync(string login);

        Task LoginAsync(string login, string password);
        
        Task RegisterAsync(User user);
    }
}