using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Services;
using System;
using System.Collections.Generic;
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
                var grid = obj as Grid;
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
                mymovie.MovieLink = "https://www.youtube.com/watch?v=642lKXC97c4";

                //foreach (var item in grid.Children)
                //{
                //    if(item is Canvas canvas)
                //    {
                //        foreach (var mov in canvas.Children)
                //        {
                //            if(mov is TextBlock txt)
                //            {
                //                if (txt.Name == "name")
                //                {
                //                    mymovie.MovieName = txt.Text;
                //                }
                //                if (txt.Name == "about")
                //                {
                //                    mymovie.About = txt.Text;
                //                }
                //                if (txt.Name == "rating")
                //                {
                //                    mymovie.Rating = double.Parse(txt.Text);
                //                }                       
                //            }
                //            if(mov is Image img)
                //            {
                //                if (img.Name == "image")
                //                {
                //                    mymovie.ImagePath = "/images/shazamCover.jpg";
                //                }
                //            }
                //        }
                //    }
                //}
                App.MovieRepo.Movies.Add(mymovie);
            });
        }

    }
}
