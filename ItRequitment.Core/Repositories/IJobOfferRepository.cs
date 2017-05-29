using ItRequitment.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItRequitment.Core.Repositories
{
    public interface IJobOfferRepository : IRepository
    {
        Task AddAsync(JobOffer joboffer);

        Task UpdateAsync(JobOffer joboffer);

        Task RemoveAsync(int id);

        Task<IEnumerable<JobOffer>> GetAllJobAsync();

        Task<IEnumerable<JobOffer>> GetAllJobByCity();




    }
}
