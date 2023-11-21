using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using FiveFriday.Models;
using Xamarin.Forms;

namespace FiveFriday.ViewModels
{
    public class DriversViewModel : BaseViewModel
    {
        public ObservableCollection<Driver> Drivers { get; }
        public Command LoadDriversCommand{ get; }
        
        public DriversViewModel()
        {
            Title = "Drivers";
            Drivers = new ObservableCollection<Driver>();
            LoadDriversCommand = new Command(async () => await ExecuteLoadDriversCommand());
        }

        private async Task ExecuteLoadDriversCommand()
        {
            IsBusy = true;

            try
            {
                Drivers.Clear();
                var drivers = await DriverDataStore.GetItemsAsync(true);
                foreach (var driver in drivers)
                {
                    Drivers.Add(driver);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}