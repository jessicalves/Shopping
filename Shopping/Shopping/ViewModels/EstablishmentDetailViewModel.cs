using System;
using System.Linq;
using Newtonsoft.Json;
using Shopping.Models;
using Shopping.Services;
using Xamarin.Forms;

namespace Shopping.ViewModels
{
    [QueryProperty("establishmentSerialized", "establishmentSerialized")]
    public class EstablishmentDetailViewModel : MvvmHelpers.BaseViewModel
    {
        public Establishment Establishment { get; set; }

        public String establishmentSerialized
        {
            set
            {
                Establishment = JsonConvert.DeserializeObject<Establishment>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Establishment));
            }
        }

        public EstablishmentDetailViewModel()
        {
            //Establishment = new EstablishmentService().GetEstablishments().First();
        }
    }
}

