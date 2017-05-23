using ItRequitment.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    interface ICompanyRepository : IRepository
    {
        Task<Company> AddAsync(Company company);

        Task<Company> GetAsync(int id);

        Task<Company> RemoveAsync(string email);

        Task<IEnumerable<Company>> GetAllAsync();

        Task<Company> UpdateAsync(Company company);

        Task<JobOffer> AddJobOffer(JobOffer joboffer);

        Task<JobOffer> GetJobbOffer(int CompanyId);
    }
}
