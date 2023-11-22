using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiveFriday.Models;
using Newtonsoft.Json;

namespace FiveFriday.Services
{
    public class DriverMockDataStore : IDataStore<Driver>
    {
        private static List<Driver> _drivers;

        public static async Task InitAsync()
        {
            var input = await Utilities.FileReader.ReadFileAsync("Data.drivers.json");
            var data = JsonConvert.DeserializeObject<Data>(input);
            _drivers = data.Drivers;
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            if (_drivers == null)
                return await Task.FromResult(false);

            var driver = _drivers.FirstOrDefault(x => x.DriverId == int.Parse(id));
            if (driver == null)
                return await Task.FromResult(false);

            _drivers.Remove(driver);
            return await Task.FromResult(true);
        }

        public async Task<Driver> GetByIdAsync(string id)
        {
            return await Task.FromResult(_drivers.FirstOrDefault(x => x.DriverId == int.Parse(id)));
        }

        public async Task<IEnumerable<Driver>> GetAllAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(_drivers);
        }

        public async Task<IEnumerable<Driver>> SearchAsync(string query, bool forceRefresh = false)
        {
            return await Task.FromResult(_drivers.Where(x =>
                (x.Forename + " " + x.Surname).ToLower().Contains(query.ToLower()) ||
                x.VehicleRegistration.ToLower().Contains(query.ToLower())));
        }
    }
}