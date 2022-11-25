using System;
using System.Linq;
using Shopping.Models;
using Shopping.Services;
namespace Shopping.ViewModels
{
	public class EstablishmentDetailViewModel : MvvmHelpers.BaseViewModel
    {
		public Establishment Establishment { get; set; }

		public EstablishmentDetailViewModel()
		{
			Establishment = new EstablishmentService().GetEstablishments().First();

        }
	}
}

