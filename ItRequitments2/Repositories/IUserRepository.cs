using ItRequitment.Models;
using ItRequitment.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItRequitments.Repositories
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
