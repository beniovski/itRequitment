using ItRequitment.Core.Repositories;
using System;

using System.Collections.Generic;
using ItRequitment.Core.Models;
using System.Threading.Tasks;
using System.Linq;

namespace ItRequitment.Infrastructure.Repositories
{
    public class DbJobOfferReposiotory : DbReposiotory, IJobOfferRepository
    {
        public async Task AddAsync(JobOffer joboffer, Company company)
        {
            company.JobOffers.Add(joboffer);
            Dbc.company.Add(company);           
        }

        public async Task<JobOffer> GetAsync(int id) => await Task.FromResult(Dbc.JobOffer.SingleOrDefault(x => x.JobOfferId == id));

        public async Task<IEnumerable<JobOffer>> GetAllJobAsync() => await Task.FromResult(Dbc.JobOffer);

        public async Task<IEnumerable<JobOffer>> GetAllJobByCity(string city) => await Task.FromResult(Dbc.JobOffer);


        public async Task RemoveAsync(int id)
        {
            var jobbOfferToRemove = await GetAsync(id);
            Dbc.JobOffer.Remove(jobbOfferToRemove);           
        }

        public async Task UpdateAsync(JobOffer joboffer)
        {
            throw new NotImplementedException();
        }
    }
}