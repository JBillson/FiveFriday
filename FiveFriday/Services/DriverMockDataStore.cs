using System.Collections.Generic;
using System.Threading.Tasks;
using FiveFriday.Models;

namespace FiveFriday.Services
{
    public class DriverMockDataStore : IDataStore<DriverMockDataStore>
    {
        private readonly List<Driver> _drivers;

        public DriverMockDataStore()
        {
            // read from json file
        }
        
        public Task<bool> AddItemAsync(DriverMockDataStore item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(DriverMockDataStore item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<DriverMockDataStore> GetItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<DriverMockDataStore>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new System.NotImplementedException();
        }
    }
}