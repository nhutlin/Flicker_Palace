﻿using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace ParkCinema.ViewModels
{
    public class AdminUCViewModel : BaseViewModel
    {
        public RelayCommand LoginCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand EditMovieCommand { get; set; }
        public RelayCommand AddMovieClickCommand { get; set; }
        public RelayCommand AllPlacesClickCommand { get; set; }
        public RelayCommand BackToUserCommand { get; set; }
        private Visibility passwordSideVisibility;

        public Visibility PasswordSideVisibility
        {
            get { return passwordSideVisibility; }
            set { passwordSideVisibility = value;OnPropertyChanged(); }
        }
        private Visibility mainPartVisibility;

        public Visibility MainPartVisibility
        {
            get { return mainPartVisibility; }
            set { mainPartVisibility = value;OnPropertyChanged();OnPropertyChanged(); }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; OnPropertyChanged(); }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }
        private ObservableCollection<Movie> allMovies;

        public ObservableCollection<Movie> AllMovies
        {
            get { return allMovies; }
            set { allMovies = value; OnPropertyChanged(); }
        }

        public AdminUCViewModel()
        {
            PasswordSideVisibility = Visibility.Visible;
            MainPartVisibility = Visibility.Hidden;
            AllMovies = new ObservableCollection<Movie>(App.MovieRepo.Movies);
            LoginCommand = new RelayCommand((obj) =>
            {
                if (Email == "an@gmail.com" && Password == "123")
                {
                    PasswordSideVisibility = Visibility.Hidden;
                    MainPartVisibility= Visibility.Visible;
                }
            });
            AddMovieClickCommand = new RelayCommand((obj) =>
            {
                var uc = new AddMovieUC();
                var vm = new AddMovieUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
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
            LogoClickCommand = new RelayCommand((obj) =>
            {
                App.BackPage = App.MyGrid.Children[0];

                var uc = new HomeUC();
                var vm = new HomeUCViewModel();

                uc.DataContext = vm;
                App.MyGrid.Children.Add(uc);
            });
            EditMovieCommand = new RelayCommand((obj) =>
            {
                var mov = obj as Movie;
                if (obj is Grid grid)
                {
                    foreach (var item in grid.Children)
                    {
                        if(item is TextBlock txt)
                        {
                            foreach (var temp in App.MovieRepo.Movies)
                            {
                                if(txt.Text == temp.MovieName)
                                {
                                    mov = temp;
                                    break;
                                }
                            }
                        }
                    }
                }
                var vm = new EditUCViewModel();
                var uc = new EditUC();
                
                foreach (var item in App.MovieRepo.Movies)
                {
                    if (item == mov)
                    {
                        vm.Movie = mov;
                        vm.Title = item.MovieName;
                        vm.Year = item.MovieYear;
                        vm.Genre = item.MovieGenre;
                        vm.Director = item.MovieDirector;
                        vm.Actor = item.MovieActors;
                        vm.Country = item.MovieCountry;
                        vm.Language = item.MovieLanguages;
                        vm.Duration = item.MovieDuration;
                        vm.Rating = item.Rating;
                        vm.Price = item.MoviePrice;
                        vm.ImagePath = item.ImagePath;
                        vm.AgeLimit = item.Age;
                        vm.Condition = item.MovieCondition;
                        break;
                    }
                }
                
                uc.DataContext = vm;
                App.MyGrid.Children.Add(uc);
            });
            AllPlacesClickCommand = new RelayCommand((obj) =>
            {
                var uc = new AllPlacesUC();
                var vm = new AllPlacesUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
