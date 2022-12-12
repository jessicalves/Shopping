using System;
using System.Collections.Generic;
using System.Windows.Input;
using Newtonsoft.Json;
using Shopping.Models;
using Shopping.Services;
using Xamarin.Forms;

namespace Shopping.ViewModels
{
    public class CinemaViewModel : MvvmHelpers.BaseViewModel
    {
        public ICommand FilmDetailCommand { get; set; }
        public List<Film> Films { get; set; }

        public CinemaViewModel()
        {
            FilmDetailCommand = new Command<Film>(FilmDetail);

            Films = new CinemaService().GetFilms();
        }
        private void FilmDetail(Film film)
        {
            var filmSerialized = JsonConvert.SerializeObject(film);
            Shell.Current.GoToAsync($"film/detail?filmSerialized={Uri.EscapeDataString(filmSerialized)}");
        }
    }
}

