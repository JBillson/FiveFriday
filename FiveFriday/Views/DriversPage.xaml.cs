using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiveFriday.Models;
using FiveFriday.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiveFriday.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversPage : ContentPage
    {
        private readonly DriversViewModel _viewModel;

        public DriversPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new DriversViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private void InputView_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var text = e.NewTextValue;
            if (string.IsNullOrEmpty(text))
                DriversListView.ItemsSource = _viewModel.Drivers;
            else
            {
                DriversListView.ItemsSource = _viewModel.Drivers.Where(x =>
                    (x.Forename + " " + x.Surname).ToLower().Contains(text.ToLower()) ||
                    x.VehicleRegistration.ToLower().Contains(text.ToLower()));
            }
        }
    }
}