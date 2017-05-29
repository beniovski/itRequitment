using ItRequitment.Core.Models;
using System.Threading.Tasks;

namespace ItRequitment.Infrastructure.Services
{
    public interface ICompanyService : IService
    {
        Task GetAsync(string email);

        Task LoginAsync(string login, string password);

        Task RegisterAsync(Company company);

        Task AddJobOffer(JobOffer joboffer);
    }
}
