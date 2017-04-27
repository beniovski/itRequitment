using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItRequitment.Models.Repositories
{
    interface ICompanyRepository
    {
        Task<User> GetAsync(int id);

        Task<IEnumerable<User>> GetAllAsync();

        Task AddAsync(Company company);

        Task UpdateAsync(int id);

        Task RemoveAsync(int id);
    }
}
