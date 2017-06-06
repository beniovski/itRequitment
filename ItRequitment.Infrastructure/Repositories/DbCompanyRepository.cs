using ItRequitment.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ItRequitment.Core.Models;
using System.Threading.Tasks;

namespace ItRequitment.Infrastructure.Repositories
{
    public class DbCompanyRepository : DbReposiotory, ICompanyRepository
    {
        public async Task AddAsync(Company company) => Dbc.company.Add(company);

        public async Task<IEnumerable<JobOffer>> GetAllCompanyOfferAsync(Company company) => await Task.FromResult(Dbc.JobOffer.Where(x => x.Company == company));

        public async Task<Company> GetAsync(int id) => await Task.FromResult(Dbc.company.SingleOrDefault(x => x.CompanyId == id));

        public async Task<Company> GetAsync(string email) => await Task.FromResult(Dbc.company.SingleOrDefault(x => x.Email == email));

        public async Task<IEnumerable<Company>> GetByCity(string city) => await Task.FromResult(Dbc.company.Where(x=>x.City == city));

        public async Task RemoveAsync(int id)
        {
            var getCompany = await GetAsync(id);
            Dbc.company.Remove(getCompany);
        }

        public Task UpdateAsync(Company company)
        {
            throw new NotImplementedException();
        }
    }
}