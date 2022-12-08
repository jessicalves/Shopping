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
    public abstract class EstablishmentViewModel : MvvmHelpers.BaseViewModel
    {
        public String SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }

        private List<Establishment> _establishments;

        public List<Establishment> Establishments
        {
            get
            {
                return _establishments;
            }
            set
            {
                SetProperty(ref _establishments, value);
            }
        }
        private List<Establishment> _allEstablishments;

        public ICommand DetailCommand { get; set; }

        private EstablishmentType _establishmentType;

        public EstablishmentViewModel(EstablishmentType establishmentType)
        {
            _establishmentType = establishmentType;
            SearchCommand = new Command(Search);
            DetailCommand = new Command<Establishment>(Detail);

            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == _establishmentType).ToList();
            Establishments = allStores;
            _allEstablishments = allStores;
        }

        private void Search()
        {
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }

        private void Detail(Establishment establishment)
        {
            String establishmentSerialized = JsonConvert.SerializeObject(establishment);
            Shell.Current.GoToAsync($"establishment/detail?establishmentSerialized={Uri.EscapeDataString(establishmentSerialized)}");
        }
    }
}

