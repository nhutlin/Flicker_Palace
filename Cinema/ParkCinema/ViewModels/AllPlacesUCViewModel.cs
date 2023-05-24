using Newtonsoft.Json;
using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace ParkCinema.ViewModels
{
    public class AllPlacesUCViewModel : BaseViewModel
    {
        public RelayCommand MovieSeatsCommand { get; set; }
        public RelayCommand DateSeatsCommand { get; set; }
        public RelayCommand BackToUserCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; OnPropertyChanged(); }
        }
        private string movieDate;

        public string MovieDate
        {
            get { return movieDate; }
            set { movieDate = value; OnPropertyChanged(); }
        }
        private string movieDateTime;

        public string MovieDateTime
        {
            get { return movieDateTime; }
            set { movieDateTime = value; OnPropertyChanged(); }
        }
        private string theater;

        public string Theater
        {
            get { return theater; }
            set { theater = value; OnPropertyChanged(); }
        }

        private List<MovieSchedule> allMovies;

        public List<MovieSchedule> AllMoviesSchedule
        {
            get { return allMovies; }
            set { allMovies = value; OnPropertyChanged(); }
        }
        private List<MovieSchedule> dateMovies;

        public List<MovieSchedule> DateMovies
        {
            get { return dateMovies; }
            set { dateMovies = value; OnPropertyChanged(); }
        }

        public AllPlacesUCViewModel()
        {
            var newList = new List<MovieSchedule>();
            foreach (var item in App.ScheduleRepo.MovieSchedules)
            {
                if (newList.Count != 0)
                {
                    if (!newList.Any(m => m.MovieName == item.MovieName))
                    {
                        newList.Add(item);
                    }
                }
                else
                {
                    newList.Add(item);
                }

            }
            AllMoviesSchedule = newList;
            var dateList = new List<MovieSchedule>();
            foreach (var item in AllMoviesSchedule)
            {
                if (dateList.Count != 0)
                {
                    if (!dateList.Any(m => m.MovieName == item.MovieName))
                    {
                        dateList.Add(item);
                    }
                }
                else
                {
                    dateList.Add(item);
                }
            }
            DateMovies = dateList;
            MovieSeatsCommand = new RelayCommand((obj) =>
            {
                var myList = new List<MovieSchedule>();
                var movie = obj as MovieSchedule;
                foreach (var item in App.ScheduleRepo.MovieSchedules)
                {
                    if (item.MovieName == movie.MovieName)
                    {
                        myList.Add(item);
                    }
                }
                DateMovies = myList;
                var uc = new AdminSeatsUC();
                var vm = new AdminSeatsUCViewModel();
                uc.Margin = new Thickness(0, 0, 0, -1200);
                vm.Movie = movie;
                if (File.Exists("toggleButtonState.json"))
                {
                    string jsonString = File.ReadAllText("toggleButtonState.json");
                    var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
                    if (data != null)
                    {
                        foreach (var item in data)
                        {
                            foreach (var temp in uc.myGrid.Children)
                            {
                                if (temp is ToggleButton toggleButton)
                                {
                                    if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == movie.MovieName && item.Movie.MovieDate == movie.MovieDate && item.Movie.MovieDateTime == movie.MovieDateTime)
                                    {
                                        toggleButton.IsChecked = true;
                                        toggleButton.IsEnabled = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                uc.DataContext = vm;
                if (App.MyGrid.Children.Count > 2)
                {
                    App.MyGrid.Children.RemoveAt(2);
                }
                App.MyGrid.Children.Add(uc);
            });
            DateSeatsCommand = new RelayCommand((obj) =>
            {
                var movie = obj as MovieSchedule;
                var uc = new AdminSeatsUC();
                var vm = new AdminSeatsUCViewModel();
                uc.Margin = new Thickness(0, 0, 0, -1200);
                vm.Movie = movie;
                if (File.Exists("toggleButtonState.json"))
                {
                    string jsonString = File.ReadAllText("toggleButtonState.json");
                    var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
                    if (data != null && movie != null)
                    {
                        foreach (var item in data)
                        {
                            foreach (var temp in uc.myGrid.Children)
                            {
                                if (temp is ToggleButton toggleButton)
                                {
                                    if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == movie.MovieName && item.Movie.MovieDate == movie.MovieDate && item.Movie.MovieDateTime == movie.MovieDateTime)
                                    {
                                        toggleButton.IsChecked = true;
                                        toggleButton.IsEnabled = false;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                uc.DataContext = vm;
                if (App.MyGrid.Children.Count > 2)
                {
                    App.MyGrid.Children.RemoveAt(2);
                }
                App.MyGrid.Children.Add(uc);
            });
            BackToUserCommand = new RelayCommand((obj) =>
            {
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            BackCommand = new RelayCommand((obj) =>
            {
                var uc = new AdminUC();
                var vm = new AdminUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
