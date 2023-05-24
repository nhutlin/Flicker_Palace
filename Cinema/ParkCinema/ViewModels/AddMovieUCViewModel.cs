using ParkCinema.Commands;
using ParkCinema.Services;
using ParkCinema.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ParkCinema.ViewModels
{
    public class AddMovieUCViewModel:BaseViewModel
    {
        private string searchText;

        public string SearchText
        {
            get { return searchText; }
            set { searchText = value; OnPropertyChanged(); }
        }

        public RelayCommand SearchCommand { get; set; }
        public RelayCommand BackToUserCommand { get; set; }

        public WrapPanel MyPanel { get; set; }

        public AddMovieUCViewModel()
        {
            SearchCommand = new RelayCommand((obj) =>
            {
                
                var movies = AddMovie.GetMovies(SearchText);
                int x = 10;
                
                foreach (var m in movies)
                {
                    var ucVM = new MovieCellViewModel
                    {
                        Movie = m
                    };
                    var uc = new MovieCellUC(ucVM);
                    
                    uc.Margin = new System.Windows.Thickness(x, 100, 100, 0);
                    App.MyGrid.Children.Add(uc);
                    x +=400;
                    
                }
            });
            BackToUserCommand = new RelayCommand((obj) =>
            {
                var uc = new HomeUC();
                var vm = new HomeUCViewModel();
                uc.DataContext = vm;
                App.MyGrid.Children.RemoveAt(0);
                App.MyGrid.Children.Add(uc);
            });
        }
    }
}
