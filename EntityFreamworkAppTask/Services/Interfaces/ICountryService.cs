using System.Collections.Generic;
using System.Threading.Tasks;
using EntityFreamworkAppTask.Models;


namespace EntityFreamworkAppTask.Services.Interfaces
{
    internal interface ICountryService
    {
        Task CreateAsync(Country country);
        Task<Country> GetByIdAsync(int id);
        Task<List<Country>> GetAllAsync();
        Task DeleteAsync(int id);
    }
}
