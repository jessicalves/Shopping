using System;
using Newtonsoft.Json;
using Xamarin.Forms;
using Shopping.Models;
using Shopping.Services;
using Shopping.Libraries.Helpers.MVVM;

namespace Shopping.ViewModels
{
    [QueryProperty("filmSerialized", "filmSerialized")]
    public class FilmDetailViewModel : BaseViewModel
    {
        public Film Film { get; set; }

        public string filmSerialized
        {
            set
            {
                try
                {
                    //TODO - Deserializar e atribuir ao Film.
                    var decode = Uri.UnescapeDataString(value);
                    var film = JsonConvert.DeserializeObject<Film>(decode);

                    Film = film;
                    OnPropertyChanged(nameof(Film));

                }
                catch (Exception ex)
                {
                    var erro = ex;
                }
            }
        }
        public FilmDetailViewModel()
        {

        }
    }
}

