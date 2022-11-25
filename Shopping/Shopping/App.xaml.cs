﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Shopping
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            Device.SetFlags(new string[] {"Shapes_Experimental"});
            MainPage = new Menu();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

