using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactWebModels;

namespace MyContactManagerRepositories
{
    public interface IContactsRepository
    {
        Task<IList<Contact>> GetAllAsync();
        Task<Contact?> GetAsync(int id);
        Task<int> AddOrUpdateAsync(Contact state);
        Task<int> DeleteAsync(Contact state);
        Task<int> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
