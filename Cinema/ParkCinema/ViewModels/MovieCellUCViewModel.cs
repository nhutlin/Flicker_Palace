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
                foreach (var item in grid.Children)
                {
                    if(item is Canvas canvas)
                    {
                        foreach (var mov in canvas.Children)
                        {
                            if(mov is TextBlock txt)
                            {
                                if (txt.Name == "name")
                                {
                                    mymovie.MovieName = txt.Text;
                                }
                                if (txt.Name == "about")
                                {
                                    mymovie.About = txt.Text;
                                }
                                if (txt.Name == "rating")
                                {
                                    mymovie.Rating = double.Parse(txt.Text);
                                }                       
                            }
                            if(mov is Image img)
                            {
                                if (img.Name == "image")
                                {
                                    mymovie.ImagePath = img.Source.ToString();
                                }
                            }
                        }
                    }
                }
                App.MovieRepo.Movies.Add(mymovie);
            });
        }

    }
}
