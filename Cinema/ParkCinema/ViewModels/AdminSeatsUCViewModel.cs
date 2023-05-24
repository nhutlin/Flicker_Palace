using Newtonsoft.Json;
using ParkCinema.Commands;
using ParkCinema.Models;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Markup;

namespace ParkCinema.ViewModels
{
    public class AdminSeatsUCViewModel : BaseViewModel
    {
        public RelayCommand PlaceClickCommand { get; set; }
        private MovieSchedule movie;
        public List<int> SelectedRows { get; set; } = new List<int> { };
        public List<int> SelectedColumns { get; set; } = new List<int> { };
        public static List<SelectedButtons> AllSeatNames { get; set; } = new List<SelectedButtons> { };

        private int row;

        public int SelectedRow
        {
            get { return row; }
            set { row = value; OnPropertyChanged(); }
        }
        private int column;

        public int SelectedColumn
        {
            get { return column; }
            set { column = value; OnPropertyChanged(); }
        }
        private string seat;
        public string Seat
        {
            get { return seat; }
            set { seat = value; OnPropertyChanged(); }
        }
        public MovieSchedule Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        private List<SelectedButtons> myData;

        public List<SelectedButtons> Data
        {
            get { return myData; }
            set { myData = value;OnPropertyChanged(); }
        }

        
        private void Places(ToggleButton toggleButton)
        {

            SelectedRow = Grid.GetRow(toggleButton);
            SelectedColumn = Grid.GetColumn(toggleButton);
            if (SelectedRow == 0)
            {
                SelectedColumn++;
            }
            else if (SelectedRow > 0 && SelectedRow < 11)
            {
                SelectedColumn--;
            }
            else
            {
                SelectedColumn -= 2;
            }
            SelectedRow = Math.Abs(SelectedRow - 12);
            Seat += " Row - ";
            Seat += SelectedRow;
            Seat += " Seat - ";
            Seat += SelectedColumn;
            

        }
        bool IsSame = false;
        private void PlaceClick(Grid grid)
        {
            List<int> numbers = new List<int>();
            foreach (UIElement child in grid.Children)
            {
                numbers = new List<int>();
                ToggleButton toggleButton = child as ToggleButton;
                if (toggleButton != null && !AllSeatNames.Any(m=>m.ButtonName==toggleButton.Name))
                {
                    if (File.Exists("adminSelected.json"))
                    {
                        string jsonString = File.ReadAllText("adminSelected.json");

                        var data = JsonConvert.DeserializeObject<List<SelectedButtons>>(jsonString);
                        if (data != null)
                        {
                            foreach (var btn in data)
                            {
                                if (btn.Movie.MovieName == Movie.MovieName && btn.Movie.MovieDate == Movie.MovieDate && btn.Movie.MovieDate == Movie.MovieDate && !AllSeatNames.Any(m=>m.ButtonName==toggleButton.Name && m.Movie==Movie))
                                {
                                    if (toggleButton.IsChecked == true && toggleButton.Name != btn.ButtonName)
                                    {
                                        IsSame = true;
                                    }
                                    else
                                    {
                                        IsSame = false;
                                    }
                                    numbers.Add(0);
                                }
                                else
                                {
                                    numbers.Add(1);
                                }
                            }
                        }
                        else
                        {
                            data = new List<SelectedButtons>();
                        }
                        if (IsSame || !numbers.Contains(0))
                        {
                            if (toggleButton.IsChecked == true)
                            {
                                Places(toggleButton);
                                var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
                                AllSeatNames.Add(current);
                                data.Add(current);
                                toggleButton.IsEnabled = false;
                                SelectedRows.Add(SelectedRow);
                                SelectedColumns.Add(SelectedColumn);
                                jsonString = JsonConvert.SerializeObject(data);
                                File.WriteAllText("adminSelected.json", jsonString);
                                break;
                            }
                        }
                    }
                    else
                    {
                        if (toggleButton.IsChecked == true)
                        {
                            Places(toggleButton);
                            var current = new SelectedButtons { Movie = Movie, ButtonName = toggleButton.Name, IsChecked = (bool)toggleButton.IsChecked };
                            AllSeatNames.Add(current);
                            toggleButton.IsEnabled = false;
                            SelectedRows.Add(SelectedRow);
                            SelectedColumns.Add(SelectedColumn);
                            string jsonString = JsonConvert.SerializeObject(AllSeatNames);
                            File.WriteAllText("adminSelected.json", jsonString);
                            break;
                        }
                    }
                }
            }
        }
        public AdminSeatsUCViewModel()
        {
            PlaceClickCommand = new RelayCommand((obj) =>
            {
                var grid = obj as Grid;
                PlaceClick(grid);
            });

        }
    }
}
