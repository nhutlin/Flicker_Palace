﻿using Newtonsoft.Json;
using FlickerPalace.Commands;
using FlickerPalace.Models;
using FlickerPalace.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace FlickerPalace.ViewModels
{
    public class ScheduleUCViewModel : BaseViewModel
    {
        private MovieSchedule movie;

        public MovieSchedule Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        private List<string> _dates;

        public List<string> Dates
        {
            get { return _dates; }
            set { _dates = value; OnPropertyChanged("Dates"); }
        }

        private string currentDate;

        public string CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; OnPropertyChanged(); }
        }
        private string currentTheater;

        public string CurrentTheater
        {
            get { return currentTheater; }
            set { currentTheater = value; OnPropertyChanged(); }
        }

        private List<string> theaters;

        public List<string> Theaters
        {
            get { return theaters; }
            set { theaters = value; OnPropertyChanged("Dates"); }
        }

        private ObservableCollection<MovieSchedule> movies = new ObservableCollection<MovieSchedule>();

        public ObservableCollection<MovieSchedule> Movies
        {
            get { return movies; }
            set { movies = value; OnPropertyChanged(); }
        }


        private Visibility _isComboBoxVisible;

        public Visibility IsComboBoxVisible
        {
            get { return _isComboBoxVisible; }
            set
            {
                _isComboBoxVisible = value;
                OnPropertyChanged(nameof(IsComboBoxVisible));
            }
        }
        private int _rowNumber;
        private bool _isAvailable;
        private bool _isSelected;
        private int _seatNumber;

        public int RowNumber
        {
            get { return _rowNumber; }
            set
            {
                _rowNumber = value;
                OnPropertyChanged();
            }
        }

        public int SeatNumber
        {
            get { return _seatNumber; }
            set
            {
                _seatNumber = value;
                OnPropertyChanged();
            }
        }

        public bool IsAvailable
        {
            get { return _isAvailable; }
            set
            {
                _isAvailable = value;
                OnPropertyChanged();
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged();
            }
        }
        private ObservableCollection<MovieSchedule> allMovies;

        public ObservableCollection<MovieSchedule> AllMovies
        {
            get { return allMovies; }
            set { allMovies = value; OnPropertyChanged(); }
        }

        public RelayCommand AppleClickCommand { get; set; }
        public RelayCommand AndroidClickCommand { get; set; }
        public RelayCommand ButtonCommand { get; set; }
        public RelayCommand SelectedCommand { get; set; }
        public RelayCommand SeatClickCommand { get; set; }
        public RelayCommand LogoClickCommand { get; set; }
        public RelayCommand SelectedTheaterCommand { get; set; }
        public ScheduleUCViewModel()
        {
            Dates = new List<string>();
            Movies = new ObservableCollection<MovieSchedule>(App.ScheduleRepo.MovieSchedules);
            for (int i = 0; i < 6; i++)
            {
                Dates.Add(DateTime.Now.AddDays(i).ToString("dd/MM/yyyy"));
            }
            Theaters = new List<string>();
            Theaters.Add("Flicker Palace New York");
            Theaters.Add("Flicker Palace Ohio");
            Theaters.Add("Flicker Palace Las Vegas");

            LogoClickCommand = new RelayCommand((obj) =>
            {
                App.BackPage = App.MyGrid.Children[0];

                var uc = new HomeUC();
                var vm = new HomeUCViewModel();

                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
            SeatClickCommand = new RelayCommand(async (obj) =>
            {
                var current = obj as MovieSchedule;
                var uc = new SeatUC();
                var vm = new SeatUCViewModel();
                vm.Movie = current;
                string apiUrl = "https://21521809.pythonanywhere.com/toggleButtonState";

                HttpClient client = new HttpClient();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                string responseContent = await response.Content.ReadAsStringAsync();

                List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(responseContent);
                //string json = File.ReadAllText("toggleButtonState.json");
                //List<SelectedButtons> buttonStates = JsonConvert.DeserializeObject<List<SelectedButtons>>(json);
                if (buttonStates != null)
                {
                    foreach (var item in buttonStates)
                    {
                        foreach (var temp in uc.myGrid.Children)
                        {
                            if (temp is ToggleButton toggleButton)
                            {
                                if (item.ButtonName == toggleButton.Name && item.Movie.MovieName == current.MovieName && item.Movie.MovieDate == current.MovieDate && item.Movie.MovieDateTime == current.MovieDateTime)
                                {
                                    toggleButton.IsChecked = true;
                                    toggleButton.IsEnabled = false;
                                    break;
                                }
                            }
                        }

                    }
                }
                
                uc.DataContext = vm;
                App.MyGrid.Children.Add(uc);
            });
            SelectedCommand = new RelayCommand((obj) =>
            {
                var date = obj as string;
                CurrentDate = date;
                var newMovies = new ObservableCollection<MovieSchedule>();

                foreach (var item in AllMovies)
                {
                    if (date == item.MovieDate)
                    {
                        if (CurrentTheater != null)
                        {
                            if (item.Theater == CurrentTheater)
                            {
                                newMovies.Add(item);
                            }
                        }
                        else
                        {
                            newMovies.Add(item);
                        }
                    }
                }

                Movies = newMovies;
                if (newMovies.Count != 0)
                {
                    Movie = newMovies[0];
                }
            });

            SelectedTheaterCommand = new RelayCommand((obj) =>
            {
                var theater = obj as string;
                CurrentTheater = theater;
                var newMovies = new ObservableCollection<MovieSchedule>();

                foreach (var item in AllMovies)
                {
                    if (theater == item.Theater)
                    {
                        if (CurrentDate != null)
                        {
                            if (CurrentDate == item.MovieDate)
                            {
                                newMovies.Add(item);
                            }
                        }
                        else
                        {
                            newMovies.Add(item);
                        }
                    }
                }
                Movies = newMovies;
                if (newMovies.Count != 0)
                {
                    Movie = newMovies[0];
                }
            });
        }

    }
}
