using ItRequitment.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItRequitment.Core;
using System.Threading.Tasks;
using ItRequitment.Core.DAL;

namespace ItRequitment.Infrastructure.Repositories
{
    public class DbUserRepository : DbReposiotory, IUserRepository
    {
        
        public async Task AddAsync(User user) => Dbc.User.Add(user);

        public async Task<User> GetAsync(int id) => await Task.FromResult(Dbc.User.SingleOrDefault(x => x.UserId == id));

        public async Task<User> GetAsync(string login) => await Task.FromResult(Dbc.User.SingleOrDefault(x => x.Login == login));

        public async Task RemoveAsync(int id)
        {
            var user = await GetAsync(id);
            Dbc.User.Remove(user);
        }

        public async Task UpdateAsync(int id, User user)
        {
            var getUser = await GetAsync(id);
            getUser = user;            
        }
    }
}