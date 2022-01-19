﻿using Dietas_App.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dietas_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaPrincipal());
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
