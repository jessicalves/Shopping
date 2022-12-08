using System;
using System.Collections.Generic;
using System.Windows.Input;
using Shopping.Models;
using Xamarin.Forms;
using Shopping.Services;
using System.Linq;
using Shopping.Libraries.Enums;
using Shopping.Libraries.Helpers.MVVM;
using Newtonsoft.Json;

namespace Shopping.ViewModels
{
    public class StoresViewModel : EstablishmentViewModel
    {
        public StoresViewModel(EstablishmentType establishmentType) : base(establishmentType)
        {
        }
    }
}

