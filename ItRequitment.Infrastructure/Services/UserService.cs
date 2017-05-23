using ItRequitment.Core.Models;
using System;
using System.Threading.Tasks;

namespace ItRequitment.Infrastructure.Services
{
    public class UserService : IUserService
    {
        public Task<User> GetAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task RegisterAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}