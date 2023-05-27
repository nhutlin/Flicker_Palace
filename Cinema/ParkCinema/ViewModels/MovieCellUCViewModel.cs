using Newtonsoft.Json;
using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ParkCinema.ViewModels
{
    public class MovieCellViewModel : BaseViewModel
    {
        public RelayCommand AddMovieClickCommand { get; set; }
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set
            {
                movie = value;

                if (movie.MovieName.Length >= 30)
                {
                    movie.MovieName = movie.MovieName.Substring(0, 25);
                }
                OnPropertyChanged();
            }
        }
        public MovieCellViewModel()
        {
            AddMovieClickCommand = new RelayCommand((obj) =>
            {
                var mymovie = new Movie();
                mymovie.MovieName = movie.MovieName;
                mymovie.MovieDate = movie.MovieDate;
                mymovie.MovieFormat = movie.MovieFormat;
                mymovie.MovieLanguages = movie.MovieLanguages;
                mymovie.Age = movie.Age;
                mymovie.ImagePath = movie.ImagePath;
                mymovie.MovieCondition = movie.MovieCondition;
                mymovie.MovieCountry = movie.MovieCountry;
                mymovie.MovieDirector = movie.MovieDirector;
                mymovie.MovieGenre = movie.MovieGenre;
                mymovie.MovieActors = movie.MovieActors;
                mymovie.About = movie.About;
                mymovie.MovieDuration = movie.MovieDuration;
                mymovie.MovieYear = movie.MovieYear;
                mymovie.Rating = movie.Rating;
                mymovie.MoviePrice = movie.MoviePrice;
                mymovie.MovieLink = "";

                
                App.MovieRepo.Movies.Add(mymovie); 
                var data = new List<Movie>();

                foreach (var item in App.MovieRepo.Movies)
                {
                    data.Add(item);
                }

                string jsonString = JsonConvert.SerializeObject(data);
                File.WriteAllText("movies.json", jsonString);
            });
        }

    }
}
