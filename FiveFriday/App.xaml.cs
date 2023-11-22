﻿using FiveFriday.Services;
using FiveFriday.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FiveFriday
{
    public partial class App : Application
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
