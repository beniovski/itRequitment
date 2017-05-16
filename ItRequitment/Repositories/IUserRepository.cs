using ItRequitment.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItRequitment.Repositories
{
    interface IUserRepository : IRepository
    {
        Task<User> AddAsync(User user);

        Task<User> GetAsync(int id);

        Task<User> RemoveAsync(string email);

        Task<IEnumerable<User>> GetAllAsync();

        Task<User> UpdateAsync(User user);    
            
    }
}
