using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Shopping
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            Xamarin.Forms.Device.SetFlags(new string[] {"Shapes_Experimental"});
            MainPage = new Menu();
        }

        protected override void OnStart ()
        {
            AppCenter.Start("ios={Your App secret here};" +
                  "uwp={Your UWP App secret here};" +
                  "android={Your Android App secret here};" +
                  "macos={Your macOS App secret here};",
                  typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

