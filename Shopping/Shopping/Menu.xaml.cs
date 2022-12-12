using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Shopping
{
    public partial class Menu : Shell
    {
        public Menu()
        {
            InitializeComponent();

            Routing.RegisterRoute("establishment/detail", typeof(Views.EstablishmentDetail));
            Routing.RegisterRoute("film/detail", typeof(Views.FilmDetail));
        }
    }
}

