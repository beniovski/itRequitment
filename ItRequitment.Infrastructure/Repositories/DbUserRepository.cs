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
    public class DbUserRepository : IUserRepository
    {
        private DataBaseContext Dbc;

        public DbUserRepository()
        {
            Dbc = new DataBaseContext();
        }

        public async Task AddAsync(User user) => Dbc.User.Add(user);
                                               
           

        public Task<User> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(string login)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}