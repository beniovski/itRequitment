using ItRequitment.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    public interface ICompanyRepository : IRepository
    {
        Task AddAsync(Company company); 
             
        Task<Company> GetAsync(int id);

        Task<Company> GetAsync(string email);

        Task UpdateAsync(Company company);

        Task RemoveAsync(int id);

        Task<IEnumerable<Company>> GetByCity(string city);

        Task<IEnumerable<JobOffer>> GetAllCompanyOfferAsync(Company company);

    }
}
