using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    public interface IUserRepository : IRepository
    {
        Task<User> GetAsync(int id);

        Task<User> GetAsync(string login);

        Task AddAsync(User user);

        Task RemoveAsync(int id);

        Task UpdateAsync(User user);
       
    }
}
