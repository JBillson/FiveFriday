﻿using FiveFriday.Services;
using Xamarin.Forms;

namespace FiveFriday
{
    public partial class App
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<DriverMockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
