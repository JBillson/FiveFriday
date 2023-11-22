using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveFriday.Models;
using Newtonsoft.Json;

namespace FiveFriday.Services
{
    public class DriverMockDataStore : IDataStore<Driver>
    {
        private readonly List<Driver> _drivers;

        public DriverMockDataStore()
        {
            var input = Utilities.FileReader.ReadFile("Data.drivers.json");
            var data = JsonConvert.DeserializeObject<Data>(input);
            _drivers = data.Drivers;
        }
        
        public Task<bool> AddItemAsync(Driver driver)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Driver driver)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Driver> GetItemAsync(string id)
        {
            return await Task.FromResult(_drivers.FirstOrDefault(x=> x.DriverId == int.Parse(id)));
        }

        public async Task<IEnumerable<Driver>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_drivers);
        }
    }
}