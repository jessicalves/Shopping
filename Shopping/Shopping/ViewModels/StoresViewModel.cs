using System;
using System.Collections.Generic;
using System.Windows.Input;
using Shopping.Models;
using Xamarin.Forms;
using Shopping.Services;
using System.Linq;
using Shopping.Libraries.Enums;

namespace Shopping.ViewModels
{
	public class StoresViewModel
	{
		public String SearchWord { get; set; }
		public ICommand SearchCommand { get; set; }
		public List<Establishment> Establishments { get; set; }
		private List<Establishment> _allEstablishments;

        public StoresViewModel()
		{
			SearchCommand = new Command(Search);

			var allEstablishment = new EstablishmentService().GetEstablishments();
			var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store).ToList();
			Establishments = allStores;
        }

		private void Search()
		{
			//Logica de filtar a lista de lojas
			Establishments = _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();
        }
	}
}

