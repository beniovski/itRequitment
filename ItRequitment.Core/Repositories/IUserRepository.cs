using ItRequitment.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task<User> AddAsync(User user);

        Task<User> GetAsync(int id);

        Task<User> RemoveAsync(string email);

        Task<IEnumerable<User>> GetAllAsync();

        Task<User> UpdateAsync(User user);    
            
    }
}
