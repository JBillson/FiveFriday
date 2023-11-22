using FiveFriday.ViewModels;
using Xamarin.Forms.Xaml;

namespace FiveFriday.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DriversPage
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
    }
}