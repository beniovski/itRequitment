using ItRequitment.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    public interface IJobOfferRepository : IRepository
    {
        Task AddAsync(JobOffer joboffer, Company company);

        Task<JobOffer> GetAsync(int id);

        Task UpdateAsync(JobOffer joboffer);

        Task RemoveAsync(int id);

        Task<IEnumerable<JobOffer>> GetAllJobAsync();

        Task<IEnumerable<JobOffer>> GetAllJobByCity(string city);




    }
}
