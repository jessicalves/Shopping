using System;
using System.Collections.Generic;
using System.Windows.Input;
using Shopping.Models;
using Xamarin.Forms;
using Shopping.Services;
using System.Linq;
using Shopping.Libraries.Enums;
using Shopping.Libraries.Helpers.MVVM;

namespace Shopping.ViewModels
{
    public class StoresViewModel : BaseViewModel
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

        public StoresViewModel()
        {
            SearchCommand = new Command(Search);

            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store).ToList();
            Establishments = allStores;
            _allEstablishments = allStores;

        }

        private void Search()
        {
            //Logica de filtar a lista de lojas
            Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
    }
}

