using System;

using Xamarin.Forms;

namespace Shopping.Views
{
    public class Restaurants : ContentPage
    {
        public Restaurants ()
        {
            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}


