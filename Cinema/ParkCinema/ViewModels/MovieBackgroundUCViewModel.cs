using Microsoft.Web.WebView2.Wpf;
using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace ParkCinema.ViewModels
{
    public class MovieBackgroundUCViewModel : BaseViewModel
    {
        private Movie movie;

        public Movie Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        private ObservableCollection<Movie> movies;

        public ObservableCollection<Movie> AllMovies
        {
            get { return movies; }
            set { movies = value; OnPropertyChanged(); }
        }
        private Visibility webViewVisibility;

        public Visibility WebViewVisibility
        {
            get { return webViewVisibility; }
            set { webViewVisibility = value; OnPropertyChanged(); }
        }

        public RelayCommand AppleClickCommand { get; set; }
        public RelayCommand AndroidClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand MovieNameClickCommand { get; set; }
        public RelayCommand BuyTicketCommand { get; set; }

        public Random a = new Random(); 
        public List<int> randomList = new List<int>();
        public ObservableCollection<Movie> movieList = new ObservableCollection<Movie>();
        int MyNumber = 0;

        public MovieBackgroundUCViewModel()
        {
            WebViewVisibility = Visibility.Visible;
            Movie = new Movie();

            LogoClickCommand = new RelayCommand((obj) =>
            {
                var grid = obj as Grid;
                foreach (UIElement child in grid.Children)
                {
                    if (child is StackPanel stack)
                    {
                        foreach (var item1 in stack.Children)
                        {
                            if (item1 is WebView2 web)
                            {
                                web.Dispose();
                            }
                        }
                    }
                }
                App.BackPage = App.MyGrid.Children[0];
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();

                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            AppleClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://apps.apple.com/us/app/park-cinema/id1119977600?ls=1");
            });
            AndroidClickCommand = new RelayCommand((obj) =>
            {
                System.Diagnostics.Process.Start("https://play.google.com/store/apps/details?id=az.parkcinema.app&hl=ru");
            });
            BuyTicketCommand = new RelayCommand((obj) =>
            {
                var uc = new ScheduleUC();
                var vm = new ScheduleUCViewModel();
                var newMovies = new ObservableCollection<MovieSchedule>();
                foreach (var item in App.ScheduleRepo.MovieSchedules)
                {
                    if(item.MovieName== Movie.MovieName)
                    {
                        vm.Movie = item;
                        newMovies.Add(item);
                    }
                }
                vm.Movies = newMovies;
                vm.AllMovies = newMovies;
                uc.DataContext = vm;
                var grid = obj as Grid;
                foreach (UIElement child in grid.Children)
                {
                    if(child is StackPanel stack)
                    {
                        foreach (var item1 in stack.Children)
                        {
                            if(item1 is WebView2 web)
                            {
                                web.Dispose();
                            }
                        }
                    }
                }
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            MovieNameClickCommand = new RelayCommand((obj) =>
            {
                var grid = obj as Grid;
                var temp=obj as Movie;
                foreach (var child in grid.Children)
                {
                    if(child is ListBox list)
                    {
                        temp=list.SelectedItem as Movie;
                    }
                }
                movieList = new ObservableCollection<Movie>();
                WebViewVisibility = Visibility.Hidden;
                var vm = new MovieBackgroundUCViewModel();
                vm.Movie = temp;
                var movies = new ObservableCollection<Movie>();
                var moviesShort = new ObservableCollection<Movie>();
                for (int i = 1; i <= App.MovieRepo.Movies.Count; i++)
                {
                    
                    if (i == vm.Movie.Id)
                    {
                        for (int j = 0; j < i - 1; j++)
                        {
                            movies.Add(App.MovieRepo.Movies[j]);
                        }
                        for (int j = i; j < App.MovieRepo.Movies.Count; j++)
                        {
                            movies.Add(App.MovieRepo.Movies[j]);
                        }
                        for (int k = 0; k < 5;)
                        {
                            MyNumber = a.Next(0, movies.Count);
                            if (!randomList.Contains(MyNumber) && MyNumber != vm.Movie.Id)
                            {
                                k++;
                                movieList.Add(movies[MyNumber]);
                                randomList.Add(MyNumber);
                            }
                        }
                        break;
                    }
                }
                vm.AllMovies = movieList;
                var uc = new MovieBackgroundUC();
                uc.DataContext = vm;
                foreach (UIElement child in grid.Children)
                {
                    if (child is StackPanel stack)
                    {
                        foreach (var item1 in stack.Children)
                        {
                            if (item1 is WebView2 web)
                            {
                                web.Dispose();
                            }
                        }
                    }
                }
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
