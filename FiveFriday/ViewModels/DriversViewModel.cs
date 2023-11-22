using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FiveFriday.Models;
using MvvmHelpers.Commands;

namespace FiveFriday.ViewModels
{
    public class DriversViewModel : BaseViewModel
    {
        public ObservableCollection<Driver> Drivers { get; }
        public AsyncCommand LoadDriversCommand { get; }
        public AsyncCommand<object> SearchDriversCommand { get; }

        public DriversViewModel()
        {
            Title = "Drivers";

            Drivers = new ObservableCollection<Driver>();

            LoadDriversCommand = new AsyncCommand(LoadDrivers);
            SearchDriversCommand = new AsyncCommand<object>(SearchDrivers);
        }
        
        private async Task SearchDrivers(object obj)
        {
            var query = obj as string;
            IsBusy = true;
            try
            {
                Drivers.Clear();
                var drivers = await DriverDataStore.SearchAsync(query, true);
                foreach (var driver in drivers)
                {
                    Drivers.Add(driver);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
            }
            finally
            {
                IsBusy = false;
            }
        }

        private async Task LoadDrivers()
        {
            IsBusy = true;

            try
            {
                Drivers.Clear();
                var drivers = await DriverDataStore.GetAllAsync(true);
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

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}