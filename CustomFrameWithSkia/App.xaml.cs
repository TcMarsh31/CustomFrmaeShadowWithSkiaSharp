﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomFrameWithSkia
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ListPage());
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
