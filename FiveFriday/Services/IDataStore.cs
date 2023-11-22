using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveFriday.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false);
        Task<IEnumerable<T>> SearchAsync(string query, bool forceRefresh = false);
    }
}
